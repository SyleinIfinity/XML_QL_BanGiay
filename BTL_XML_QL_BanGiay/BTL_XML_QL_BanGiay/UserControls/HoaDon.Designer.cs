namespace BTL_XML_QL_BanGiay.UserControls
{
    partial class HoaDon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();

            // Phần giấy in
            this.pnlInvoicePaper = new System.Windows.Forms.Panel();
            this.lblValTongTien = new System.Windows.Forms.Label();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.lblValNhanVien = new System.Windows.Forms.Label();
            this.labelNV = new System.Windows.Forms.Label();
            this.lblValNgay = new System.Windows.Forms.Label();
            this.labelNgay = new System.Windows.Forms.Label();
            this.lblValMaHD = new System.Windows.Forms.Label();
            this.labelMa = new System.Windows.Forms.Label();
            this.labelTitleHD = new System.Windows.Forms.Label();
            this.labelShopAddr = new System.Windows.Forms.Label();
            this.labelShopName = new System.Windows.Forms.Label();
            this.labelFooter = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.pnlTools.SuspendLayout();
            this.pnlInvoicePaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();

            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1 (Danh sách)
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.grpDanhSach);
            this.splitContainer1.Panel1.Controls.Add(this.pnlTools);
            this.splitContainer1.Panel1.Controls.Add(this.lblListTitle);
            // 
            // splitContainer1.Panel2 (Chi tiết - Giấy in)
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gray; // Màu nền xám
            this.splitContainer1.Panel2.Controls.Add(this.pnlInvoicePaper);
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Size = new System.Drawing.Size(850, 600);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;

            // --- PANEL 1: DANH SÁCH ---

            // lblListTitle
            this.lblListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblListTitle.Location = new System.Drawing.Point(0, 0);
            this.lblListTitle.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.lblListTitle.Size = new System.Drawing.Size(850, 35);
            this.lblListTitle.Text = "LỊCH SỬ GIAO DỊCH";

            // pnlTools
            this.pnlTools.Controls.Add(this.btnThem);
            this.pnlTools.Controls.Add(this.btnIn);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Height = 45;
            this.pnlTools.Location = new System.Drawing.Point(0, 35);

            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(15, 5);
            this.btnThem.Size = new System.Drawing.Size(130, 32);
            this.btnThem.Text = "+ Tạo Hóa Đơn";
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // btnIn
            this.btnIn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Location = new System.Drawing.Point(160, 5); // Đặt cạnh nút thêm
            this.btnIn.Size = new System.Drawing.Size(110, 32);
            this.btnIn.Text = "🖨 In Hóa Đơn";
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // grpDanhSach
            this.grpDanhSach.Controls.Add(this.dgvHoaDon);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Location = new System.Drawing.Point(0, 80);
            this.grpDanhSach.Text = "Danh sách hóa đơn";
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9F);

            // dgvHoaDon
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.RowHeadersVisible = false;

            // --- PANEL 2: TỜ GIẤY IN ---

            // pnlInvoicePaper
            this.pnlInvoicePaper.BackColor = System.Drawing.Color.White;
            this.pnlInvoicePaper.Location = new System.Drawing.Point(145, 20);
            this.pnlInvoicePaper.Size = new System.Drawing.Size(560, 600);
            this.pnlInvoicePaper.Anchor = System.Windows.Forms.AnchorStyles.Top;

            // Header Shop
            this.labelShopName.Text = "SHOP GIÀY THỜI THƯỢNG";
            this.labelShopName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelShopName.Location = new System.Drawing.Point(20, 20);
            this.labelShopName.AutoSize = true;

            this.labelShopAddr.Text = "ĐC: 123 Đường ABC, Hà Nội - SĐT: 0999.888.777";
            this.labelShopAddr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.labelShopAddr.Location = new System.Drawing.Point(20, 45);
            this.labelShopAddr.AutoSize = true;

            this.labelTitleHD.Text = "HÓA ĐƠN BÁN HÀNG";
            this.labelTitleHD.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitleHD.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTitleHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitleHD.Size = new System.Drawing.Size(560, 35);
            this.labelTitleHD.Location = new System.Drawing.Point(0, 70);

            // Info Section
            this.labelMa.Text = "Số HĐ:";
            this.labelMa.Location = new System.Drawing.Point(340, 120);
            this.labelMa.AutoSize = true;

            this.lblValMaHD.Text = "---";
            this.lblValMaHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValMaHD.Location = new System.Drawing.Point(400, 120);
            this.lblValMaHD.AutoSize = true;

            this.labelNgay.Text = "Ngày lập:";
            this.labelNgay.Location = new System.Drawing.Point(340, 145);
            this.labelNgay.AutoSize = true;

            this.lblValNgay.Text = "---";
            this.lblValNgay.Location = new System.Drawing.Point(400, 145);
            this.lblValNgay.AutoSize = true;

            this.labelNV.Text = "Nhân viên:";
            this.labelNV.Location = new System.Drawing.Point(30, 120);
            this.labelNV.AutoSize = true;

            this.lblValNhanVien.Text = "---";
            this.lblValNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValNhanVien.Location = new System.Drawing.Point(110, 120);
            this.lblValNhanVien.AutoSize = true;

            // Grid Chi Tiết
            this.dgvChiTiet.Location = new System.Drawing.Point(25, 180);
            this.dgvChiTiet.Size = new System.Drawing.Size(510, 300);
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTiet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;

            // Style Grid
            headerStyle.BackColor = System.Drawing.Color.White;
            headerStyle.ForeColor = System.Drawing.Color.Black;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.SelectionBackColor = System.Drawing.Color.White;
            headerStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvChiTiet.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvChiTiet.EnableHeadersVisualStyles = false;

            cellStyle.SelectionBackColor = System.Drawing.Color.White;
            cellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvChiTiet.DefaultCellStyle = cellStyle;

            // Total
            this.labelTongTien.Text = "TỔNG THANH TOÁN:";
            this.labelTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTongTien.Location = new System.Drawing.Point(220, 500);
            this.labelTongTien.AutoSize = true;

            this.lblValTongTien.Text = "0 VNĐ";
            this.lblValTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblValTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblValTongTien.Location = new System.Drawing.Point(380, 498);
            this.lblValTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValTongTien.AutoSize = true;

            // Footer Text
            this.labelFooter.Text = "Cảm ơn quý khách và hẹn gặp lại!";
            this.labelFooter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.labelFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFooter.Location = new System.Drawing.Point(0, 560);
            this.labelFooter.Size = new System.Drawing.Size(560, 20);

            // Add controls to Panel Invoice
            this.pnlInvoicePaper.Controls.Add(this.labelShopName);
            this.pnlInvoicePaper.Controls.Add(this.labelShopAddr);
            this.pnlInvoicePaper.Controls.Add(this.labelTitleHD);
            this.pnlInvoicePaper.Controls.Add(this.labelMa);
            this.pnlInvoicePaper.Controls.Add(this.lblValMaHD);
            this.pnlInvoicePaper.Controls.Add(this.labelNgay);
            this.pnlInvoicePaper.Controls.Add(this.lblValNgay);
            this.pnlInvoicePaper.Controls.Add(this.labelNV);
            this.pnlInvoicePaper.Controls.Add(this.lblValNhanVien);
            this.pnlInvoicePaper.Controls.Add(this.dgvChiTiet);
            this.pnlInvoicePaper.Controls.Add(this.labelTongTien);
            this.pnlInvoicePaper.Controls.Add(this.lblValTongTien);
            this.pnlInvoicePaper.Controls.Add(this.labelFooter);

            // 
            // HoaDon
            // 
            this.Controls.Add(this.splitContainer1);
            this.Name = "HoaDon";
            this.Size = new System.Drawing.Size(850, 600);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.pnlTools.ResumeLayout(false);
            this.pnlInvoicePaper.ResumeLayout(false);
            this.pnlInvoicePaper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label lblListTitle;

        private System.Windows.Forms.Panel pnlInvoicePaper;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Label labelShopAddr;
        private System.Windows.Forms.Label labelTitleHD;
        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.Label lblValMaHD;
        private System.Windows.Forms.Label labelNgay;
        private System.Windows.Forms.Label lblValNgay;
        private System.Windows.Forms.Label labelNV;
        private System.Windows.Forms.Label lblValNhanVien;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.Label lblValTongTien;
        private System.Windows.Forms.Label labelFooter;
    }
}