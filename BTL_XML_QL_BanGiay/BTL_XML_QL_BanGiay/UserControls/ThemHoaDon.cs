using BTL_XML_QL_BanGiay.Forms;
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
using System.Xml.Linq;

namespace BTL_XML_QL_BanGiay.UserControls
{
    public partial class ThemHoaDon : UserControl
    {
        Connect cnn = new Connect();
        HoaDonModel hdM = new HoaDonModel();
        GiayModel gM = new GiayModel();

        private string _staffCode;
        private string _staffName;
        private XDocument xDoc;

        public static int quantityRest;
        public static decimal tgTien;

        public ThemHoaDon(string staffCode, string staffName)
        {
            InitializeComponent();
            _staffCode = staffCode;
            _staffName = staffName;
            txtField_tenNhanVien.Text = staffName;
            loadHoaDon();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns.Count > 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["phuongthucthanhtoan"]?.Index)
                {
                    if (e.Value != null)
                    {
                        bool value = Convert.ToBoolean(e.Value);
                        e.Value = value ? "Chuyển khoản" : "Tiền mặt";
                        e.FormattingApplied = true;
                    }
                }
                else if (e.ColumnIndex == dataGridView1.Columns["trangthai"]?.Index)
                {
                    if (e.Value != null)
                    {
                        bool value = Convert.ToBoolean(e.Value);
                        e.Value = value ? "Đã thanh toán" : "Chưa thanh toán";
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void loadHoaDon()
        {
            try
            {
                DataTable dt = new Connect().showTable("ChiTietHoaDon.xml");

                dataGridView1.DataSource = dt;

                dataGridView1.Columns["mahoadon"].HeaderText = "Mã hoá đơn";
                dataGridView1.Columns["magiay"].HeaderText = "Mã giày";
                dataGridView1.Columns["soluong"].HeaderText = "Số lượng";
                dataGridView1.Columns["dongia"].HeaderText = "Đơn giá";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            cbbox_maGiay.DataSource = gM.loadShoeCode();
            cbbox_maGiay.ValueMember = "magiay";
            cbbox_maGiay.DisplayMember = "tengiay";
            initUnitPrice(cbbox_maGiay.SelectedValue.ToString());

            cbbx_thanhToan.Items.Add("Chuyển khoản");
            cbbx_thanhToan.Items.Add("Tiền mặt");
            cbbx_thanhToan.SelectedIndex = 0;

            cbbox_trangThai.Items.Add("Đã thanh toán");
            cbbox_trangThai.Items.Add("Chưa thanh toán");
            cbbox_trangThai.SelectedIndex = 0;

            btn_luu.Enabled = false;

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initUnitPrice(string shoeCode)
        {
            try
            {
                xDoc = XDocument.Load("Giay.xml");
                var shoe = xDoc.Descendants("_x0027_Giay_x0027_")
                              .FirstOrDefault(x => x.Element("magiay")?.Value == shoeCode);

                if (shoe == null)
                {
                    txtField_donGia.Text = "0";
                    quantityRest = 0;
                    return;
                }

                if (decimal.TryParse(shoe.Element("dongia")?.Value, out decimal unitPrice))
                {
                    txtField_donGia.Text = unitPrice.ToString("F2");
                }
                else
                {
                    txtField_donGia.Text = "0";
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                quantityRest = int.TryParse(shoe.Element("soluong")?.Value, out int quantity) ? quantity : 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc thông tin giày: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!hdM.checkEmpty(txtField_maHoaDon.Text.Trim(), txtField_tenKhachHang.Text.Trim(), txtField_soLuong.Text.Trim()))
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin");
                txtField_maHoaDon.Text = "";
                txtField_soLuong.Text = "";
                txtField_tenKhachHang.Text = "";
                txtField_maHoaDon.Focus();
                return;
            }

            if (hdM.checkBillCode(txtField_maHoaDon.Text))
            {
                MessageBox.Show("Mã hoá đơn này đã tồn tại");
                return;
            }

            if (!int.TryParse(txtField_soLuong.Text.Trim(), out int quantity))
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtField_donGia.Text.Trim(), out decimal unitPrice))
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (quantity > quantityRest)
            {
                MessageBox.Show($"Số lượng vượt quá số lượng tồn kho ({quantityRest})", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tgTien = quantity * unitPrice;

            try 
            {
                string maHoaDon = txtField_maHoaDon.Text.Trim();
                string tenKhachHang = txtField_tenKhachHang.Text.Trim();
                string ngayTao = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string phuongThucThanhToan = cbbx_thanhToan.Text;
                string trangThai = cbbox_trangThai.Text;
                string maGiay = cbbox_maGiay.SelectedValue.ToString(); 

                hdM.createBill(
                    maHoaDon,
                    maGiay,
                    _staffCode, 
                    tenKhachHang,
                    ngayTao,
                    phuongThucThanhToan,
                    unitPrice,
                    trangThai,
                    quantity,
                    tgTien
                );

                MessageBox.Show("Tạo hoá đơn thành công");
                loadHoaDon(); 

                string message = "Bạn muốn thêm giày mới vào hoá đơn không?";
                string title = "Thêm giày>>>";
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
                
                if (result == DialogResult.Yes)
                {
                    btn_them.Visible = false;
                    btn_luu.Visible = true;
                    btn_luu.Enabled = true;
                    
                    txtField_maHoaDon.Enabled = false;
                    txtField_tenKhachHang.Enabled = false;
                    txtField_donGia.Enabled = false;
                    cbbx_thanhToan.Enabled = false;
                    cbbox_trangThai.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    
                    cbbox_maGiay.Enabled = true;
                    txtField_soLuong.Enabled = true;
                    txtField_soLuong.Text = "0";

                    showBillDetail(maHoaDon);
                }
                else
                {
                    clearTextField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo hoá đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void showBillDetail(string billCode)
        {
            try
            {
                initdataGridView1();
                XDocument doc = XDocument.Load("ChiTietHoaDon.xml");
                var list = doc.Descendants("_x0027_ChiTietHoaDon_x0027_");
                string maHoaDon, maGiay, soLuongDat, donGia;
                
                List<string[]> rowsToAdd = new List<string[]>();
                
                foreach (XElement node in list)
                {
                    maHoaDon = node.Element("mahoadon").Value.ToString();
                    if (maHoaDon == billCode)
                    {
                        maGiay = node.Element("magiay").Value;
                        soLuongDat = node.Element("soluong").Value;
                        donGia = node.Element("dongia").Value;
                        rowsToAdd.Add(new string[] { maHoaDon, maGiay, soLuongDat, donGia });
                    }
                }

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                }

                foreach (string[] row in rowsToAdd)
                {
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Lỗi khi hiển thị chi tiết hoá đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void initdataGridView1()
        {
            if (this.dataGridView1.Columns.Count == 0)
            {
                this.dataGridView1.ColumnCount = 4;
                this.dataGridView1.Columns[0].Name = "mahoadon";
                this.dataGridView1.Columns[1].Name = "magiay";
                this.dataGridView1.Columns[2].Name = "soluong";
                this.dataGridView1.Columns[3].Name = "dongia";
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (!hdM.checkDuplicatesProduct(txtField_maHoaDon.Text, cbbox_maGiay.SelectedValue.ToString()))
            {
                MessageBox.Show("Giày này đã có trong hoá đơn rồi nhé ////");
            }
            else
            {
                decimal unitPrice;

                bool isUnitPriceValid = decimal.TryParse(txtField_donGia.Text, out unitPrice);

                if (isUnitPriceValid)
                {
                    hdM.createBillDetail(txtField_maHoaDon.Text, cbbox_maGiay.SelectedValue.ToString(), Int32.Parse(txtField_soLuong.Text), unitPrice);
                    MessageBox.Show("Thêm giày thành công");
                    loadHoaDon(); 
                    
                    string message = "Bạn muốn thêm giày mới vào hoá đơn hả ))))?";
                    string title = "Thêm giày>>";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        txtField_maHoaDon.Enabled = false;
                        txtField_tenKhachHang.Enabled = false;
                        showBillDetail(txtField_maHoaDon.Text);
                        
                        txtField_soLuong.Text = "0";
                    }
                    else
                    {
                        clearTextField();
                    }
                }
                else
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void clearTextField()
        {
            txtField_maHoaDon.Text = "";
            txtField_tenKhachHang.Text = "";
            txtField_soLuong.Text = "0";
            btn_luu.Visible = false;
            btn_luu.Enabled = false;
            btn_them.Visible = true;
            
            txtField_maHoaDon.Enabled = true;
            txtField_tenKhachHang.Enabled = true;
            txtField_donGia.Enabled = true;
            cbbox_maGiay.Enabled = true;
            txtField_soLuong.Enabled = true;
            cbbx_thanhToan.Enabled = true;
            cbbox_trangThai.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridView1.Rows[e.RowIndex];

                txtField_maHoaDon.Text = r.Cells["mahoadon"].Value.ToString();
                txtField_tenKhachHang.Text = r.Cells["tenkhachhang"].Value.ToString();
                cbbox_maGiay.Text = r.Cells["magiay"].Value.ToString();
                txtField_soLuong.Text = r.Cells["soluong"].Value.ToString();
                txtField_donGia.Text = r.Cells["dongia"].Value.ToString();
                txtField_tenNhanVien.Text = r.Cells["manhanvien"].Value.ToString();

                if (r.Cells["ngaytao"].Value != null)
                {
                    dateTimePicker1.Value = Convert.ToDateTime(r.Cells["ngaytao"].Value);
                }

                if (r.Cells["phuongthucthanhtoan"].Value != null)
                {
                    bool phuongThuc = Convert.ToBoolean(r.Cells["phuongthucthanhtoan"].Value);
                    cbbx_thanhToan.SelectedItem = phuongThuc ? "Chuyển khoản" : "Tiền mặt";
                }

                if (r.Cells["trangthai"].Value != null)
                {
                    bool trangThai = Convert.ToBoolean(r.Cells["trangthai"].Value);
                    cbbox_trangThai.SelectedItem = trangThai ? "Đã thanh toán" : "Chưa thanh toán";
                }
            }
        }

        private void btn_troLai_Click(object sender, EventArgs e)
        {
            TrangChu parentForm = this.ParentForm as TrangChu;
            if (parentForm != null)
            {
                HoaDon hoaDonControl = new HoaDon(parentForm.StaffName);
                parentForm.addUserControl(hoaDonControl);
            }
        }

        private void cbbox_maGiay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbox_maGiay.SelectedValue != null)
            {
                string maGiay = cbbox_maGiay.SelectedValue.ToString();
                initUnitPrice(maGiay);
            }
        }

    }
}
