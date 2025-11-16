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
    public partial class DanhMuc : UserControl
    {
        Connect cnn = new Connect();
        DanhMucModel dmM = new DanhMucModel();

        public DanhMuc()
        {
            InitializeComponent();
            loadDanhMuc();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            txtField_timKiem.TextChanged += txtField_timKiem_TextChanged;
        }

        private void loadDanhMuc()
        {
            try
            {
                DataTable dt = cnn.showTable("DanhMuc.xml");

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có dữ liệu danh mục. Vui lòng thêm dữ liệu.");
                    return;
                }

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["madanhmuc"].HeaderText = "Mã danh mục";
                dataGridView1.Columns["tendanhmuc"].HeaderText = "Tên danh mục";

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
                txtField_maDanhMuc.Text = row.Cells["madanhmuc"].Value.ToString();
                txtField_tenDanhMuc.Text = row.Cells["tendanhmuc"].Value.ToString();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtField_maDanhMuc.Text = selectedRow.Cells["madanhmuc"]?.Value?.ToString() ?? string.Empty;
                txtField_tenDanhMuc.Text = selectedRow.Cells["tendanhmuc"]?.Value?.ToString() ?? string.Empty;
            }
        }

        private void txtField_timKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cnn.showTable("DanhMuc.xml");
                if (dt == null || dt.Rows.Count == 0) return;

                string searchValue = txtField_timKiem.Text.Trim().ToLower();
                DataView dv = dt.DefaultView;
                if (!string.IsNullOrEmpty(searchValue))
                {
                    dv.RowFilter = $"madanhmuc LIKE '%{searchValue}%'";
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            string categoryCode = txtField_maDanhMuc.Text.Trim();
            string categoryName = txtField_tenDanhMuc.Text.Trim();

            if (string.IsNullOrEmpty(categoryCode) || string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã danh mục và tên danh mục.");
                return;
            }

            if (dmM.checkCategoryCode(categoryCode))
            {
                MessageBox.Show("Mã danh mục này đã tồn tại.");
                return;
            }

            dmM.createCategory(categoryCode, categoryName);

            loadDanhMuc();

            MessageBox.Show("Thêm danh mục thành công!");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string categoryCode = txtField_maDanhMuc.Text.Trim();
            string categoryName = txtField_tenDanhMuc.Text.Trim();

            if (!dmM.checkCategoryCode(categoryCode))
            {
                MessageBox.Show("Không tìm thấy danh mục để sửa.");
                return;
            }

            dmM.updateCategory(categoryCode, categoryName);
            loadDanhMuc();
            MessageBox.Show("Cập nhật danh mục thành công!!");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string categoryCode = txtField_maDanhMuc.Text.Trim();

            if (!dmM.checkCategoryCode(categoryCode))
            {
                MessageBox.Show("Không tìm thấy tài khoản để xóa.");
                return;
            }

            dmM.deleteCategory(categoryCode);
            MessageBox.Show("Xóa danh mục thành công!");
            loadDanhMuc();
        }
    }
}
