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
            // 1. Kiểm tra xem khung giới thiệu đã mở chưa (để tránh mở nhiều lần)
            Control existingPanel = this.Controls["pnlGioiThieu_Overlay"];
            if (existingPanel != null)
            {
                existingPanel.BringToFront();
                return;
            }

            // 2. Tạo Panel nền (Overlay) để làm tối giao diện phía sau (giả lập Dialog)
            Panel pnlOverlay = new Panel();
            pnlOverlay.Name = "pnlGioiThieu_Overlay";
            pnlOverlay.Size = new Size(500, 320);
            // Căn giữa màn hình
            pnlOverlay.Location = new Point((this.ClientSize.Width - pnlOverlay.Width) / 2, (this.ClientSize.Height - pnlOverlay.Height) / 2);
            pnlOverlay.BackColor = Color.White;
            // Tạo viền và bóng đổ đơn giản bằng cách lồng panel (nếu muốn cầu kỳ hơn), 
            // ở đây dùng BorderStyle đơn giản cho gọn code.
            pnlOverlay.BorderStyle = BorderStyle.FixedSingle;
            pnlOverlay.Anchor = AnchorStyles.None; // Giữ vị trí khi phóng to thu nhỏ

            // 3. Tạo Header (Tiêu đề xanh)
            Panel pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 50;
            pnlHeader.BackColor = Color.MidnightBlue;

            Label lblTitle = new Label();
            lblTitle.Text = "VỀ CHÚNG TÔI";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitle.AutoSize = false;
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Padding = new Padding(20, 0, 0, 0);

            // Nút đóng (X)
            Button btnClose = new Button();
            btnClose.Text = "X";
            btnClose.Dock = DockStyle.Right;
            btnClose.Width = 50;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.ForeColor = Color.White;
            btnClose.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnClose.Click += (s, args) => { this.Controls.Remove(pnlOverlay); pnlOverlay.Dispose(); };

            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnClose);

            // 4. Nội dung (Thông tin nhóm)
            Label lblContent = new Label();
            lblContent.Dock = DockStyle.Fill;
            // Sử dụng HTML-like formatting hoặc xuống dòng thủ công
            lblContent.Text = "NHÓM 1\n\n" +
                              "Lê Hoàng Quách Tỉnh - 23115053122145\n" +
                              "Phan Văn Khánh - 23115053122114\n" +
                              "Nguyễn Nữ Khánh Ngọc - 23115053122124";
            lblContent.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblContent.TextAlign = ContentAlignment.MiddleCenter;
            lblContent.ForeColor = Color.DimGray;

            // 5. Nút OK ở dưới cùng
            Button btnOK = new Button();
            btnOK.Text = "Đóng";
            btnOK.Size = new Size(100, 40);
            // Căn giữa nút OK
            btnOK.Location = new Point((pnlOverlay.Width - btnOK.Width) / 2, pnlOverlay.Height - 60);
            btnOK.BackColor = Color.ForestGreen;
            btnOK.ForeColor = Color.White;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnOK.Click += (s, args) => { this.Controls.Remove(pnlOverlay); pnlOverlay.Dispose(); };

            // 6. Thêm các control vào panel nền
            pnlOverlay.Controls.Add(btnOK);
            pnlOverlay.Controls.Add(lblContent); // Add Content sau để nó nằm dưới Header
            pnlOverlay.Controls.Add(pnlHeader);

            // 7. Thêm Panel vào Form chính và đưa lên trên cùng
            this.Controls.Add(pnlOverlay);
            pnlOverlay.BringToFront();
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