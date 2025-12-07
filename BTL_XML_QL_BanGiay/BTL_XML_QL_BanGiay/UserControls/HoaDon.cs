using BTL_XML_QL_BanGiay.Models;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace BTL_XML_QL_BanGiay.UserControls
{
    public partial class HoaDon : UserControl
    {
        Connect cnn = new Connect();
        HoaDonModel hdModel = new HoaDonModel();

        DataTable dtHoaDon, dtChiTiet, dtNhanVien, dtGiay;

        private string tenNhanVienHienTai = "";

        // --- CONSTRUCTOR 1: Mặc định (Dùng cho Designer) ---
        public HoaDon()
        {
            InitializeComponent();
            SetupEvents();
        }

        // --- CONSTRUCTOR 2: Có tham số (Dùng cho TrangChu gọi) ---
        public HoaDon(string tenNhanVien) : this()
        {
            this.tenNhanVienHienTai = tenNhanVien;
        }

        private void SetupEvents()
        {
            this.Load += HoaDon_Load;
            this.dgvHoaDon.SelectionChanged += DgvHoaDon_SelectionChanged;
            this.btnIn.Click += BtnIn_Click;
            this.btnThem.Click += BtnThem_Click;
            // Đã xóa sự kiện BtnXoa_Click
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadAllData()
        {
            try
            {
                // 1. Load Hóa Đơn
                dtHoaDon = cnn.showTable("HoaDon.xml");
                if (dtHoaDon != null)
                {
                    dgvHoaDon.DataSource = dtHoaDon;
                    dgvHoaDon.Columns["mahoadon"].HeaderText = "Mã HĐ";
                    dgvHoaDon.Columns["manhanvien"].HeaderText = "Mã NV";
                    dgvHoaDon.Columns["ngaytao"].HeaderText = "Ngày tạo";
                    dgvHoaDon.Columns["tongtien"].HeaderText = "Tổng tiền";
                    dgvHoaDon.Columns["tongtien"].DefaultCellStyle.Format = "N0";

                    if (dgvHoaDon.Columns.Contains("hinhthucthanhtoan")) dgvHoaDon.Columns["hinhthucthanhtoan"].Visible = false;
                    if (dgvHoaDon.Columns.Contains("trangthai")) dgvHoaDon.Columns["trangthai"].Visible = false;
                }

                // 2. Load các bảng phụ trợ
                dtChiTiet = cnn.showTable("ChiTietHoaDon.xml");
                dtNhanVien = cnn.showTable("NhanVien.xml");
                dtGiay = cnn.showTable("Giay.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void DgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvHoaDon.SelectedRows[0];
                string maHD = row.Cells["mahoadon"].Value?.ToString() ?? "";
                string maNV = row.Cells["manhanvien"].Value?.ToString() ?? "";
                string ngay = row.Cells["ngaytao"].Value?.ToString() ?? "";
                string tongTien = row.Cells["tongtien"].Value?.ToString() ?? "0";

                lblValMaHD.Text = maHD;

                DateTime dtNgay;
                if (DateTime.TryParse(ngay, out dtNgay))
                    lblValNgay.Text = dtNgay.ToString("dd/MM/yyyy HH:mm");
                else
                    lblValNgay.Text = ngay;

                decimal decTongTien;
                if (decimal.TryParse(tongTien, out decTongTien))
                    lblValTongTien.Text = decTongTien.ToString("N0") + " VNĐ";
                else
                    lblValTongTien.Text = tongTien;

                string tenNV = maNV;
                if (dtNhanVien != null)
                {
                    DataRow[] nvRows = dtNhanVien.Select($"manhanvien = '{maNV}'");
                    if (nvRows.Length > 0) tenNV = nvRows[0]["hoten"].ToString();
                }
                lblValNhanVien.Text = tenNV;

                if (dtChiTiet != null && dtGiay != null)
                {
                    DataRow[] chiTietRows = dtChiTiet.Select($"mahoadon = '{maHD}'");
                    DataTable dtHienThi = new DataTable();
                    dtHienThi.Columns.Add("Tên Sản Phẩm");
                    dtHienThi.Columns.Add("Số Lượng");
                    dtHienThi.Columns.Add("Đơn Giá");
                    dtHienThi.Columns.Add("Thành Tiền");

                    foreach (DataRow item in chiTietRows)
                    {
                        string maGiay = item["magiay"].ToString();
                        int sl = 0; int.TryParse(item["soluong"].ToString(), out sl);
                        decimal donGia = 0; decimal.TryParse(item["dongia"].ToString(), out donGia);
                        decimal thanhTien = sl * donGia;

                        string tenGiay = maGiay;
                        DataRow[] giayRows = dtGiay.Select($"magiay = '{maGiay}'");
                        if (giayRows.Length > 0) tenGiay = giayRows[0]["tengiay"].ToString();

                        dtHienThi.Rows.Add(tenGiay, sl, donGia.ToString("N0"), thanhTien.ToString("N0"));
                    }

                    dgvChiTiet.DataSource = dtHienThi;
                    if (dgvChiTiet.Columns.Count > 0)
                    {
                        dgvChiTiet.Columns[0].Width = 200;
                        dgvChiTiet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvChiTiet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvChiTiet.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
            }
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            if (lblValMaHD.Text == "---" || string.IsNullOrEmpty(lblValMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in.");
                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(pnlInvoicePaper.Width, pnlInvoicePaper.Height);
            pnlInvoicePaper.DrawToBitmap(bmp, new Rectangle(0, 0, pnlInvoicePaper.Width, pnlInvoicePaper.Height));
            int x = (e.PageBounds.Width - bmp.Width) / 2;
            int y = 50;
            e.Graphics.DrawImage(bmp, x, y);
        }

        // --- SỰ KIỆN: CHUYỂN SANG TRANG THÊM HÓA ĐƠN ---
        private void BtnThem_Click(object sender, EventArgs e)
        {
            // Tìm Form cha là TrangChu để gọi hàm chuyển đổi UserControl
            Form parentForm = this.FindForm();
            if (parentForm != null && parentForm is Forms.TrangChu)
            {
                Forms.TrangChu trangChu = (Forms.TrangChu)parentForm;
                trangChu.addUserControl(new ThemHoaDon());
            }
            else
            {
                MessageBox.Show("Không tìm thấy Form TrangChu để chuyển hướng.");
            }
        }
    }
}