namespace BTL_XML_QL_BanGiay.Forms
{
    partial class TaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoan));
            this.txtField_timKiem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdbtn_chuCuaHang = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbtn_nhanVien = new MaterialSkin.Controls.MaterialRadioButton();
            this.lbl_quyen = new System.Windows.Forms.Label();
            this.txtField_matKhau = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_matKhau = new System.Windows.Forms.Label();
            this.lbl_maNhanVien = new System.Windows.Forms.Label();
            this.lbl_Top = new System.Windows.Forms.Label();
            this.cbbox_maNhanVien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtField_timKiem
            // 
            this.txtField_timKiem.Depth = 0;
            this.txtField_timKiem.Hint = "Tìm kiếm theo mã nhân viên";
            this.txtField_timKiem.Location = new System.Drawing.Point(245, 66);
            this.txtField_timKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtField_timKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_timKiem.Name = "txtField_timKiem";
            this.txtField_timKiem.PasswordChar = '\0';
            this.txtField_timKiem.SelectedText = "";
            this.txtField_timKiem.SelectionLength = 0;
            this.txtField_timKiem.SelectionStart = 0;
            this.txtField_timKiem.Size = new System.Drawing.Size(246, 28);
            this.txtField_timKiem.TabIndex = 26;
            this.txtField_timKiem.UseSystemPasswordChar = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(449, 228);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(60, 39);
            this.btn_xoa.TabIndex = 25;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.Location = new System.Drawing.Point(291, 228);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(60, 39);
            this.btn_sua.TabIndex = 24;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(139, 228);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(60, 39);
            this.btn_them.TabIndex = 23;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 284);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 258);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rdbtn_chuCuaHang
            // 
            this.rdbtn_chuCuaHang.AutoSize = true;
            this.rdbtn_chuCuaHang.Depth = 0;
            this.rdbtn_chuCuaHang.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbtn_chuCuaHang.Location = new System.Drawing.Point(524, 170);
            this.rdbtn_chuCuaHang.Margin = new System.Windows.Forms.Padding(0);
            this.rdbtn_chuCuaHang.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbtn_chuCuaHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbtn_chuCuaHang.Name = "rdbtn_chuCuaHang";
            this.rdbtn_chuCuaHang.Ripple = true;
            this.rdbtn_chuCuaHang.Size = new System.Drawing.Size(135, 30);
            this.rdbtn_chuCuaHang.TabIndex = 21;
            this.rdbtn_chuCuaHang.TabStop = true;
            this.rdbtn_chuCuaHang.Text = "Chủ của hàng";
            this.rdbtn_chuCuaHang.UseVisualStyleBackColor = true;
            // 
            // rdbtn_nhanVien
            // 
            this.rdbtn_nhanVien.AutoSize = true;
            this.rdbtn_nhanVien.Depth = 0;
            this.rdbtn_nhanVien.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbtn_nhanVien.Location = new System.Drawing.Point(524, 124);
            this.rdbtn_nhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.rdbtn_nhanVien.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbtn_nhanVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbtn_nhanVien.Name = "rdbtn_nhanVien";
            this.rdbtn_nhanVien.Ripple = true;
            this.rdbtn_nhanVien.Size = new System.Drawing.Size(107, 30);
            this.rdbtn_nhanVien.TabIndex = 20;
            this.rdbtn_nhanVien.TabStop = true;
            this.rdbtn_nhanVien.Text = "Nhân viên";
            this.rdbtn_nhanVien.UseVisualStyleBackColor = true;
            // 
            // lbl_quyen
            // 
            this.lbl_quyen.AutoSize = true;
            this.lbl_quyen.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_quyen.Location = new System.Drawing.Point(445, 128);
            this.lbl_quyen.Name = "lbl_quyen";
            this.lbl_quyen.Size = new System.Drawing.Size(67, 24);
            this.lbl_quyen.TabIndex = 19;
            this.lbl_quyen.Text = "Quyền";
            // 
            // txtField_matKhau
            // 
            this.txtField_matKhau.Depth = 0;
            this.txtField_matKhau.Hint = "Mật khẩu";
            this.txtField_matKhau.Location = new System.Drawing.Point(165, 178);
            this.txtField_matKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtField_matKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_matKhau.Name = "txtField_matKhau";
            this.txtField_matKhau.PasswordChar = '\0';
            this.txtField_matKhau.SelectedText = "";
            this.txtField_matKhau.SelectionLength = 0;
            this.txtField_matKhau.SelectionStart = 0;
            this.txtField_matKhau.Size = new System.Drawing.Size(225, 28);
            this.txtField_matKhau.TabIndex = 18;
            this.txtField_matKhau.UseSystemPasswordChar = false;
            // 
            // lbl_matKhau
            // 
            this.lbl_matKhau.AutoSize = true;
            this.lbl_matKhau.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_matKhau.Location = new System.Drawing.Point(15, 178);
            this.lbl_matKhau.Name = "lbl_matKhau";
            this.lbl_matKhau.Size = new System.Drawing.Size(95, 24);
            this.lbl_matKhau.TabIndex = 17;
            this.lbl_matKhau.Text = "Mật khẩu";
            // 
            // lbl_maNhanVien
            // 
            this.lbl_maNhanVien.AutoSize = true;
            this.lbl_maNhanVien.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_maNhanVien.Location = new System.Drawing.Point(15, 124);
            this.lbl_maNhanVien.Name = "lbl_maNhanVien";
            this.lbl_maNhanVien.Size = new System.Drawing.Size(131, 24);
            this.lbl_maNhanVien.TabIndex = 15;
            this.lbl_maNhanVien.Text = "Mã nhân viên";
            // 
            // lbl_Top
            // 
            this.lbl_Top.AutoSize = true;
            this.lbl_Top.Font = new System.Drawing.Font("Roboto Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Top.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(252)))));
            this.lbl_Top.Location = new System.Drawing.Point(285, 11);
            this.lbl_Top.Name = "lbl_Top";
            this.lbl_Top.Size = new System.Drawing.Size(139, 34);
            this.lbl_Top.TabIndex = 14;
            this.lbl_Top.Text = "Tài khoản";
            // 
            // cbbox_maNhanVien
            // 
            this.cbbox_maNhanVien.FormattingEnabled = true;
            this.cbbox_maNhanVien.Location = new System.Drawing.Point(165, 124);
            this.cbbox_maNhanVien.Name = "cbbox_maNhanVien";
            this.cbbox_maNhanVien.Size = new System.Drawing.Size(225, 24);
            this.cbbox_maNhanVien.TabIndex = 27;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbox_maNhanVien);
            this.Controls.Add(this.txtField_timKiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdbtn_chuCuaHang);
            this.Controls.Add(this.rdbtn_nhanVien);
            this.Controls.Add(this.lbl_quyen);
            this.Controls.Add(this.txtField_matKhau);
            this.Controls.Add(this.lbl_matKhau);
            this.Controls.Add(this.lbl_maNhanVien);
            this.Controls.Add(this.lbl_Top);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TaiKhoan";
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
        private MaterialSkin.Controls.MaterialRadioButton rdbtn_chuCuaHang;
        private MaterialSkin.Controls.MaterialRadioButton rdbtn_nhanVien;
        private System.Windows.Forms.Label lbl_quyen;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_matKhau;
        private System.Windows.Forms.Label lbl_matKhau;
        private System.Windows.Forms.Label lbl_maNhanVien;
        private System.Windows.Forms.Label lbl_Top;
        private System.Windows.Forms.ComboBox cbbox_maNhanVien;
    }
}
