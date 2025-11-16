namespace BTL_XML_QL_BanGiay.UserControls
{
    partial class Giay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giay));
            this.txtField_timKiem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_tenGiay = new System.Windows.Forms.Label();
            this.lbl_maHieuGiay = new System.Windows.Forms.Label();
            this.txtField_maGiay = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_maGiay = new System.Windows.Forms.Label();
            this.lbl_Top = new System.Windows.Forms.Label();
            this.txtField_tenGiay = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtField_size = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_size = new System.Windows.Forms.Label();
            this.txtField_soLuong = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_soLuong = new System.Windows.Forms.Label();
            this.txtField_mau = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_mau = new System.Windows.Forms.Label();
            this.txtField_donGia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_donGia = new System.Windows.Forms.Label();
            this.cbbx_maHieuGiay = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtField_timKiem
            // 
            this.txtField_timKiem.Depth = 0;
            this.txtField_timKiem.Hint = "Tìm kiếm theo mã giày";
            this.txtField_timKiem.Location = new System.Drawing.Point(244, 66);
            this.txtField_timKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtField_timKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_timKiem.Name = "txtField_timKiem";
            this.txtField_timKiem.PasswordChar = '\0';
            this.txtField_timKiem.SelectedText = "";
            this.txtField_timKiem.SelectionLength = 0;
            this.txtField_timKiem.SelectionStart = 0;
            this.txtField_timKiem.Size = new System.Drawing.Size(220, 28);
            this.txtField_timKiem.TabIndex = 40;
            this.txtField_timKiem.UseSystemPasswordChar = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(452, 265);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(60, 39);
            this.btn_xoa.TabIndex = 39;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.Location = new System.Drawing.Point(293, 265);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(60, 39);
            this.btn_sua.TabIndex = 38;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(141, 265);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(60, 39);
            this.btn_them.TabIndex = 37;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 311);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 231);
            this.dataGridView1.TabIndex = 36;
            // 
            // lbl_tenGiay
            // 
            this.lbl_tenGiay.AutoSize = true;
            this.lbl_tenGiay.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_tenGiay.Location = new System.Drawing.Point(15, 224);
            this.lbl_tenGiay.Name = "lbl_tenGiay";
            this.lbl_tenGiay.Size = new System.Drawing.Size(88, 24);
            this.lbl_tenGiay.TabIndex = 33;
            this.lbl_tenGiay.Text = "Tên giày";
            // 
            // lbl_maHieuGiay
            // 
            this.lbl_maHieuGiay.AutoSize = true;
            this.lbl_maHieuGiay.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_maHieuGiay.Location = new System.Drawing.Point(15, 175);
            this.lbl_maHieuGiay.Name = "lbl_maHieuGiay";
            this.lbl_maHieuGiay.Size = new System.Drawing.Size(127, 24);
            this.lbl_maHieuGiay.TabIndex = 31;
            this.lbl_maHieuGiay.Text = "Mã hiệu giày";
            // 
            // txtField_maGiay
            // 
            this.txtField_maGiay.Depth = 0;
            this.txtField_maGiay.Hint = "Mã giày";
            this.txtField_maGiay.Location = new System.Drawing.Point(152, 124);
            this.txtField_maGiay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtField_maGiay.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_maGiay.Name = "txtField_maGiay";
            this.txtField_maGiay.PasswordChar = '\0';
            this.txtField_maGiay.SelectedText = "";
            this.txtField_maGiay.SelectionLength = 0;
            this.txtField_maGiay.SelectionStart = 0;
            this.txtField_maGiay.Size = new System.Drawing.Size(225, 28);
            this.txtField_maGiay.TabIndex = 30;
            this.txtField_maGiay.UseSystemPasswordChar = false;
            // 
            // lbl_maGiay
            // 
            this.lbl_maGiay.AutoSize = true;
            this.lbl_maGiay.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_maGiay.Location = new System.Drawing.Point(15, 124);
            this.lbl_maGiay.Name = "lbl_maGiay";
            this.lbl_maGiay.Size = new System.Drawing.Size(83, 24);
            this.lbl_maGiay.TabIndex = 29;
            this.lbl_maGiay.Text = "Mã giày";
            // 
            // lbl_Top
            // 
            this.lbl_Top.AutoSize = true;
            this.lbl_Top.Font = new System.Drawing.Font("Roboto Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Top.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(252)))));
            this.lbl_Top.Location = new System.Drawing.Point(316, 10);
            this.lbl_Top.Name = "lbl_Top";
            this.lbl_Top.Size = new System.Drawing.Size(72, 34);
            this.lbl_Top.TabIndex = 28;
            this.lbl_Top.Text = "Giày";
            // 
            // txtField_tenGiay
            // 
            this.txtField_tenGiay.Depth = 0;
            this.txtField_tenGiay.Hint = "Tên giày";
            this.txtField_tenGiay.Location = new System.Drawing.Point(152, 224);
            this.txtField_tenGiay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtField_tenGiay.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_tenGiay.Name = "txtField_tenGiay";
            this.txtField_tenGiay.PasswordChar = '\0';
            this.txtField_tenGiay.SelectedText = "";
            this.txtField_tenGiay.SelectionLength = 0;
            this.txtField_tenGiay.SelectionStart = 0;
            this.txtField_tenGiay.Size = new System.Drawing.Size(225, 28);
            this.txtField_tenGiay.TabIndex = 42;
            this.txtField_tenGiay.UseSystemPasswordChar = false;
            // 
            // txtField_size
            // 
            this.txtField_size.Depth = 0;
            this.txtField_size.Hint = "Size";
            this.txtField_size.Location = new System.Drawing.Point(467, 124);
            this.txtField_size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtField_size.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_size.Name = "txtField_size";
            this.txtField_size.PasswordChar = '\0';
            this.txtField_size.SelectedText = "";
            this.txtField_size.SelectionLength = 0;
            this.txtField_size.SelectionStart = 0;
            this.txtField_size.Size = new System.Drawing.Size(79, 28);
            this.txtField_size.TabIndex = 44;
            this.txtField_size.UseSystemPasswordChar = false;
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_size.Location = new System.Drawing.Point(408, 124);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(50, 24);
            this.lbl_size.TabIndex = 43;
            this.lbl_size.Text = "Size";
            // 
            // txtField_soLuong
            // 
            this.txtField_soLuong.Depth = 0;
            this.txtField_soLuong.Hint = "Số lượng";
            this.txtField_soLuong.Location = new System.Drawing.Point(640, 124);
            this.txtField_soLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtField_soLuong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_soLuong.Name = "txtField_soLuong";
            this.txtField_soLuong.PasswordChar = '\0';
            this.txtField_soLuong.SelectedText = "";
            this.txtField_soLuong.SelectionLength = 0;
            this.txtField_soLuong.SelectionStart = 0;
            this.txtField_soLuong.Size = new System.Drawing.Size(81, 28);
            this.txtField_soLuong.TabIndex = 46;
            this.txtField_soLuong.UseSystemPasswordChar = false;
            // 
            // lbl_soLuong
            // 
            this.lbl_soLuong.AutoSize = true;
            this.lbl_soLuong.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_soLuong.Location = new System.Drawing.Point(540, 124);
            this.lbl_soLuong.Name = "lbl_soLuong";
            this.lbl_soLuong.Size = new System.Drawing.Size(92, 24);
            this.lbl_soLuong.TabIndex = 45;
            this.lbl_soLuong.Text = "Số lượng";
            // 
            // txtField_mau
            // 
            this.txtField_mau.Depth = 0;
            this.txtField_mau.Hint = "Màu";
            this.txtField_mau.Location = new System.Drawing.Point(467, 175);
            this.txtField_mau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtField_mau.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_mau.Name = "txtField_mau";
            this.txtField_mau.PasswordChar = '\0';
            this.txtField_mau.SelectedText = "";
            this.txtField_mau.SelectionLength = 0;
            this.txtField_mau.SelectionStart = 0;
            this.txtField_mau.Size = new System.Drawing.Size(251, 28);
            this.txtField_mau.TabIndex = 48;
            this.txtField_mau.UseSystemPasswordChar = false;
            // 
            // lbl_mau
            // 
            this.lbl_mau.AutoSize = true;
            this.lbl_mau.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_mau.Location = new System.Drawing.Point(408, 175);
            this.lbl_mau.Name = "lbl_mau";
            this.lbl_mau.Size = new System.Drawing.Size(50, 24);
            this.lbl_mau.TabIndex = 47;
            this.lbl_mau.Text = "Màu";
            // 
            // txtField_donGia
            // 
            this.txtField_donGia.Depth = 0;
            this.txtField_donGia.Hint = "Đơn giá";
            this.txtField_donGia.Location = new System.Drawing.Point(493, 220);
            this.txtField_donGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtField_donGia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_donGia.Name = "txtField_donGia";
            this.txtField_donGia.PasswordChar = '\0';
            this.txtField_donGia.SelectedText = "";
            this.txtField_donGia.SelectionLength = 0;
            this.txtField_donGia.SelectionStart = 0;
            this.txtField_donGia.Size = new System.Drawing.Size(223, 28);
            this.txtField_donGia.TabIndex = 50;
            this.txtField_donGia.UseSystemPasswordChar = false;
            // 
            // lbl_donGia
            // 
            this.lbl_donGia.AutoSize = true;
            this.lbl_donGia.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_donGia.Location = new System.Drawing.Point(408, 224);
            this.lbl_donGia.Name = "lbl_donGia";
            this.lbl_donGia.Size = new System.Drawing.Size(80, 24);
            this.lbl_donGia.TabIndex = 49;
            this.lbl_donGia.Text = "Đơn giá";
            // 
            // cbbx_maHieuGiay
            // 
            this.cbbx_maHieuGiay.FormattingEnabled = true;
            this.cbbx_maHieuGiay.Location = new System.Drawing.Point(152, 175);
            this.cbbx_maHieuGiay.Name = "cbbx_maHieuGiay";
            this.cbbx_maHieuGiay.Size = new System.Drawing.Size(225, 24);
            this.cbbx_maHieuGiay.TabIndex = 51;
            // 
            // Giay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbx_maHieuGiay);
            this.Controls.Add(this.txtField_donGia);
            this.Controls.Add(this.lbl_donGia);
            this.Controls.Add(this.txtField_mau);
            this.Controls.Add(this.lbl_mau);
            this.Controls.Add(this.txtField_soLuong);
            this.Controls.Add(this.lbl_soLuong);
            this.Controls.Add(this.txtField_size);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.txtField_tenGiay);
            this.Controls.Add(this.txtField_timKiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_tenGiay);
            this.Controls.Add(this.lbl_maHieuGiay);
            this.Controls.Add(this.txtField_maGiay);
            this.Controls.Add(this.lbl_maGiay);
            this.Controls.Add(this.lbl_Top);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Giay";
            this.Size = new System.Drawing.Size(740, 553);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_timKiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_tenGiay;
        private System.Windows.Forms.Label lbl_maHieuGiay;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_maGiay;
        private System.Windows.Forms.Label lbl_maGiay;
        private System.Windows.Forms.Label lbl_Top;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_tenGiay;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_size;
        private System.Windows.Forms.Label lbl_size;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_soLuong;
        private System.Windows.Forms.Label lbl_soLuong;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_mau;
        private System.Windows.Forms.Label lbl_mau;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_donGia;
        private System.Windows.Forms.Label lbl_donGia;
        private System.Windows.Forms.ComboBox cbbx_maHieuGiay;
    }
}
