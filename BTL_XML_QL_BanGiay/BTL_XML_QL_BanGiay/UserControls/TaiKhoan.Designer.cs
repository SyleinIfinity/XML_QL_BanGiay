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
            this.txtField_timKiem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdbtn_chuCuaHang = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbtn_nhanVien = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtField_matKhau = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_matKhau = new System.Windows.Forms.Label();
            this.lbl_maNhanVien = new System.Windows.Forms.Label();
            this.lbl_Top = new System.Windows.Forms.Label();
            this.cbbox_maNhanVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtField_timKiem
            // 
            this.txtField_timKiem.Depth = 0;
            this.txtField_timKiem.Hint = "🔍 Tìm kiếm theo mã nhân viên";
            this.txtField_timKiem.Location = new System.Drawing.Point(382, 409);
            this.txtField_timKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtField_timKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_timKiem.Name = "txtField_timKiem";
            this.txtField_timKiem.PasswordChar = '\0';
            this.txtField_timKiem.SelectedText = "";
            this.txtField_timKiem.SelectionLength = 0;
            this.txtField_timKiem.SelectionStart = 0;
            this.txtField_timKiem.Size = new System.Drawing.Size(425, 41);
            this.txtField_timKiem.TabIndex = 26;
            this.txtField_timKiem.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 476);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(990, 403);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rdbtn_chuCuaHang
            // 
            this.rdbtn_chuCuaHang.AutoSize = true;
            this.rdbtn_chuCuaHang.Depth = 0;
            this.rdbtn_chuCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbtn_chuCuaHang.Location = new System.Drawing.Point(53, 104);
            this.rdbtn_chuCuaHang.Margin = new System.Windows.Forms.Padding(0);
            this.rdbtn_chuCuaHang.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbtn_chuCuaHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbtn_chuCuaHang.Name = "rdbtn_chuCuaHang";
            this.rdbtn_chuCuaHang.Ripple = true;
            this.rdbtn_chuCuaHang.Size = new System.Drawing.Size(201, 30);
            this.rdbtn_chuCuaHang.TabIndex = 21;
            this.rdbtn_chuCuaHang.TabStop = true;
            this.rdbtn_chuCuaHang.Text = "Chủ của hàng";
            this.rdbtn_chuCuaHang.UseVisualStyleBackColor = true;
            // 
            // rdbtn_nhanVien
            // 
            this.rdbtn_nhanVien.AutoSize = true;
            this.rdbtn_nhanVien.Depth = 0;
            this.rdbtn_nhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbtn_nhanVien.Location = new System.Drawing.Point(54, 50);
            this.rdbtn_nhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.rdbtn_nhanVien.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbtn_nhanVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbtn_nhanVien.Name = "rdbtn_nhanVien";
            this.rdbtn_nhanVien.Ripple = true;
            this.rdbtn_nhanVien.Size = new System.Drawing.Size(156, 30);
            this.rdbtn_nhanVien.TabIndex = 20;
            this.rdbtn_nhanVien.TabStop = true;
            this.rdbtn_nhanVien.Text = "Nhân viên";
            this.rdbtn_nhanVien.UseVisualStyleBackColor = true;
            // 
            // txtField_matKhau
            // 
            this.txtField_matKhau.Depth = 0;
            this.txtField_matKhau.Hint = "Mật khẩu";
            this.txtField_matKhau.Location = new System.Drawing.Point(248, 278);
            this.txtField_matKhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtField_matKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_matKhau.Name = "txtField_matKhau";
            this.txtField_matKhau.PasswordChar = '\0';
            this.txtField_matKhau.SelectedText = "";
            this.txtField_matKhau.SelectionLength = 0;
            this.txtField_matKhau.SelectionStart = 0;
            this.txtField_matKhau.Size = new System.Drawing.Size(338, 41);
            this.txtField_matKhau.TabIndex = 18;
            this.txtField_matKhau.UseSystemPasswordChar = false;
            // 
            // lbl_matKhau
            // 
            this.lbl_matKhau.AutoSize = true;
            this.lbl_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_matKhau.Location = new System.Drawing.Point(22, 278);
            this.lbl_matKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_matKhau.Name = "lbl_matKhau";
            this.lbl_matKhau.Size = new System.Drawing.Size(157, 37);
            this.lbl_matKhau.TabIndex = 17;
            this.lbl_matKhau.Text = "Mật khẩu";
            // 
            // lbl_maNhanVien
            // 
            this.lbl_maNhanVien.AutoSize = true;
            this.lbl_maNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_maNhanVien.Location = new System.Drawing.Point(22, 194);
            this.lbl_maNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_maNhanVien.Name = "lbl_maNhanVien";
            this.lbl_maNhanVien.Size = new System.Drawing.Size(220, 37);
            this.lbl_maNhanVien.TabIndex = 15;
            this.lbl_maNhanVien.Text = "Mã nhân viên";
            // 
            // lbl_Top
            // 
            this.lbl_Top.AutoSize = true;
            this.lbl_Top.Font = new System.Drawing.Font("Microsoft YaHei Light", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Top.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(252)))));
            this.lbl_Top.Location = new System.Drawing.Point(498, 32);
            this.lbl_Top.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Top.Name = "lbl_Top";
            this.lbl_Top.Size = new System.Drawing.Size(226, 51);
            this.lbl_Top.TabIndex = 14;
            this.lbl_Top.Text = "Tài khoản";
            // 
            // cbbox_maNhanVien
            // 
            this.cbbox_maNhanVien.FormattingEnabled = true;
            this.cbbox_maNhanVien.Location = new System.Drawing.Point(248, 194);
            this.cbbox_maNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbox_maNhanVien.Name = "cbbox_maNhanVien";
            this.cbbox_maNhanVien.Size = new System.Drawing.Size(336, 33);
            this.cbbox_maNhanVien.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Thêm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Xóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sửa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1036, 474);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 404);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtn_chuCuaHang);
            this.groupBox2.Controls.Add(this.rdbtn_nhanVien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(780, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 168);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quyền hạn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(858, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 43);
            this.button1.TabIndex = 33;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_XML_QL_BanGiay.Properties.Resources.user_profile;
            this.pictureBox1.Location = new System.Drawing.Point(420, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackgroundImage = global::BTL_XML_QL_BanGiay.Properties.Resources.delete;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_xoa.Location = new System.Drawing.Point(34, 294);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(80, 61);
            this.btn_xoa.TabIndex = 25;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackgroundImage = global::BTL_XML_QL_BanGiay.Properties.Resources.edit;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sua.Location = new System.Drawing.Point(34, 180);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(80, 61);
            this.btn_sua.TabIndex = 24;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackgroundImage = global::BTL_XML_QL_BanGiay.Properties.Resources.ic_add_32;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_them.Location = new System.Drawing.Point(34, 60);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(80, 61);
            this.btn_them.TabIndex = 23;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbox_maNhanVien);
            this.Controls.Add(this.txtField_timKiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtField_matKhau);
            this.Controls.Add(this.lbl_matKhau);
            this.Controls.Add(this.lbl_maNhanVien);
            this.Controls.Add(this.lbl_Top);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TaiKhoan";
            this.Size = new System.Drawing.Size(1224, 900);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_matKhau;
        private System.Windows.Forms.Label lbl_matKhau;
        private System.Windows.Forms.Label lbl_maNhanVien;
        private System.Windows.Forms.Label lbl_Top;
        private System.Windows.Forms.ComboBox cbbox_maNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
