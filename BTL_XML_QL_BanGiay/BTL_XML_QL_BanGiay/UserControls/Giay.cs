using BTL_XML_QL_BanGiay.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace BTL_XML_QL_BanGiay.UserControls
{
    public partial class Giay : UserControl
    {
        // Khởi tạo các đối tượng xử lý
        Connect cnn = new Connect();
        GiayModel gM = new GiayModel();

        // Biến trạng thái
        private bool isEditing = false; // False = Đang thêm, True = Đang sửa

        public Giay()
        {
            InitializeComponent();

            // Đăng ký sự kiện
            this.Load += Giay_Load;
            this.btnTimKiem.Click += BtnTimKiem_Click;
            this.txtTimKiem.TextChanged += TxtTimKiem_TextChanged;
            this.cboLocHieuGiay.SelectedIndexChanged += CboLocHieuGiay_SelectedIndexChanged;

            // Sự kiện CRUD
            this.btnThem.Click += BtnThem_Click;
            this.btnSua.Click += BtnSua_Click;
            this.btnXoa.Click += BtnXoa_Click;

            // Sự kiện Dialog
            this.btnLuu.Click += BtnLuu_Click;
            this.btnHuy.Click += BtnHuy_Click;
        }

        private void Giay_Load(object sender, EventArgs e)
        {
            loadHieuGiay(); // Load combo box trước
            loadGiay();     // Load dữ liệu bảng
            pnlDialog.Visible = false; // Đảm bảo dialog ẩn khi mở
        }

        #region Load Data XML
        private void loadGiay()
        {
            try
            {
                DataTable dt = cnn.showTable("Giay.xml");
                if (dt != null)
                {
                    dgvGiay.DataSource = dt;
                    // Cấu hình header tiếng Việt
                    dgvGiay.Columns["magiay"].HeaderText = "Mã Giày";
                    dgvGiay.Columns["mahieugiay"].HeaderText = "Hiệu Giày";
                    dgvGiay.Columns["tengiay"].HeaderText = "Tên Giày";
                    dgvGiay.Columns["size"].HeaderText = "Size";
                    dgvGiay.Columns["mau"].HeaderText = "Màu";
                    dgvGiay.Columns["dongia"].HeaderText = "Đơn Giá";
                    dgvGiay.Columns["soluong"].HeaderText = "Số Lượng";

                    // Format tiền tệ
                    dgvGiay.Columns["dongia"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu giày: " + ex.Message);
            }
        }

        private void loadHieuGiay()
        {
            try
            {
                // Load cho ComboBox LỌC và ComboBox NHẬP LIỆU
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("HieuGiay.xml");
                XmlNodeList nodeList = xmlDoc.GetElementsByTagName("_x0027_HieuGiay_x0027_");

                List<string> listHieuGiay = new List<string>();
                List<string> listLoc = new List<string>();

                listLoc.Add("Tất cả"); // Thêm tùy chọn xem tất cả

                foreach (XmlNode node in nodeList)
                {
                    if (node["mahieugiay"] != null)
                    {
                        string mahieu = node["mahieugiay"].InnerText;
                        listHieuGiay.Add(mahieu);
                        listLoc.Add(mahieu);
                    }
                }

                // Gán dữ liệu
                cboHieuGiay.DataSource = listHieuGiay;
                cboLocHieuGiay.DataSource = listLoc;
                cboLocHieuGiay.SelectedIndex = 0; // Chọn 'Tất cả' mặc định
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải hiệu giày: " + ex.Message);
            }
        }
        #endregion

        #region Xử lý Giao diện Dialog (Panel Overlay)

        // Hiện Dialog (Thực chất là hiện Panel trùm lên)
        private void ShowDialogMode(bool isEdit)
        {
            isEditing = isEdit;
            pnlDialog.Visible = true;
            pnlDialog.BringToFront(); // Đưa lên lớp trên cùng

            // Xóa trắng hoặc fill dữ liệu
            if (isEdit)
            {
                lblDialogTitle.Text = "CẬP NHẬT THÔNG TIN GIÀY";
                txtMaGiay.Enabled = false; // Không cho sửa mã

                // Lấy dòng đang chọn
                if (dgvGiay.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvGiay.SelectedRows[0];
                    txtMaGiay.Text = row.Cells["magiay"].Value.ToString();
                    cboHieuGiay.Text = row.Cells["mahieugiay"].Value.ToString();
                    txtTenGiay.Text = row.Cells["tengiay"].Value.ToString();
                    txtSize.Text = row.Cells["size"].Value.ToString();
                    txtMau.Text = row.Cells["mau"].Value.ToString();
                    txtDonGia.Text = row.Cells["dongia"].Value.ToString();
                    txtSoLuong.Text = row.Cells["soluong"].Value.ToString();
                }
            }
            else
            {
                lblDialogTitle.Text = "THÊM GIÀY MỚI";
                txtMaGiay.Enabled = true;
                ClearInputs();
            }
        }

        private void HideDialogMode()
        {
            pnlDialog.Visible = false;
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtMaGiay.Clear();
            txtTenGiay.Clear();
            txtSize.Clear();
            txtMau.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            if (cboHieuGiay.Items.Count > 0) cboHieuGiay.SelectedIndex = 0;
        }

        #endregion

        #region Sự kiện Nút Lệnh Chính

        // 1. Thêm: Mở Dialog mode Thêm
        private void BtnThem_Click(object sender, EventArgs e)
        {
            ShowDialogMode(false);
        }

        // 2. Sửa: Mở Dialog mode Sửa
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvGiay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn giày cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ShowDialogMode(true);
        }

        // 3. Xóa: Thực hiện xóa ngay
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGiay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn giày cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maGiay = dgvGiay.SelectedRows[0].Cells["magiay"].Value.ToString();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giày mã: " + maGiay + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (gM.checkShoeCode(maGiay))
                {
                    gM.deleteShoe(maGiay);
                    MessageBox.Show("Xóa thành công!");
                    loadGiay();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để xóa.");
                }
            }
        }
        #endregion

        #region Sự kiện trong Dialog (Lưu / Hủy)

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            HideDialogMode();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            string ma = txtMaGiay.Text.Trim();
            string hieu = cboHieuGiay.Text;
            string ten = txtTenGiay.Text.Trim();
            string size = txtSize.Text.Trim();
            string mau = txtMau.Text.Trim();
            string gia = txtDonGia.Text.Trim();
            string sl = txtSoLuong.Text.Trim();

            // Validate cơ bản
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(gia) || string.IsNullOrEmpty(sl))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi Model xử lý
            if (isEditing)
            {
                // Đang sửa
                gM.updateShoe(ma, hieu, ten, size, mau, gia, sl);
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                // Đang thêm
                if (gM.checkShoeCode(ma))
                {
                    MessageBox.Show("Mã giày đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                gM.createShoe(ma, hieu, ten, size, mau, gia, sl);
                MessageBox.Show("Thêm mới thành công!");
            }

            // Load lại và ẩn Dialog
            loadGiay();
            HideDialogMode();
        }

        #endregion

        #region Tìm kiếm và Lọc

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void CboLocHieuGiay_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void ThucHienTimKiem()
        {
            try
            {
                DataTable dt = cnn.showTable("Giay.xml");
                if (dt == null) return;

                string tuKhoa = txtTimKiem.Text.Trim().ToLower();
                string hieuGiayLoc = cboLocHieuGiay.Text; // Lấy giá trị combo lọc

                DataView dv = dt.DefaultView;
                string filter = "";

                // 1. Lọc theo từ khóa (Mã hoặc Tên)
                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    filter = string.Format("(magiay LIKE '%{0}%' OR tengiay LIKE '%{0}%')", tuKhoa);
                }

                // 2. Lọc theo Hiệu giày (nếu không chọn 'Tất cả')
                if (hieuGiayLoc != "Tất cả" && !string.IsNullOrEmpty(hieuGiayLoc))
                {
                    if (filter.Length > 0) filter += " AND ";
                    filter += string.Format("mahieugiay = '{0}'", hieuGiayLoc);
                }

                dv.RowFilter = filter;
                dgvGiay.DataSource = dv;
            }
            catch (Exception ex)
            {
                // Bỏ qua lỗi lọc nhỏ
            }
        }
        #endregion
    }
}