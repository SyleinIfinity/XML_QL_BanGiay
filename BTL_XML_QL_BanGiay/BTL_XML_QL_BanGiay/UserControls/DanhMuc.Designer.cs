namespace BTL_XML_QL_BanGiay.UserControls
{
    partial class DanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lbl_Top = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtField_timKiem = new System.Windows.Forms.TextBox();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txtField_tenDanhMuc = new System.Windows.Forms.TextBox();
            this.lbl_tenDanhMuc = new System.Windows.Forms.Label();
            this.txtField_maDanhMuc = new System.Windows.Forms.TextBox();
            this.lbl_maDanhMuc = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Controls.Add(this.lbl_Top);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.txtField_timKiem);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(600, 70);
            this.pnlTop.TabIndex = 0;
            // 
            // lbl_Top
            // 
            this.lbl_Top.AutoSize = true;
            this.lbl_Top.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Top.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Top.Location = new System.Drawing.Point(10, 15);
            this.lbl_Top.Name = "lbl_Top";
            this.lbl_Top.Size = new System.Drawing.Size(225, 38);
            this.lbl_Top.TabIndex = 28;
            this.lbl_Top.Text = "QL DANH MỤC";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(300, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txtField_timKiem
            // 
            this.txtField_timKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtField_timKiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtField_timKiem.Location = new System.Drawing.Point(390, 22);
            this.txtField_timKiem.Name = "txtField_timKiem";
            this.txtField_timKiem.Size = new System.Drawing.Size(190, 32);
            this.txtField_timKiem.TabIndex = 40;
            // 
            // grpThongTin
            // 
            this.grpThongTin.BackColor = System.Drawing.Color.White;
            this.grpThongTin.Controls.Add(this.btn_xoa);
            this.grpThongTin.Controls.Add(this.btn_sua);
            this.grpThongTin.Controls.Add(this.btn_them);
            this.grpThongTin.Controls.Add(this.txtField_tenDanhMuc);
            this.grpThongTin.Controls.Add(this.lbl_tenDanhMuc);
            this.grpThongTin.Controls.Add(this.txtField_maDanhMuc);
            this.grpThongTin.Controls.Add(this.lbl_maDanhMuc);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(0, 70);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(600, 150);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin chi tiết";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xoa.BackColor = System.Drawing.Color.Crimson;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(370, 90);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(90, 35);
            this.btn_xoa.TabIndex = 39;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sua.BackColor = System.Drawing.Color.Orange;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(250, 90);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(90, 35);
            this.btn_sua.TabIndex = 38;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_them.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(130, 90);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(90, 35);
            this.btn_them.TabIndex = 37;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txtField_tenDanhMuc
            // 
            this.txtField_tenDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtField_tenDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtField_tenDanhMuc.Location = new System.Drawing.Point(400, 35);
            this.txtField_tenDanhMuc.Name = "txtField_tenDanhMuc";
            this.txtField_tenDanhMuc.Size = new System.Drawing.Size(180, 32);
            this.txtField_tenDanhMuc.TabIndex = 32;
            // 
            // lbl_tenDanhMuc
            // 
            this.lbl_tenDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tenDanhMuc.AutoSize = true;
            this.lbl_tenDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_tenDanhMuc.Location = new System.Drawing.Point(310, 38);
            this.lbl_tenDanhMuc.Name = "lbl_tenDanhMuc";
            this.lbl_tenDanhMuc.Size = new System.Drawing.Size(84, 25);
            this.lbl_tenDanhMuc.TabIndex = 31;
            this.lbl_tenDanhMuc.Text = "Tên DM:";
            // 
            // txtField_maDanhMuc
            // 
            this.txtField_maDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtField_maDanhMuc.Location = new System.Drawing.Point(100, 35);
            this.txtField_maDanhMuc.Name = "txtField_maDanhMuc";
            this.txtField_maDanhMuc.Size = new System.Drawing.Size(180, 32);
            this.txtField_maDanhMuc.TabIndex = 30;
            // 
            // lbl_maDanhMuc
            // 
            this.lbl_maDanhMuc.AutoSize = true;
            this.lbl_maDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_maDanhMuc.Location = new System.Drawing.Point(20, 38);
            this.lbl_maDanhMuc.Name = "lbl_maDanhMuc";
            this.lbl_maDanhMuc.Size = new System.Drawing.Size(78, 25);
            this.lbl_maDanhMuc.TabIndex = 29;
            this.lbl_maDanhMuc.Text = "Mã DM:";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dataGridView1);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 220);
            this.pnlData.Name = "pnlData";
            this.pnlData.Padding = new System.Windows.Forms.Padding(10);
            this.pnlData.Size = new System.Drawing.Size(600, 380);
            this.pnlData.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 40;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(580, 360);
            this.dataGridView1.TabIndex = 36;
            // 
            // DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.pnlTop);
            this.Name = "DanhMuc";
            this.Size = new System.Drawing.Size(600, 600);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lbl_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtField_timKiem;

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtField_maDanhMuc;
        private System.Windows.Forms.Label lbl_maDanhMuc;
        private System.Windows.Forms.TextBox txtField_tenDanhMuc;
        private System.Windows.Forms.Label lbl_tenDanhMuc;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;

        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}