namespace BTL_XML_QL_BanGiay.UserControls
{
    partial class ThemHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlLeft = new System.Windows.Forms.Panel();
            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpThongTinChung = new System.Windows.Forms.GroupBox();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();

            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpChonHang = new System.Windows.Forms.GroupBox();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemGioHang = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cboChonGiay = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();

            this.pnlCenter = new System.Windows.Forms.Panel();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();

            this.pnlLeft.SuspendLayout();
            this.grpKhachHang.SuspendLayout();
            this.grpThongTinChung.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.grpChonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1000, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LẬP HÓA ĐƠN BÁN HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlLeft (Thông tin hóa đơn)
            // 
            this.pnlLeft.Controls.Add(this.grpKhachHang);
            this.pnlLeft.Controls.Add(this.grpThongTinChung);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 40);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLeft.Size = new System.Drawing.Size(300, 660);
            this.pnlLeft.TabIndex = 1;

            // grpThongTinChung
            this.grpThongTinChung.Controls.Add(this.lblNgayBan);
            this.grpThongTinChung.Controls.Add(this.label5);
            this.grpThongTinChung.Controls.Add(this.lblNhanVien);
            this.grpThongTinChung.Controls.Add(this.label1);
            this.grpThongTinChung.Controls.Add(this.lblMaHD);
            this.grpThongTinChung.Controls.Add(this.label4);
            this.grpThongTinChung.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTinChung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTinChung.Location = new System.Drawing.Point(10, 10);
            this.grpThongTinChung.Name = "grpThongTinChung";
            this.grpThongTinChung.Size = new System.Drawing.Size(280, 150);
            this.grpThongTinChung.TabIndex = 0;
            this.grpThongTinChung.TabStop = false;
            this.grpThongTinChung.Text = "Thông tin chung";

            // Labels Info
            this.label4.Text = "Mã HĐ:";
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.AutoSize = true;
            this.lblMaHD.Text = "AUTO_GEN";
            this.lblMaHD.ForeColor = System.Drawing.Color.Red;
            this.lblMaHD.Location = new System.Drawing.Point(100, 30);
            this.lblMaHD.AutoSize = true;

            this.label1.Text = "Nhân viên:";
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.AutoSize = true;
            this.lblNhanVien.Text = "---";
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNhanVien.Location = new System.Drawing.Point(100, 60);
            this.lblNhanVien.AutoSize = true;

            this.label5.Text = "Ngày bán:";
            this.label5.Location = new System.Drawing.Point(15, 90);
            this.label5.AutoSize = true;
            this.lblNgayBan.Text = "dd/MM/yyyy";
            this.lblNgayBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayBan.Location = new System.Drawing.Point(100, 90);
            this.lblNgayBan.AutoSize = true;

            // grpKhachHang
            this.grpKhachHang.Controls.Add(this.txtSDT);
            this.grpKhachHang.Controls.Add(this.label3);
            this.grpKhachHang.Controls.Add(this.txtTenKhach);
            this.grpKhachHang.Controls.Add(this.label2);
            this.grpKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpKhachHang.Location = new System.Drawing.Point(10, 170);
            this.grpKhachHang.Name = "grpKhachHang";
            this.grpKhachHang.Size = new System.Drawing.Size(280, 150);
            this.grpKhachHang.TabIndex = 1;
            this.grpKhachHang.TabStop = false;
            this.grpKhachHang.Text = "Khách hàng";

            this.label2.Text = "Tên khách:";
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.AutoSize = true;
            this.txtTenKhach.Location = new System.Drawing.Point(15, 60);
            this.txtTenKhach.Size = new System.Drawing.Size(250, 30);
            this.txtTenKhach.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.label3.Text = "Số điện thoại:";
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.AutoSize = true;
            this.txtSDT.Location = new System.Drawing.Point(15, 120);
            this.txtSDT.Size = new System.Drawing.Size(250, 30);
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // pnlRight (Chọn hàng)
            // 
            this.pnlRight.Controls.Add(this.grpChonHang);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRight.Location = new System.Drawing.Point(300, 40);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(10);
            this.pnlRight.Size = new System.Drawing.Size(700, 140);
            this.pnlRight.TabIndex = 2;

            // grpChonHang
            this.grpChonHang.Controls.Add(this.btnThemGioHang);
            this.grpChonHang.Controls.Add(this.numSoLuong);
            this.grpChonHang.Controls.Add(this.label7);
            this.grpChonHang.Controls.Add(this.lblTonKho);
            this.grpChonHang.Controls.Add(this.lblDonGia);
            this.grpChonHang.Controls.Add(this.label9);
            this.grpChonHang.Controls.Add(this.label8);
            this.grpChonHang.Controls.Add(this.cboChonGiay);
            this.grpChonHang.Controls.Add(this.label6);
            this.grpChonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChonHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpChonHang.Location = new System.Drawing.Point(10, 10);
            this.grpChonHang.Name = "grpChonHang";
            this.grpChonHang.Size = new System.Drawing.Size(680, 120);
            this.grpChonHang.TabIndex = 0;
            this.grpChonHang.TabStop = false;
            this.grpChonHang.Text = "Chọn sản phẩm";

            this.label6.Text = "Sản phẩm:";
            this.label6.Location = new System.Drawing.Point(20, 30);
            this.label6.AutoSize = true;
            this.cboChonGiay.Location = new System.Drawing.Point(20, 55);
            this.cboChonGiay.Size = new System.Drawing.Size(250, 30);
            this.cboChonGiay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.label8.Text = "Đơn giá:";
            this.label8.Location = new System.Drawing.Point(290, 30);
            this.label8.AutoSize = true;
            this.lblDonGia.Text = "0";
            this.lblDonGia.ForeColor = System.Drawing.Color.Blue;
            this.lblDonGia.Location = new System.Drawing.Point(290, 60);
            this.lblDonGia.AutoSize = true;

            this.label9.Text = "Tồn kho:";
            this.label9.Location = new System.Drawing.Point(400, 30);
            this.label9.AutoSize = true;
            this.lblTonKho.Text = "0";
            this.lblTonKho.Location = new System.Drawing.Point(400, 60);
            this.lblTonKho.AutoSize = true;

            this.label7.Text = "Số lượng:";
            this.label7.Location = new System.Drawing.Point(480, 30);
            this.label7.AutoSize = true;
            this.numSoLuong.Location = new System.Drawing.Point(480, 55);
            this.numSoLuong.Size = new System.Drawing.Size(70, 30);
            this.numSoLuong.Minimum = 1;
            this.numSoLuong.Maximum = 1000;

            this.btnThemGioHang.Text = "Thêm";
            this.btnThemGioHang.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThemGioHang.ForeColor = System.Drawing.Color.White;
            this.btnThemGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemGioHang.Location = new System.Drawing.Point(570, 50);
            this.btnThemGioHang.Size = new System.Drawing.Size(90, 35);

            // 
            // pnlBottom (Tổng tiền & Nút)
            // 
            this.pnlBottom.Controls.Add(this.btnHuy);
            this.pnlBottom.Controls.Add(this.btnThanhToan);
            this.pnlBottom.Controls.Add(this.lblTongTien);
            this.pnlBottom.Controls.Add(this.label10);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(300, 600);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(700, 100);
            this.pnlBottom.TabIndex = 4;
            this.pnlBottom.BackColor = System.Drawing.Color.WhiteSmoke;

            this.label10.Text = "TỔNG THANH TOÁN:";
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(20, 35);
            this.label10.AutoSize = true;

            this.lblTongTien.Text = "0 VNĐ";
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(220, 30);
            this.lblTongTien.AutoSize = true;

            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Location = new System.Drawing.Point(430, 25);
            this.btnThanhToan.Size = new System.Drawing.Size(140, 50);

            this.btnHuy.Text = "HỦY";
            this.btnHuy.BackColor = System.Drawing.Color.Gray;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Location = new System.Drawing.Point(590, 25);
            this.btnHuy.Size = new System.Drawing.Size(90, 50);

            // 
            // pnlCenter (Grid)
            // 
            this.pnlCenter.Controls.Add(this.dgvGioHang);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(300, 180);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCenter.Size = new System.Drawing.Size(700, 420);
            this.pnlCenter.TabIndex = 3;

            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Header Style
            headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvGioHang.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvGioHang.EnableHeadersVisualStyles = false;

            // 
            // ThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.lblTitle);
            this.Name = "ThemHoaDon";
            this.Size = new System.Drawing.Size(1000, 700);

            this.pnlLeft.ResumeLayout(false);
            this.grpKhachHang.ResumeLayout(false);
            this.grpKhachHang.PerformLayout();
            this.grpThongTinChung.ResumeLayout(false);
            this.grpThongTinChung.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.grpChonHang.ResumeLayout(false);
            this.grpChonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.GroupBox grpThongTinChung;
        private System.Windows.Forms.GroupBox grpKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.GroupBox grpChonHang;
        private System.Windows.Forms.ComboBox cboChonGiay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTonKho;
        private System.Windows.Forms.Button btnThemGioHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuy;
    }
}