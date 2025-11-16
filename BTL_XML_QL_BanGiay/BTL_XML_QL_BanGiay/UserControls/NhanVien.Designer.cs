namespace BTL_XML_QL_BanGiay.UserControls
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.txtField_timKiem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtField_hoTen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_hoTen = new System.Windows.Forms.Label();
            this.txtField_maNhanVien = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_maNhanVien = new System.Windows.Forms.Label();
            this.lbl_Top = new System.Windows.Forms.Label();
            this.txtField_diaChi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_diaChi = new System.Windows.Forms.Label();
            this.txtField_soDienThoai = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_soDienThoai = new System.Windows.Forms.Label();
            this.txtField_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtField_timKiem
            // 
            this.txtField_timKiem.Depth = 0;
            this.txtField_timKiem.Hint = "Tìm kiếm theo mã nhân viên";
            this.txtField_timKiem.Location = new System.Drawing.Point(252, 66);
            this.txtField_timKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_timKiem.Name = "txtField_timKiem";
            this.txtField_timKiem.PasswordChar = '\0';
            this.txtField_timKiem.SelectedText = "";
            this.txtField_timKiem.SelectionLength = 0;
            this.txtField_timKiem.SelectionStart = 0;
            this.txtField_timKiem.Size = new System.Drawing.Size(240, 28);
            this.txtField_timKiem.TabIndex = 40;
            this.txtField_timKiem.UseSystemPasswordChar = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(457, 264);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(60, 40);
            this.btn_xoa.TabIndex = 39;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.Location = new System.Drawing.Point(299, 264);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(60, 40);
            this.btn_sua.TabIndex = 38;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(146, 264);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(60, 40);
            this.btn_them.TabIndex = 37;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 232);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtField_hoTen
            // 
            this.txtField_hoTen.Depth = 0;
            this.txtField_hoTen.Hint = "Họ tên";
            this.txtField_hoTen.Location = new System.Drawing.Point(165, 171);
            this.txtField_hoTen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_hoTen.Name = "txtField_hoTen";
            this.txtField_hoTen.PasswordChar = '\0';
            this.txtField_hoTen.SelectedText = "";
            this.txtField_hoTen.SelectionLength = 0;
            this.txtField_hoTen.SelectionStart = 0;
            this.txtField_hoTen.Size = new System.Drawing.Size(225, 28);
            this.txtField_hoTen.TabIndex = 32;
            this.txtField_hoTen.UseSystemPasswordChar = false;
            // 
            // lbl_hoTen
            // 
            this.lbl_hoTen.AutoSize = true;
            this.lbl_hoTen.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_hoTen.Location = new System.Drawing.Point(15, 171);
            this.lbl_hoTen.Name = "lbl_hoTen";
            this.lbl_hoTen.Size = new System.Drawing.Size(69, 24);
            this.lbl_hoTen.TabIndex = 31;
            this.lbl_hoTen.Text = "Họ tên";
            // 
            // txtField_maNhanVien
            // 
            this.txtField_maNhanVien.Depth = 0;
            this.txtField_maNhanVien.Hint = "Mã nhân viên";
            this.txtField_maNhanVien.Location = new System.Drawing.Point(165, 124);
            this.txtField_maNhanVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_maNhanVien.Name = "txtField_maNhanVien";
            this.txtField_maNhanVien.PasswordChar = '\0';
            this.txtField_maNhanVien.SelectedText = "";
            this.txtField_maNhanVien.SelectionLength = 0;
            this.txtField_maNhanVien.SelectionStart = 0;
            this.txtField_maNhanVien.Size = new System.Drawing.Size(225, 28);
            this.txtField_maNhanVien.TabIndex = 30;
            this.txtField_maNhanVien.UseSystemPasswordChar = false;
            // 
            // lbl_maNhanVien
            // 
            this.lbl_maNhanVien.AutoSize = true;
            this.lbl_maNhanVien.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_maNhanVien.Location = new System.Drawing.Point(15, 124);
            this.lbl_maNhanVien.Name = "lbl_maNhanVien";
            this.lbl_maNhanVien.Size = new System.Drawing.Size(131, 24);
            this.lbl_maNhanVien.TabIndex = 29;
            this.lbl_maNhanVien.Text = "Mã nhân viên";
            // 
            // lbl_Top
            // 
            this.lbl_Top.AutoSize = true;
            this.lbl_Top.Font = new System.Drawing.Font("Roboto Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Top.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(252)))));
            this.lbl_Top.Location = new System.Drawing.Point(285, 11);
            this.lbl_Top.Name = "lbl_Top";
            this.lbl_Top.Size = new System.Drawing.Size(142, 34);
            this.lbl_Top.TabIndex = 28;
            this.lbl_Top.Text = "Nhân viên";
            // 
            // txtField_diaChi
            // 
            this.txtField_diaChi.Depth = 0;
            this.txtField_diaChi.Hint = "Địa chỉ";
            this.txtField_diaChi.Location = new System.Drawing.Point(491, 122);
            this.txtField_diaChi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_diaChi.Name = "txtField_diaChi";
            this.txtField_diaChi.PasswordChar = '\0';
            this.txtField_diaChi.SelectedText = "";
            this.txtField_diaChi.SelectionLength = 0;
            this.txtField_diaChi.SelectionStart = 0;
            this.txtField_diaChi.Size = new System.Drawing.Size(225, 28);
            this.txtField_diaChi.TabIndex = 43;
            this.txtField_diaChi.UseSystemPasswordChar = false;
            // 
            // lbl_diaChi
            // 
            this.lbl_diaChi.AutoSize = true;
            this.lbl_diaChi.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_diaChi.Location = new System.Drawing.Point(408, 124);
            this.lbl_diaChi.Name = "lbl_diaChi";
            this.lbl_diaChi.Size = new System.Drawing.Size(72, 24);
            this.lbl_diaChi.TabIndex = 42;
            this.lbl_diaChi.Text = "Địa chỉ";
            // 
            // txtField_soDienThoai
            // 
            this.txtField_soDienThoai.Depth = 0;
            this.txtField_soDienThoai.Hint = "Số điện thoại";
            this.txtField_soDienThoai.Location = new System.Drawing.Point(165, 221);
            this.txtField_soDienThoai.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_soDienThoai.Name = "txtField_soDienThoai";
            this.txtField_soDienThoai.PasswordChar = '\0';
            this.txtField_soDienThoai.SelectedText = "";
            this.txtField_soDienThoai.SelectionLength = 0;
            this.txtField_soDienThoai.SelectionStart = 0;
            this.txtField_soDienThoai.Size = new System.Drawing.Size(225, 28);
            this.txtField_soDienThoai.TabIndex = 45;
            this.txtField_soDienThoai.UseSystemPasswordChar = false;
            // 
            // lbl_soDienThoai
            // 
            this.lbl_soDienThoai.AutoSize = true;
            this.lbl_soDienThoai.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_soDienThoai.Location = new System.Drawing.Point(15, 221);
            this.lbl_soDienThoai.Name = "lbl_soDienThoai";
            this.lbl_soDienThoai.Size = new System.Drawing.Size(131, 24);
            this.lbl_soDienThoai.TabIndex = 44;
            this.lbl_soDienThoai.Text = "Số điện thoại";
            // 
            // txtField_email
            // 
            this.txtField_email.Depth = 0;
            this.txtField_email.Hint = "Email";
            this.txtField_email.Location = new System.Drawing.Point(491, 171);
            this.txtField_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_email.Name = "txtField_email";
            this.txtField_email.PasswordChar = '\0';
            this.txtField_email.SelectedText = "";
            this.txtField_email.SelectionLength = 0;
            this.txtField_email.SelectionStart = 0;
            this.txtField_email.Size = new System.Drawing.Size(225, 28);
            this.txtField_email.TabIndex = 47;
            this.txtField_email.UseSystemPasswordChar = false;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_email.Location = new System.Drawing.Point(408, 171);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(61, 24);
            this.lbl_email.TabIndex = 46;
            this.lbl_email.Text = "Email";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtField_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txtField_soDienThoai);
            this.Controls.Add(this.lbl_soDienThoai);
            this.Controls.Add(this.txtField_diaChi);
            this.Controls.Add(this.lbl_diaChi);
            this.Controls.Add(this.txtField_timKiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtField_hoTen);
            this.Controls.Add(this.lbl_hoTen);
            this.Controls.Add(this.txtField_maNhanVien);
            this.Controls.Add(this.lbl_maNhanVien);
            this.Controls.Add(this.lbl_Top);
            this.Name = "NhanVien";
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_hoTen;
        private System.Windows.Forms.Label lbl_hoTen;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_maNhanVien;
        private System.Windows.Forms.Label lbl_maNhanVien;
        private System.Windows.Forms.Label lbl_Top;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_diaChi;
        private System.Windows.Forms.Label lbl_diaChi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_soDienThoai;
        private System.Windows.Forms.Label lbl_soDienThoai;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_email;
        private System.Windows.Forms.Label lbl_email;
    }
}
