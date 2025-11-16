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
using System.Xml;

namespace BTL_XML_QL_BanGiay.UserControls
{
    public partial class Giay : UserControl
    {
        Connect cnn = new Connect();
        GiayModel gM = new GiayModel();
        public Giay()
        {
            InitializeComponent();
            loadGiay();
            loadHieuGiay();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            txtField_timKiem.TextChanged += txtField_timKiem_TextChanged;
        }

        private void loadGiay()
        {
            try
            {
                DataTable dt = cnn.showTable("Giay.xml");

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có dữ liệu giày. Vui lòng thêm dữ liệu.");
                    return;
                }

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["magiay"].HeaderText = "Mã giày";
                dataGridView1.Columns["mahieugiay"].HeaderText = "Mã hiệu giày";
                dataGridView1.Columns["tengiay"].HeaderText = "Tên giày";
                dataGridView1.Columns["size"].HeaderText = "Size";
                dataGridView1.Columns["mau"].HeaderText = "Màu";
                dataGridView1.Columns["dongia"].HeaderText = "Đơn giá";
                dataGridView1.Columns["soluong"].HeaderText = "Số lượng";


                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void loadHieuGiay()
        {
            try
            {
                
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("HieuGiay.xml");

                
                XmlNodeList shoeNodes = xmlDoc.GetElementsByTagName("_x0027_HieuGiay_x0027_");

                
                if (shoeNodes.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu hiệu giày.");
                    return;
                }

                List<string> shoeBrands = new List<string>();
             
                foreach (XmlNode node in shoeNodes)
                {
                    XmlNode mahieugiayNode = node.SelectSingleNode("mahieugiay");

                    if (mahieugiayNode != null)
                    {
                        shoeBrands.Add(mahieugiayNode.InnerText); 
                    }
                }

                cbbx_maHieuGiay.DataSource = shoeBrands; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách hiệu giày: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtField_maGiay.Text = row.Cells["magiay"].Value.ToString();
                cbbx_maHieuGiay.Text = row.Cells["mahieugiay"].Value.ToString();
                txtField_tenGiay.Text = row.Cells["tengiay"].Value.ToString();
                txtField_size.Text = row.Cells["size"].Value.ToString();
                txtField_mau.Text = row.Cells["mau"].Value.ToString();
                txtField_donGia.Text = row.Cells["dongia"].Value.ToString();
                txtField_soLuong.Text = row.Cells["soluong"].Value.ToString();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtField_maGiay.Text = selectedRow.Cells["magiay"]?.Value?.ToString() ?? string.Empty;
                cbbx_maHieuGiay.Text = selectedRow.Cells["mahieugiay"]?.Value?.ToString() ?? string.Empty;
                txtField_tenGiay.Text = selectedRow.Cells["tengiay"]?.Value?.ToString() ?? string.Empty;
                txtField_size.Text = selectedRow.Cells["size"]?.Value?.ToString() ?? string.Empty;
                txtField_mau.Text = selectedRow.Cells["mau"]?.Value?.ToString() ?? string.Empty;
                txtField_donGia.Text = selectedRow.Cells["dongia"]?.Value?.ToString() ?? string.Empty;
                txtField_soLuong.Text = selectedRow.Cells["soluong"]?.Value?.ToString() ?? string.Empty;
            }
        }

        private void txtField_timKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cnn.showTable("Giay.xml");
                if (dt == null || dt.Rows.Count == 0) return;

                string searchValue = txtField_timKiem.Text.Trim().ToLower();
                DataView dv = dt.DefaultView;
                if (!string.IsNullOrEmpty(searchValue))
                {
                    dv.RowFilter = $"magiay LIKE '%{searchValue}%'";
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
            string shoeCode = txtField_maGiay.Text.Trim();

            if (!gM.checkShoeCode(shoeCode))
            {
                MessageBox.Show("Không tìm thấy giày để xóa.");
                return;
            }

            gM.deleteShoe(shoeCode);
            MessageBox.Show("Xóa giày thành công!");
            loadGiay();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string shoeCode = txtField_maGiay.Text.Trim();
            string shoeBrandCode = cbbx_maHieuGiay.Text.Trim();
            string shoeName = txtField_tenGiay.Text.Trim();
            string size = txtField_size.Text.Trim();
            string color = txtField_mau.Text.Trim();
            string unitPrice = txtField_donGia.Text.Trim();
            string quantity = txtField_soLuong.Text.Trim();

            if (string.IsNullOrWhiteSpace(shoeCode) || string.IsNullOrWhiteSpace(shoeBrandCode) ||
                string.IsNullOrWhiteSpace(shoeName) || string.IsNullOrWhiteSpace(size) ||
                string.IsNullOrWhiteSpace(color) || string.IsNullOrWhiteSpace(unitPrice) ||
                string.IsNullOrWhiteSpace(quantity))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }


            if (!gM.checkShoeCode(shoeCode))
            {
                MessageBox.Show("Không tìm thấy giày để sửa.");
                return;
            }

            gM.updateShoe(shoeCode, shoeBrandCode, shoeName, size, color, unitPrice, quantity);

            loadGiay();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string shoeCode = txtField_maGiay.Text.Trim();
            string shoeBrandCode = cbbx_maHieuGiay.SelectedValue?.ToString();
            string shoeName = txtField_tenGiay.Text.Trim();
            string size = txtField_size.Text.Trim();
            string color = txtField_mau.Text.Trim();
            string unitPrice = txtField_donGia.Text.Trim();
            string quantity = txtField_soLuong.Text.Trim();

            if (!gM.checkEmpty(shoeCode, shoeBrandCode, shoeName, size, color, unitPrice, quantity))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!decimal.TryParse(unitPrice, out _) || !int.TryParse(quantity, out _))
            {
                MessageBox.Show("Đơn giá và số lượng phải là số hợp lệ.");
                return;
            }

            if (gM.checkShoeCode(shoeCode))
            {
                MessageBox.Show("Mã giày này đã tồn tại.");
                return;
            }

            gM.createShoe(shoeCode, shoeBrandCode, shoeName, size, color, unitPrice, quantity);
            loadGiay();
            MessageBox.Show("Thêm giày thành công!");
        }
    }
}
