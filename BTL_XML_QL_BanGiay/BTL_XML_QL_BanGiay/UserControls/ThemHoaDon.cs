using BTL_XML_QL_BanGiay.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_XML_QL_BanGiay.UserControls
{
    public partial class ThemHoaDon : UserControl
    {
        // Khai báo các Model
        Connect cnn = new Connect();
        HoaDonModel hdModel = new HoaDonModel();

        // Dữ liệu dùng chung
        DataTable dtGiay;
        DataTable dtGioHang; // Giỏ hàng tạm thời

        // Biến lưu thông tin nhân viên đăng nhập
        string staffCode = "NV01"; // Mặc định nếu test
        string staffName = "Admin";

        // Biến static để HoaDonModel gọi cập nhật tồn kho (như logic cũ của bạn)
        public static int quantityRest = 0;

        public ThemHoaDon()
        {
            InitializeComponent();
            SetupEvents();
            InitGioHang();
        }

        private void SetupEvents()
        {
            this.Load += ThemHoaDon_Load;
            this.cboChonGiay.SelectedIndexChanged += CboChonGiay_SelectedIndexChanged;
            this.btnThemGioHang.Click += BtnThemGioHang_Click;
            this.btnThanhToan.Click += BtnThanhToan_Click;
            this.btnHuy.Click += BtnHuy_Click;
            this.dgvGioHang.CellClick += DgvGioHang_CellClick; // Để xóa dòng
        }

        private void InitGioHang()
        {
            // Tạo cấu trúc bảng Giỏ hàng (chưa lưu vào DB)
            dtGioHang = new DataTable();
            dtGioHang.Columns.Add("magiay");
            dtGioHang.Columns.Add("tengiay");
            dtGioHang.Columns.Add("dongia", typeof(decimal));
            dtGioHang.Columns.Add("soluong", typeof(int));
            dtGioHang.Columns.Add("thanhtien", typeof(decimal));

            dgvGioHang.DataSource = dtGioHang;

            // Format hiển thị
            dgvGioHang.Columns["magiay"].HeaderText = "Mã Giày";
            dgvGioHang.Columns["tengiay"].HeaderText = "Tên Sản Phẩm";
            dgvGioHang.Columns["dongia"].HeaderText = "Đơn Giá";
            dgvGioHang.Columns["soluong"].HeaderText = "SL";
            dgvGioHang.Columns["thanhtien"].HeaderText = "Thành Tiền";

            dgvGioHang.Columns["dongia"].DefaultCellStyle.Format = "N0";
            dgvGioHang.Columns["thanhtien"].DefaultCellStyle.Format = "N0";
        }

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            // 1. Sinh mã hóa đơn tự động
            lblMaHD.Text = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
            lblNgayBan.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // 2. Lấy thông tin nhân viên từ Form cha (TrangChu) nếu có
            Form parent = this.FindForm();
            if (parent != null && parent is Forms.TrangChu) // Giả sử namespace Forms
            {
                var mainForm = (Forms.TrangChu)parent;
                // Nếu TrangChu có property StaffCode, StaffName
                if (!string.IsNullOrEmpty(mainForm.StaffCode)) staffCode = mainForm.StaffCode;
                if (!string.IsNullOrEmpty(mainForm.StaffName)) staffName = mainForm.StaffName;
            }
            lblNhanVien.Text = staffName;

            // 3. Load danh sách giày vào ComboBox
            LoadGiay();
        }

        private void LoadGiay()
        {
            dtGiay = cnn.showTable("Giay.xml");
            if (dtGiay != null)
            {
                // Tạo cột hiển thị tên + giá cho dễ chọn
                dtGiay.Columns.Add("Display", typeof(string), "tengiay + ' (' + magiay + ')'");

                cboChonGiay.DataSource = dtGiay;
                cboChonGiay.DisplayMember = "Display";
                cboChonGiay.ValueMember = "magiay";
            }
        }

        private void CboChonGiay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonGiay.SelectedValue != null)
            {
                string maGiay = cboChonGiay.SelectedValue.ToString();
                DataRow[] rows = dtGiay.Select("magiay = '" + maGiay + "'");
                if (rows.Length > 0)
                {
                    decimal gia = decimal.Parse(rows[0]["dongia"].ToString());
                    int tonKho = int.Parse(rows[0]["soluong"].ToString());

                    lblDonGia.Text = gia.ToString("N0");
                    lblTonKho.Text = tonKho.ToString();

                    // Reset số lượng nhập
                    numSoLuong.Value = 1;
                    numSoLuong.Maximum = tonKho > 0 ? tonKho : 1; // Không cho nhập quá tồn
                }
            }
        }

        // --- NÚT THÊM VÀO GIỎ ---
        private void BtnThemGioHang_Click(object sender, EventArgs e)
        {
            if (cboChonGiay.SelectedIndex == -1) return;

            string maGiay = cboChonGiay.SelectedValue.ToString();
            // Lấy tên giày từ ComboBox item (DataRowView)
            DataRowView drv = (DataRowView)cboChonGiay.SelectedItem;
            string tenGiay = drv["tengiay"].ToString();

            decimal donGia = decimal.Parse(lblDonGia.Text.Replace(".", "").Replace(",", "")); // Parse tiền tệ
            int soLuong = (int)numSoLuong.Value;
            int tonKho = int.Parse(lblTonKho.Text);

            if (soLuong > tonKho)
            {
                MessageBox.Show("Số lượng mua vượt quá tồn kho!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra hàng đã có trong giỏ chưa
            bool exists = false;
            foreach (DataRow row in dtGioHang.Rows)
            {
                if (row["magiay"].ToString() == maGiay)
                {
                    // Cộng dồn
                    int slCu = int.Parse(row["soluong"].ToString());
                    if (slCu + soLuong > tonKho)
                    {
                        MessageBox.Show("Tổng số lượng trong giỏ vượt quá tồn kho!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    row["soluong"] = slCu + soLuong;
                    row["thanhtien"] = (slCu + soLuong) * donGia;
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                // Thêm mới
                dtGioHang.Rows.Add(maGiay, tenGiay, donGia, soLuong, donGia * soLuong);
            }

            CapNhatTongTien();
        }

        // --- XÓA KHỎI GIỎ (Click vào lưới) ---
        private void DgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu click chuột phải hoặc muốn xóa...
            // Ở đây đơn giản: Click đúp hoặc tạo nút xóa riêng.
            // Code demo xóa hàng khi chọn và nhấn Delete trên bàn phím thì hay hơn, nhưng để đơn giản:
            // Bạn có thể thêm 1 nút "Xóa dòng chọn" ở giao diện
        }

        private void CapNhatTongTien()
        {
            decimal tong = 0;
            foreach (DataRow row in dtGioHang.Rows)
            {
                tong += decimal.Parse(row["thanhtien"].ToString());
            }
            lblTongTien.Text = tong.ToString("N0") + " VNĐ";
            lblTongTien.Tag = tong; // Lưu giá trị số để tính toán
        }

        // --- THANH TOÁN (Lưu XML) ---
        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtTenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }

            try
            {
                // 1. Chuẩn bị dữ liệu Header Hóa Đơn
                string maHD = lblMaHD.Text;
                string maNV = staffCode; // Lấy từ biến toàn cục
                string tenKhach = txtTenKhach.Text;
                string ngayTao = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"); // Format chuẩn XML date
                string pttt = "Tiền mặt"; // Hoặc lấy từ RadioButton nếu có
                string trangThai = "Đã thanh toán";
                decimal tongTien = decimal.Parse(lblTongTien.Tag.ToString());

                // 2. Gọi Model để tạo Hóa Đơn (Header)
                // Lưu ý: Hàm createBill của bạn đang thiết kế hơi lạ (nhận vào 1 sản phẩm đầu tiên).
                // Để tương thích code cũ, ta sẽ lấy sản phẩm đầu tiên để gọi createBill,
                // sau đó vòng lặp add các sản phẩm còn lại.

                // Lấy dòng đầu tiên
                DataRow firstRow = dtGioHang.Rows[0];
                string firstShoe = firstRow["magiay"].ToString();
                int firstQty = int.Parse(firstRow["soluong"].ToString());
                decimal firstPrice = decimal.Parse(firstRow["dongia"].ToString());

                // Set biến static để Model tính tồn kho (theo logic cũ của bạn)
                // Cần lấy tồn kho hiện tại của giày này
                DataRow[] rows = dtGiay.Select($"magiay = '{firstShoe}'");
                if (rows.Length > 0) quantityRest = int.Parse(rows[0]["soluong"].ToString());

                // Gọi tạo Hóa đơn + Chi tiết đầu tiên
                hdModel.createBill(maHD, firstShoe, maNV, tenKhach, ngayTao, pttt, firstPrice, trangThai, firstQty, tongTien);

                // 3. Vòng lặp thêm các chi tiết còn lại (từ dòng thứ 2 trở đi)
                for (int i = 1; i < dtGioHang.Rows.Count; i++)
                {
                    DataRow r = dtGioHang.Rows[i];
                    string sCode = r["magiay"].ToString();
                    int sQty = int.Parse(r["soluong"].ToString());
                    decimal sPrice = decimal.Parse(r["dongia"].ToString());

                    // Cập nhật tồn kho static cho món này
                    rows = dtGiay.Select($"magiay = '{sCode}'");
                    if (rows.Length > 0) quantityRest = int.Parse(rows[0]["soluong"].ToString());

                    hdModel.createBillDetail(maHD, sCode, sQty, sPrice);
                }

                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán: " + ex.Message);
            }
        }

        private void ResetForm()
        {
            dtGioHang.Clear();
            txtTenKhach.Clear();
            txtSDT.Clear();
            lblMaHD.Text = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
            CapNhatTongTien();
            LoadGiay(); // Load lại để cập nhật tồn kho mới
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if (dtGioHang.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn hủy đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ResetForm();
                }
            }
        }
    }
}