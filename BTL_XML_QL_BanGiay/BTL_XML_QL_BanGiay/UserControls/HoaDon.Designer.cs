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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.txtField_timKiem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Top = new System.Windows.Forms.Label();
            this.lbl_Bottom = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_inHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtField_timKiem
            // 
            this.txtField_timKiem.Depth = 0;
            this.txtField_timKiem.Hint = "Tìm kiếm theo mã hoá đơn";
            this.txtField_timKiem.Location = new System.Drawing.Point(237, 51);
            this.txtField_timKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtField_timKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_timKiem.Name = "txtField_timKiem";
            this.txtField_timKiem.PasswordChar = '\0';
            this.txtField_timKiem.SelectedText = "";
            this.txtField_timKiem.SelectionLength = 0;
            this.txtField_timKiem.SelectionStart = 0;
            this.txtField_timKiem.Size = new System.Drawing.Size(259, 28);
            this.txtField_timKiem.TabIndex = 88;
            this.txtField_timKiem.UseSystemPasswordChar = false;
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(628, 40);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(60, 39);
            this.btn_them.TabIndex = 85;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 359);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 183);
            this.dataGridView1.TabIndex = 84;
            // 
            // lbl_Top
            // 
            this.lbl_Top.AutoSize = true;
            this.lbl_Top.Font = new System.Drawing.Font("Roboto Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Top.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(252)))));
            this.lbl_Top.Location = new System.Drawing.Point(284, 10);
            this.lbl_Top.Name = "lbl_Top";
            this.lbl_Top.Size = new System.Drawing.Size(123, 34);
            this.lbl_Top.TabIndex = 80;
            this.lbl_Top.Text = "Hoá đơn";
            // 
            // lbl_Bottom
            // 
            this.lbl_Bottom.AutoSize = true;
            this.lbl_Bottom.Font = new System.Drawing.Font("Roboto Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Bottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(252)))));
            this.lbl_Bottom.Location = new System.Drawing.Point(241, 312);
            this.lbl_Bottom.Name = "lbl_Bottom";
            this.lbl_Bottom.Size = new System.Drawing.Size(218, 34);
            this.lbl_Bottom.TabIndex = 89;
            this.lbl_Bottom.Text = "Chi tiết hoá đơn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 96);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(712, 183);
            this.dataGridView2.TabIndex = 90;
            // 
            // btn_inHoaDon
            // 
            this.btn_inHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_inHoaDon.Image")));
            this.btn_inHoaDon.Location = new System.Drawing.Point(628, 292);
            this.btn_inHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inHoaDon.Name = "btn_inHoaDon";
            this.btn_inHoaDon.Size = new System.Drawing.Size(60, 39);
            this.btn_inHoaDon.TabIndex = 91;
            this.btn_inHoaDon.UseVisualStyleBackColor = true;
            this.btn_inHoaDon.Click += new System.EventHandler(this.btn_inHoaDon_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_inHoaDon);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbl_Bottom);
            this.Controls.Add(this.txtField_timKiem);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Top);
            this.Name = "HoaDon";
            this.Size = new System.Drawing.Size(740, 553);
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_timKiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Top;
        private System.Windows.Forms.Label lbl_Bottom;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_inHoaDon;
    }
}
