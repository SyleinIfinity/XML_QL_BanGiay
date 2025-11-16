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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMuc));
            this.txtField_timKiem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtField_tenDanhMuc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_tenDanhMuc = new System.Windows.Forms.Label();
            this.txtField_maDanhMuc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_maDanhMuc = new System.Windows.Forms.Label();
            this.lbl_Top = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtField_timKiem
            // 
            this.txtField_timKiem.Depth = 0;
            this.txtField_timKiem.Hint = "Tìm kiếm theo mã danh mục";
            this.txtField_timKiem.Location = new System.Drawing.Point(227, 66);
            this.txtField_timKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtField_timKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_timKiem.Name = "txtField_timKiem";
            this.txtField_timKiem.PasswordChar = '\0';
            this.txtField_timKiem.SelectedText = "";
            this.txtField_timKiem.SelectionLength = 0;
            this.txtField_timKiem.SelectionStart = 0;
            this.txtField_timKiem.Size = new System.Drawing.Size(272, 28);
            this.txtField_timKiem.TabIndex = 40;
            this.txtField_timKiem.UseSystemPasswordChar = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(453, 193);
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
            this.btn_sua.Location = new System.Drawing.Point(295, 193);
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
            this.btn_them.Location = new System.Drawing.Point(141, 193);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 250);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 292);
            this.dataGridView1.TabIndex = 36;
            // 
            // txtField_tenDanhMuc
            // 
            this.txtField_tenDanhMuc.Depth = 0;
            this.txtField_tenDanhMuc.Hint = "Tên danh mục";
            this.txtField_tenDanhMuc.Location = new System.Drawing.Point(524, 124);
            this.txtField_tenDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtField_tenDanhMuc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_tenDanhMuc.Name = "txtField_tenDanhMuc";
            this.txtField_tenDanhMuc.PasswordChar = '\0';
            this.txtField_tenDanhMuc.SelectedText = "";
            this.txtField_tenDanhMuc.SelectionLength = 0;
            this.txtField_tenDanhMuc.SelectionStart = 0;
            this.txtField_tenDanhMuc.Size = new System.Drawing.Size(199, 28);
            this.txtField_tenDanhMuc.TabIndex = 32;
            this.txtField_tenDanhMuc.UseSystemPasswordChar = false;
            // 
            // lbl_tenDanhMuc
            // 
            this.lbl_tenDanhMuc.AutoSize = true;
            this.lbl_tenDanhMuc.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_tenDanhMuc.Location = new System.Drawing.Point(377, 124);
            this.lbl_tenDanhMuc.Name = "lbl_tenDanhMuc";
            this.lbl_tenDanhMuc.Size = new System.Drawing.Size(136, 24);
            this.lbl_tenDanhMuc.TabIndex = 31;
            this.lbl_tenDanhMuc.Text = "Tên danh mục";
            // 
            // txtField_maDanhMuc
            // 
            this.txtField_maDanhMuc.Depth = 0;
            this.txtField_maDanhMuc.Hint = "Mã danh mục";
            this.txtField_maDanhMuc.Location = new System.Drawing.Point(161, 124);
            this.txtField_maDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtField_maDanhMuc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_maDanhMuc.Name = "txtField_maDanhMuc";
            this.txtField_maDanhMuc.PasswordChar = '\0';
            this.txtField_maDanhMuc.SelectedText = "";
            this.txtField_maDanhMuc.SelectionLength = 0;
            this.txtField_maDanhMuc.SelectionStart = 0;
            this.txtField_maDanhMuc.Size = new System.Drawing.Size(199, 28);
            this.txtField_maDanhMuc.TabIndex = 30;
            this.txtField_maDanhMuc.UseSystemPasswordChar = false;
            // 
            // lbl_maDanhMuc
            // 
            this.lbl_maDanhMuc.AutoSize = true;
            this.lbl_maDanhMuc.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_maDanhMuc.Location = new System.Drawing.Point(15, 124);
            this.lbl_maDanhMuc.Name = "lbl_maDanhMuc";
            this.lbl_maDanhMuc.Size = new System.Drawing.Size(131, 24);
            this.lbl_maDanhMuc.TabIndex = 29;
            this.lbl_maDanhMuc.Text = "Mã danh mục";
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
            this.lbl_Top.Text = "Danh mục";
            // 
            // DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtField_timKiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtField_tenDanhMuc);
            this.Controls.Add(this.lbl_tenDanhMuc);
            this.Controls.Add(this.txtField_maDanhMuc);
            this.Controls.Add(this.lbl_maDanhMuc);
            this.Controls.Add(this.lbl_Top);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DanhMuc";
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_tenDanhMuc;
        private System.Windows.Forms.Label lbl_tenDanhMuc;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_maDanhMuc;
        private System.Windows.Forms.Label lbl_maDanhMuc;
        private System.Windows.Forms.Label lbl_Top;
    }
}
