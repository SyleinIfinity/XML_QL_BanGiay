using System;
using System.Windows.Forms;
using System.Xml.Linq;
using BTL_XML_QL_BanGiay.Models;
using BTL_XML_QL_BanGiay.UserControls;

namespace BTL_XML_QL_BanGiay.Forms
{
    public partial class DangNhap : Form
    {
        DangNhapModel login = new DangNhapModel();
       
        public XDocument xDoc;
        public string filePath = "TaiKhoan.xml";

        public DangNhap()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            txtField_staffCode.Width = 252;
            txtField_password.Width = 252;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string staffCode = txtField_staffCode.Text.Trim();
            string password = txtField_password.Text.Trim();
            

            if (string.IsNullOrEmpty(staffCode) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtField_staffCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(staffCode))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtField_staffCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtField_password.Focus();
                return;
            }
            
            HandleLogin(staffCode, password);
        }
        

        private void chkBx_showPassword_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtField_password.UseSystemPasswordChar = true;
        }

        private void HandleLogin(string staffCode, string password)
        {
            if (login.checkLogin(filePath, staffCode, password))
            {
                bool quyen = login.getRole(filePath, staffCode);
                string tenNhanVien = login.getStaffName(filePath, staffCode);
                
                TrangChu tc = new TrangChu(quyen ? TrangChu.UserRole.Admin : TrangChu.UserRole.User)
                {
                    StaffCode = staffCode,
                    StaffName = tenNhanVien 
                };

                string roleText = quyen ? "Chủ cửa hàng" : "Nhân viên";
                MessageBox.Show($"Đăng nhập thành công!\nXin chào {tenNhanVien}.\nBạn là {roleText}.", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                tc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai mã nhân viên hoặc mật khẩu. Vui lòng thử lại.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtField_staffCode.Focus();
            }
        }

        private void btn_showPass_Click(object sender, EventArgs e)
        {
            if (btn_showPass.BackgroundImage == Properties.Resources.eye)
            {
                // Đang mở → chuyển sang đóng
                btn_showPass.BackgroundImage = Properties.Resources.hidden;
                txtField_password.UseSystemPasswordChar = true;
            }
            else
            {
                // Đang đóng → mở
                btn_showPass.BackgroundImage = Properties.Resources.eye;
                txtField_password.UseSystemPasswordChar = false;
            }

        }

        private void txtField_staffCode_Click(object sender, EventArgs e)
        {

        }
    }
}
