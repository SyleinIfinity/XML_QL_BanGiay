using BTL_XML_QL_BanGiay.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace BTL_XML_QL_BanGiay.Forms
{
    public partial class TaiKhoan : UserControl
    {
        Connect cnn = new Connect();
        TaiKhoanModel tkM = new TaiKhoanModel();
        public TaiKhoan()
        {
            InitializeComponent();
            loadTaiKhoan();
            loadMaNhanVien();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            txtField_timKiem.TextChanged += txtField_timKiem_TextChanged;
        }

        private void loadTaiKhoan()
        {
            try
            {
                DataTable dt = cnn.showTable("TaiKhoan.xml");

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có dữ liệu tài khoản. Vui lòng thêm dữ liệu.");
                    return;
                }

                if (!dt.Columns.Contains("QuyenHienThi"))
                {
                    dt.Columns.Add("QuyenHienThi", typeof(string));
                }

                foreach (DataRow row in dt.Rows)
                {
                    bool quyen = row["quyen"] != DBNull.Value && Convert.ToBoolean(row["quyen"]);
                    row["QuyenHienThi"] = quyen ? "Chủ cửa hàng" : "Nhân viên";
                }

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["quyen"].Visible = false;
                dataGridView1.Columns["QuyenHienThi"].HeaderText = "Quyền";
                dataGridView1.Columns["manhanvien"].HeaderText = "Mã nhân viên";
                dataGridView1.Columns["matkhau"].HeaderText = "Mật khẩu";

                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void loadMaNhanVien()
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("NhanVien.xml");


                XmlNodeList staffNodes = xmlDoc.GetElementsByTagName("_x0027_NhanVien_x0027_");


                if (staffNodes.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu nhân viên.");
                    return;
                }

                List<string> shoeBrands = new List<string>();

                foreach (XmlNode node in staffNodes)
                {
                    XmlNode manhanvienNode = node.SelectSingleNode("manhanvien");

                    if (manhanvienNode != null)
                    {
                        shoeBrands.Add(manhanvienNode.InnerText);
                    }
                }

                cbbox_maNhanVien.DataSource = shoeBrands;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cbbox_maNhanVien.Text = row.Cells["manhanvien"].Value.ToString();
                txtField_matKhau.Text = row.Cells["matkhau"].Value.ToString();

                bool quyen = Convert.ToBoolean(row.Cells["quyen"].Value);

                if (!quyen)
                {
                    rdbtn_nhanVien.Checked = true;  
                    rdbtn_chuCuaHang.Checked = false;
                }
                else
                {
                    rdbtn_nhanVien.Checked = false;
                    rdbtn_chuCuaHang.Checked = true; 
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string staffCode = cbbox_maNhanVien.Text.Trim();
            string password = txtField_matKhau.Text.Trim();
            bool authority = false;

            if (string.IsNullOrEmpty(staffCode) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên và mật khẩu.");
                return;
            }

            if (tkM.checkStaffCode(staffCode))
            {
                MessageBox.Show("Mã nhân viên của tài này đã tồn tại.");
                return;
            }

            if (rdbtn_nhanVien.Checked)
            {
                authority = false;
            }
            else if (rdbtn_chuCuaHang.Checked)
            {
                authority = true;  
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quyền hạn.");
                return;
            }

            tkM.createAccount(staffCode, password, authority);

            loadTaiKhoan();
       
            MessageBox.Show("Thêm tài khoản thành công!");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string staffCode = cbbox_maNhanVien.Text.Trim();
            string password = txtField_matKhau.Text.Trim();
            bool authority = false;

            if (rdbtn_nhanVien.Checked)
            {
                authority = false;  
            }
            else if (rdbtn_chuCuaHang.Checked)
            {
                authority = true;  
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quyền hạn.");
                return;
            }

            if (!tkM.checkStaffCode(staffCode))
            {
                MessageBox.Show("Không tìm thấy tài khoản để sửa.");
                return;
            }

            tkM.updateAccount(staffCode, password, authority);
            loadTaiKhoan();
            MessageBox.Show("Cập nhật tài khoản thành công!!");

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                cbbox_maNhanVien.Text = selectedRow.Cells["manhanvien"]?.Value?.ToString() ?? string.Empty;
                txtField_matKhau.Text = selectedRow.Cells["matkhau"]?.Value?.ToString() ?? string.Empty;

                object quyenValue = selectedRow.Cells["quyen"].Value;
                bool quyen = quyenValue != DBNull.Value && Convert.ToBoolean(quyenValue);

                if (quyen)
                {
                    rdbtn_nhanVien.Checked = false;  
                    rdbtn_chuCuaHang.Checked = true;
                }
                else
                {
                    rdbtn_nhanVien.Checked = true;
                    rdbtn_chuCuaHang.Checked = false;  
                }
            }
        }

        private void txtField_timKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cnn.showTable("TaiKhoan.xml");
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string staffCode = cbbox_maNhanVien.Text.Trim();

            if (!tkM.checkStaffCode(staffCode))
            {
                MessageBox.Show("Không tìm thấy tài khoản để xóa.");
                return;
            }

            tkM.deleteAccount(staffCode);
            MessageBox.Show("Xóa tài khoản thành công!");
            loadTaiKhoan();
        }
    }
}
