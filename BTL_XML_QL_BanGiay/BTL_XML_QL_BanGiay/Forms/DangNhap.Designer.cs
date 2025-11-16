namespace BTL_XML_QL_BanGiay.Forms
{
    partial class DangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.lbl_title = new System.Windows.Forms.Label();
            this.txtField_staffCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtField_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new BTL_XML_QL_BanGiay.Utilities.GradientPanel();
            this.btn_showPass = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(252)))));
            this.lbl_title.Location = new System.Drawing.Point(708, 76);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(259, 60);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Đăng nhập";
            // 
            // txtField_staffCode
            // 
            this.txtField_staffCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtField_staffCode.BackColor = System.Drawing.Color.White;
            this.txtField_staffCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtField_staffCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtField_staffCode.Depth = 0;
            this.txtField_staffCode.Hint = "Mã nhân viên";
            this.txtField_staffCode.Location = new System.Drawing.Point(570, 241);
            this.txtField_staffCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtField_staffCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_staffCode.Name = "txtField_staffCode";
            this.txtField_staffCode.PasswordChar = '\0';
            this.txtField_staffCode.SelectedText = "";
            this.txtField_staffCode.SelectionLength = 0;
            this.txtField_staffCode.SelectionStart = 0;
            this.txtField_staffCode.Size = new System.Drawing.Size(552, 41);
            this.txtField_staffCode.TabIndex = 2;
            this.txtField_staffCode.UseSystemPasswordChar = false;
            // 
            // txtField_password
            // 
            this.txtField_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtField_password.BackColor = System.Drawing.Color.White;
            this.txtField_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtField_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtField_password.Depth = 0;
            this.txtField_password.Hint = "Mật khẩu";
            this.txtField_password.Location = new System.Drawing.Point(570, 342);
            this.txtField_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtField_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_password.Name = "txtField_password";
            this.txtField_password.PasswordChar = '\0';
            this.txtField_password.SelectedText = "";
            this.txtField_password.SelectionLength = 0;
            this.txtField_password.SelectionStart = 0;
            this.txtField_password.Size = new System.Drawing.Size(552, 41);
            this.txtField_password.TabIndex = 3;
            this.txtField_password.UseSystemPasswordChar = false;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(108)))), ((int)(((byte)(254)))));
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangNhap.Location = new System.Drawing.Point(818, 523);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(248, 69);
            this.btn_DangNhap.TabIndex = 5;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(538, 523);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(248, 69);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(508, 428);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(221, 30);
            this.materialCheckBox1.TabIndex = 12;
            this.materialCheckBox1.Text = "Nhớ đăng nhập";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(961, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quên mật khẩu";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(-1, 2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(458, 740);
            this.gradientPanel1.TabIndex = 7;
            // 
            // btn_showPass
            // 
            this.btn_showPass.BackColor = System.Drawing.Color.Transparent;
            this.btn_showPass.BackgroundImage = global::BTL_XML_QL_BanGiay.Properties.Resources.hidden;
            this.btn_showPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_showPass.Location = new System.Drawing.Point(1073, 338);
            this.btn_showPass.Name = "btn_showPass";
            this.btn_showPass.Size = new System.Drawing.Size(49, 45);
            this.btn_showPass.TabIndex = 11;
            this.btn_showPass.UseVisualStyleBackColor = false;
            this.btn_showPass.Click += new System.EventHandler(this.btn_showPass_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(508, 339);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::BTL_XML_QL_BanGiay.Properties.Resources.username;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(508, 237);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 656);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.btn_showPass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txtField_password);
            this.Controls.Add(this.txtField_staffCode);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_staffCode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_password;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_close;
        private Utilities.GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_showPass;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.Label label1;
    }
}