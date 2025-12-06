using BTL_XML_QL_BanGiay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_XML_QL_BanGiay.UserControls
{
    public partial class HieuGiay : UserControl
    {
        Connect cnn = new Connect();
        HieuGiayModel hdM = new HieuGiayModel();

        public HieuGiay()
        {
            InitializeComponent();
            loadHieuGiay();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            txtField_timKiem.TextChanged += txtField_timKiem_TextChanged;
            LamDepGiaoDien();
        }

        private void loadHieuGiay()
        {
            try
            {
                DataTable dt = cnn.showTable("HieuGiay.xml");

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có dữ liệu hiệu giày. Vui lòng thêm dữ liệu.");
                    return;
                }

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["mahieugiay"].HeaderText = "Mã hiệu giày ";
                dataGridView1.Columns["tenhieugiay"].HeaderText = "Tên hiệu giày ";

                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtField_maHieuGiay.Text = row.Cells["mahieugiay"].Value.ToString();
                txtField_tenHieuGiay.Text = row.Cells["tenhieugiay"].Value.ToString();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtField_maHieuGiay.Text = selectedRow.Cells["mahieugiay"]?.Value?.ToString() ?? string.Empty;
                txtField_tenHieuGiay.Text = selectedRow.Cells["tenhieugiay"]?.Value?.ToString() ?? string.Empty;
            }
        }

        private void txtField_timKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cnn.showTable("HieuGiay.xml");
                if (dt == null || dt.Rows.Count == 0) return;

                string searchValue = txtField_timKiem.Text.Trim().ToLower();
                DataView dv = dt.DefaultView;
                if (!string.IsNullOrEmpty(searchValue))
                {
                    dv.RowFilter = $"mahieugiay LIKE '%{searchValue}%'";
                }
                else
                {
                    dv.RowFilter = string.Empty;
                }

                dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
        
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string shoeBrandCode = txtField_maHieuGiay.Text.Trim();
            string shoeBrandName = txtField_tenHieuGiay.Text.Trim();

            if (!hdM.checkShoeBrandCode(shoeBrandCode))
            {
                MessageBox.Show("Không tìm thấy hiệu giày để sửa.");
                return;
            }

            hdM.updateShoeBrand(shoeBrandCode, shoeBrandName);
            loadHieuGiay();
            MessageBox.Show("Cập nhật hiệu giày thành công!!");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string shoeBrandCode = txtField_maHieuGiay.Text.Trim();

            if (!hdM.checkShoeBrandCode(shoeBrandCode))
            {
                MessageBox.Show("Không tìm thấy tài khoản để xóa.");
                return;
            }

            hdM.deleteShoeBrand(shoeBrandCode);
            loadHieuGiay();

            MessageBox.Show("Xóa danh mục thành công!");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string shoeBrandCode = txtField_maHieuGiay.Text.Trim();
            string shoeBrandName = txtField_tenHieuGiay.Text.Trim();

            if (string.IsNullOrEmpty(shoeBrandCode) || string.IsNullOrEmpty(shoeBrandName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã hiệu giày và tên hiệu giày.");
                return;
            }

            if (hdM.checkShoeBrandCode(shoeBrandCode))
            {
                MessageBox.Show("Mã hiệu giày này đã tồn tại.");
                return;
            }

            hdM.createShoeBrand(shoeBrandCode, shoeBrandName);

            loadHieuGiay();

            MessageBox.Show("Thêm hiệu giày thành công!");
        }

        private void LamDepGiaoDien()
        {
            // 1. Làm đẹp bảng dữ liệu (DataGridView)
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204); // Màu xanh dương khi chọn
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72); // Màu tiêu đề xanh đậm
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động giãn cột

            // 2. Làm đẹp các nút bấm (Button)
            SetupButton(btn_them, "", Color.MediumSeaGreen);
            SetupButton(btn_sua, "", Color.Orange);
            SetupButton(btn_xoa, "", Color.Crimson);
        }

        private void SetupButton(Button btn, string text, Color backColor)
        {
            btn.Text = text; // Gán lại chữ cho chắc chắn
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand; // Đổi con trỏ chuột thành hình bàn tay
            btn.Size = new Size(100, 40); // Chỉnh kích thước nút to ra chút cho đẹp
        }
    }


}

