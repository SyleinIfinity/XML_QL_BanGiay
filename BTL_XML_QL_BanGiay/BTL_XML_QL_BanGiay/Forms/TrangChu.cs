using BTL_XML_QL_BanGiay.Models;
using BTL_XML_QL_BanGiay.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_XML_QL_BanGiay.Forms
{
    public partial class TrangChu : Form
    {   
        public enum UserRole
        {
            Admin,
            User
        }
         Connect cnn = new Connect();
        public UserRole Role{get; set;}
        public string StaffCode { get; set; } 
        public string StaffName { get; set; } 

        public TrangChu(UserRole role)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Role = role;
            tuyChinhMenu();
            hideMenu();
            roleLogin(role);
        }

        private void roleLogin(UserRole role)
        {
            if (role == UserRole.Admin)
            {          
                btn_staff.Enabled = true;
                btn_category.Enabled = true;
                btn_account.Enabled = true;
                btn_shoeBrand.Enabled = true;
                btn_shoe.Enabled = true;
                btn_bill.Enabled = true;
            }
            else
            {
                btn_staff.Enabled = false;  
                btn_category.Enabled = true;
                btn_account.Enabled = false;  
                btn_shoeBrand.Enabled = true;
                btn_shoe.Enabled = true;
                btn_bill.Enabled = true;
            }
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_main.Controls.Clear();
            panel_main.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void tuyChinhMenu()
        {
            panel_managament.Visible = false;
            panel_change.Visible = false;   
        }

        private void hideMenu()
        {
            if (panel_managament.Visible == true)
            {
                panel_managament.Visible = false;
            }

            if (panel_change.Visible == true) 
            { 
                panel_change.Visible= false;
            }
        }

        private void showSubMenu(Panel menuPhu)
        {
            if (menuPhu.Visible == false)
            {
                hideMenu();
                menuPhu.Visible = true;
            }
            else { 
                menuPhu.Visible = false;
            }
        }

        private void btn_managament_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_managament);
        }

        private void btn_chuyenDoi_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_change);
        }


        private void btn_staff_Click(object sender, EventArgs e)
        {
            //..............
            if (Role == UserRole.Admin)
            {
                NhanVien nv = new NhanVien();   
                addUserControl(nv);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền quản lý nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            hideMenu();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            //...
            DanhMuc dm = new DanhMuc();
            addUserControl(dm);


            hideMenu();
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            //...
            if (Role == UserRole.Admin) { 
                TaiKhoan tk = new TaiKhoan();
                addUserControl(tk);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền quản lý tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            hideMenu();   
        }

        private void btn_shoeBrand_Click(object sender, EventArgs e)
        {
            //....
            HieuGiay hg = new HieuGiay();
            addUserControl(hg);    

            hideMenu();  
        }

        private void btn_shoe_Click(object sender, EventArgs e)
        {
            //....
            Giay g = new Giay();
            addUserControl(g);

            hideMenu();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            //......
            HoaDon hd = new HoaDon(StaffName);
            addUserControl(hd);

            hideMenu();
        }

        private void HandleLogout()
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất chứ?",
                "Xác nhận đăng xuất", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
        }

        private void btn_veChungToi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhóm 15 \nĐoàn Cao Cường - 22115053122105\nTrần Huỳnh Vũ - 22115053122151\nLê Ngọc Hải - 22115053122112", "Về chúng tôi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            HandleLogout();
        }

        private void btn_SQL_XML_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                cnn.ConvertSQLtoXML();
                MessageBox.Show("Chuyển đổi dữ liệu từ SQL sang XML thành công!", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btn_XML_SQL_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                cnn.ConvertXMLtoSQL();
                MessageBox.Show("Chuyển đổi dữ liệu từ XML sang SQL thành công!", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}