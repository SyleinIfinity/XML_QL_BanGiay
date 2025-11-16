using BTL_XML_QL_BanGiay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_XML_QL_BanGiay.UserControls
{
    public partial class NhanVien : UserControl
    {   
        Connect cnn = new Connect();    
        NhanVienModel nvM = new NhanVienModel();
        public NhanVien()
        {
            InitializeComponent();
            loadNhanVien();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            txtField_timKiem.TextChanged += txtField_timKiem_TextChanged;
        }

        private void loadNhanVien()
        {           
            try
            {
                DataTable dt = cnn.showTable("NhanVien.xml");

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có dữ liệu nhân viên. Vui lòng thêm dữ liệu.");
                    return;
                }

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["manhanvien"].HeaderText = "Mã nhân viên";
                dataGridView1.Columns["hoten"].HeaderText = "Tên nhân viên";
                dataGridView1.Columns["diachi"].HeaderText = "Địa chỉ";
                dataGridView1.Columns["sdt"].HeaderText = "Số điện thoại";
                dataGridView1.Columns["email"].HeaderText = "Email";

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
                txtField_maNhanVien.Text = row.Cells["manhanvien"].Value.ToString();
                txtField_hoTen.Text = row.Cells["hoten"].Value.ToString();
                txtField_diaChi.Text = row.Cells["diachi"].Value.ToString();
                txtField_soDienThoai.Text = row.Cells["sdt"].Value.ToString();
                txtField_email.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string staffCode = txtField_maNhanVien.Text.Trim();
            string fullName = txtField_hoTen.Text.Trim();
            string address = txtField_diaChi.Text.Trim();
            string phoneNumber = txtField_soDienThoai.Text.Trim();
            string email = txtField_email.Text.Trim();

            if (!nvM.checkEmpty(staffCode, fullName, address, phoneNumber, email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (nvM.checkStaffCode(staffCode))
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại.");
                return;
            }

            nvM.createStaff(staffCode, fullName, address, phoneNumber, email);
            loadNhanVien();
            MessageBox.Show("Thêm nhân viên thành công!");
        }


        private void btn_sua_Click(object sender, EventArgs e)
        {
            string staffCode = txtField_maNhanVien.Text.Trim();
            string fullName = txtField_hoTen.Text.Trim();
            string address = txtField_diaChi.Text.Trim();
            string phoneNumber = txtField_soDienThoai.Text.Trim();
            string email = txtField_email.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }


            if (!nvM.checkStaffCode(staffCode))
            {
                MessageBox.Show("Không tìm thấy nhân viên để sửa.");
                return ;
            }

            nvM.updateStaff(staffCode, fullName, address, phoneNumber, email);
       
            loadNhanVien();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string staffCode = txtField_maNhanVien.Text.Trim();

            if (!nvM.checkStaffCode(staffCode))
            {
                MessageBox.Show("Không tìm thấy nhân viên để xóa.");
                return;
            }

            nvM.deleteStaff(staffCode);
            MessageBox.Show("Xóa nhân viên thành công!");
            loadNhanVien();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
               
                txtField_maNhanVien.Text = selectedRow.Cells["manhanvien"]?.Value?.ToString() ?? string.Empty;
                txtField_hoTen.Text = selectedRow.Cells["hoten"]?.Value?.ToString() ?? string.Empty;
                txtField_diaChi.Text = selectedRow.Cells["diachi"]?.Value?.ToString() ?? string.Empty;
                txtField_soDienThoai.Text = selectedRow.Cells["sdt"]?.Value?.ToString() ?? string.Empty;
                txtField_email.Text = selectedRow.Cells["email"]?.Value?.ToString() ?? string.Empty;
            }
        }

        private void txtField_timKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cnn.showTable("NhanVien.xml");
                if (dt == null || dt.Rows.Count == 0) return;

                string searchValue = txtField_timKiem.Text.Trim().ToLower();
                DataView dv = dt.DefaultView;
                if (!string.IsNullOrEmpty(searchValue))
                {
                    dv.RowFilter = $"manhanvien LIKE '%{searchValue}%'";
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
    }
}
