using BTL_XML_QL_BanGiay.Forms;
using BTL_XML_QL_BanGiay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace BTL_XML_QL_BanGiay.UserControls
{
    public partial class HoaDon : UserControl
    {
        Connect cnn = new Connect();
        private string billCodee;
        private string staffNamee;

        XDocument xDoc;
        public HoaDon()
        {
            InitializeComponent();
            showBill();
            initDgvChiTietHoaDon();

            txtField_timKiem.TextChanged += txtField_timKiem_TextChanged;
            dataGridView2.CellClick += DataGridView2_CellClick;
        }

        public HoaDon(string staffName) : this()
        {
            this.staffNamee = staffName;

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void showBillDetail(string billCode)
        {
            initDgvChiTietHoaDon();
            if (!File.Exists("ChiTietHoaDon.xml"))
            {
                MessageBox.Show("Tệp ChiTietHoaDon.xml không tồn tại.");
                return;
            }

            try
            {
                XDocument doc = XDocument.Load("ChiTietHoaDon.xml");
                var list = doc.Descendants("_x0027_ChiTietHoaDon_x0027_");
                string maHD, maSP, soLuongDat, donGia;
                this.dataGridView1.Rows.Clear();
                bool dataFound = false;

                foreach (XElement node in list)
                {
                    maHD = node.Element("mahoadon")?.Value;
                    if (maHD == billCode)
                    {
                        maSP = node.Element("magiay")?.Value;
                        soLuongDat = node.Element("soluong")?.Value;
                        donGia = node.Element("dongia")?.Value;

                        if (!string.IsNullOrEmpty(maSP) && !string.IsNullOrEmpty(soLuongDat) && !string.IsNullOrEmpty(donGia))
                        {
                            this.dataGridView1.Rows.Add(maHD, maSP, soLuongDat, donGia);
                            dataFound = true;
                        }
                    }
                }
                if (!dataFound)
                {
                    MessageBox.Show("Không tìm thấy chi tiết hóa đơn với mã: " + billCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void initDgvChiTietHoaDon()
        {
            if (this.dataGridView1.Columns.Count == 0)
            {
                this.dataGridView1.ColumnCount = 4;
                this.dataGridView1.Columns[0].Name = "mahoadon";
                this.dataGridView1.Columns[1].Name = "magiay";
                this.dataGridView1.Columns[2].Name = "soluong";
                this.dataGridView1.Columns[3].Name = "dongia";

                dataGridView1.Columns[0].HeaderText = "Mã hoá đơn";
                dataGridView1.Columns[1].HeaderText = "Mã giày";
                dataGridView1.Columns[2].HeaderText = "Số lượng";
                dataGridView1.Columns[3].HeaderText = "Đơn giá";
            }
        }

        public void showBill()
        {
            try
            {
                DataTable dt = cnn.showTable("HoaDon.xml");

                if (!dt.Columns.Contains("TrangThaiText"))
                    dt.Columns.Add("TrangThaiText", typeof(string));
                if (!dt.Columns.Contains("PhuongThucThanhToanText"))
                    dt.Columns.Add("PhuongThucThanhToanText", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    bool trangThai = Convert.ToBoolean(row["trangthai"]);
                    bool phuongThucThanhToan = Convert.ToBoolean(row["phuongthucthanhtoan"]);

                    row["TrangThaiText"] = trangThai ? "Đã thanh toán" : "Chưa thanh toán";
                    row["PhuongThucThanhToanText"] = phuongThucThanhToan ? "Chuyển khoản" : "Tiền mặt";
                }

                dataGridView2.DataSource = dt;

                dataGridView2.Columns["mahoadon"].HeaderText = "Mã hoá đơn";
                dataGridView2.Columns["manhanvien"].HeaderText = "Mã nhân viên";
                dataGridView2.Columns["tenkhachhang"].HeaderText = "Tên khách hàng";
                dataGridView2.Columns["ngaytao"].HeaderText = "Ngày tạo";
                dataGridView2.Columns["tongtien"].HeaderText = "Tổng tiền";
                dataGridView2.Columns["TrangThaiText"].HeaderText = "Trạng thái";
                dataGridView2.Columns["PhuongThucThanhToanText"].HeaderText = "Phương thức thanh toán";

                dataGridView2.Columns["trangthai"].Visible = false;
                dataGridView2.Columns["phuongthucthanhtoan"].Visible = false;

                dataGridView2.DataError += (sender, e) => e.Cancel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                billCodee = dataGridView2.Rows[e.RowIndex].Cells["mahoadon"].Value.ToString();
                showBillDetail(billCodee);
            }
        }

        private void txtField_timKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cnn.showTable("HoaDon.xml");
                if (dt == null || dt.Rows.Count == 0) return;

                string searchValue = txtField_timKiem.Text.Trim().ToLower();
                DataView dv = dt.DefaultView;
                if (!string.IsNullOrEmpty(searchValue))
                {
                    dv.RowFilter = $"mahoadon LIKE '%{searchValue}%'";
                }
                else
                {
                    dv.RowFilter = string.Empty;
                }

                dataGridView2.DataSource = dv;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }

        }


        private void printBill()
        {
            if (string.IsNullOrEmpty(billCodee))
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để in.");
                return;
            }

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HoaDon_ChiTiet.html");

            XDocument hoaDonDoc = XDocument.Load("HoaDon.xml");
            XDocument chiTietHoaDonDoc = XDocument.Load("ChiTietHoaDon.xml");

            var hoaDonItems = hoaDonDoc.Descendants("_x0027_HoaDon_x0027_")
                                      .FirstOrDefault(x => x.Element("mahoadon")?.Value == billCodee);

            if (hoaDonItems == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn với mã: " + billCodee);
                return;
            }

            var chiTietItems = chiTietHoaDonDoc.Descendants("_x0027_ChiTietHoaDon_x0027_")
                                               .Where(x => x.Element("mahoadon")?.Value == billCodee);

            //decimal totalAll = 0;

            var html = new XElement("html",
                new XElement("head",
                    new XElement("style", @"
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f9;
            margin: 0;
            padding: 20px;
        }
        h2 {
            text-align: center;
            color: #333;
            margin-bottom: 30px;
        }
        table {
            width: 100%;
            border-collapse: collapse;
            margin: 0 auto;
            box-shadow: 0px 4px 6px rgba(0, 0, 0, 0.1);
        }
        th, td {
            padding: 12px;
            text-align: left;
            border: 1px solid #ddd;
            font-size: 14px;
        }
        th {
            background-color: #4CAF50;
            color: white;
        }
        td {
            background-color: #f9f9f9;
        }
        tr:nth-child(even) td {
            background-color: #f2f2f2;
        }
        tr:hover td {
            background-color: #ddd;
        }
        td:nth-child(5) {
            text-align: right;
        }
        .total-row {
            font-weight: bold;
            background-color: #f4f4f9;
            text-align: right;
        }
        .total-label {
            font-size: 16px;
        }
        .total-amount {
            font-size: 16px;
            color: #ff5722;
        }
    ")
                ),
                new XElement("body",
                    new XElement("h2", "Hoá Đơn"),
                    new XElement("P", $"Mã hoá đơn: {hoaDonItems.Element("mahoadon")?.Value}"),
                    new XElement("p", $"Mã nhân viên: {hoaDonItems.Element("manhanvien")?.Value}"),
                    new XElement("p", $"Tên khách hàng: {hoaDonItems.Element("tenkhachhang")?.Value}"),
                    new XElement("p", $"Ngày tạo: {hoaDonItems.Element("ngaytao")?.Value}"),

                    new XElement("table",
                        new XElement("tr",
                            new XElement("td", new XAttribute("style", "background-color:cyan"), "Mã giày"),
                            new XElement("td", new XAttribute("style", "background-color:cyan"), "Số lượng đặt"),
                            new XElement("td", new XAttribute("style", "background-color:cyan"), "Đơn giá"),
                            new XElement("td", new XAttribute("style", "background-color:cyan"), "Thành tiền")),

                        from el in chiTietItems
                        let tt = (int.Parse(el.Element("soluong")?.Value ?? "0") * decimal.Parse(el.Element("dongia")?.Value ?? "0"))
                        select new XElement("tr",
                            new XElement("td", el.Element("magiay")?.Value),
                            new XElement("td", el.Element("soluong")?.Value),
                            new XElement("td", new XAttribute("style", "text-align:right"), el.Element("dongia")?.Value),
                            new XElement("td", new XAttribute("style", "text-align:right"), tt.ToString("C"))
                        )

                    ),

                    new XElement("table", new XElement("tr",
                        new XElement("td", new XAttribute("colspan", "3"), "Tổng tiền hoá đơn:"),
                        new XElement("td", new XAttribute("style", "text-align:right; font-weight: bold;"),
                            chiTietItems.Sum(el => (int.Parse(el.Element("soluong")?.Value ?? "0") * decimal.Parse(el.Element("dongia")?.Value ?? "0"))).ToString("C"))
                    ))
                )
            );

            html.Save(filePath);
            Process.Start(filePath);
        }

        private void btn_inHoaDon_Click(object sender, EventArgs e)
        {
            printBill();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            TrangChu parentForm = this.ParentForm as TrangChu;
            if (parentForm != null)
            {
                ThemHoaDon themHoaDonControl = new ThemHoaDon(
                    parentForm.StaffCode,
                    parentForm.StaffName
                );
                parentForm.addUserControl(themHoaDonControl);
            }
        }

        //public void PrintBill()
        //{
        //    if (string.IsNullOrEmpty(billCodee))
        //    {
        //        MessageBox.Show("Vui lòng chọn một hóa đơn để in.");
        //        return;
        //    }

        //    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HoaDon_ChiTiet.html");
        //    string xmlFilePath = "HoaDon.xml";
        //    string xsltFilePath = "HoaDon.xslt"; 

        //    XDocument hoaDonDoc = XDocument.Load(xmlFilePath);

        //    var hoaDonItems = hoaDonDoc.Descendants("_x0027_HoaDon_x0027_")
        //                                .FirstOrDefault(x => x.Element("mahoadon")?.Value == billCodee);

        //    if (hoaDonItems == null)
        //    {
        //        MessageBox.Show("Không tìm thấy hóa đơn với mã: " + billCodee);
        //        return;
        //    }

        //    XslCompiledTransform xslt = new XslCompiledTransform();
        //    xslt.Load(xsltFilePath);

        //    using (XmlWriter writer = XmlWriter.Create(filePath, new XmlWriterSettings { Indent = true }))
        //    {
        //        xslt.Transform(XmlReader.Create(xmlFilePath), writer);
        //    }

        //    Process.Start(filePath);
        //}

    }
}
