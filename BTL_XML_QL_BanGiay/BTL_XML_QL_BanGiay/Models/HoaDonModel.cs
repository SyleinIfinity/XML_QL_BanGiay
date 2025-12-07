using BTL_XML_QL_BanGiay.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace BTL_XML_QL_BanGiay.Models
{
    internal class HoaDonModel
    {
        Connect cnn = new Connect();
        public string filePath = "HoaDon.xml";
        public XDocument xDoc;
        public XmlDocument xmlDoc = new XmlDocument();
      

        public bool checkEmpty(string billCode, string staffCode, string nameCustomer)
        {
            if (string.IsNullOrEmpty(billCode) || string.IsNullOrEmpty(staffCode) || string.IsNullOrEmpty(nameCustomer))
            {
                return false;
            }
            return true;
        }

        public bool checkBillCode(string billCode)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(filePath);
                DataSet ds = new DataSet();
                ds.ReadXml(reader);
                reader.Close();


                DataTable dt = ds.Tables[0];
                DataRow[] foundRows = dt.Select("mahoadon = '" + billCode + "'");

                return foundRows.Length > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra mã hoá đơn: " + ex.Message);
                return false;
            }
        }

        public void updateQuantityProduct(string billCode, int quantity)
        {
            xmlDoc.Load(Application.StartupPath + filePath);
            XmlNode node = xmlDoc.SelectSingleNode("NewDataSet/_x0027_HoaDon_x0027_[mahoadon = '" + billCode + "']");
            if (node != null) {
                node.ChildNodes[1].InnerText = quantity.ToString();
                xmlDoc.Save(Application.StartupPath + filePath);
            }
        }


        public void createBillDetail(string billCode, string shoeCode, int quantity, decimal unitPrice)
        {
            if (quantity <= 0)
                throw new ArgumentException("Số lượng phải lớn hơn 0");

            try
            {
                DataTable dt = cnn.showTable("ChiTietHoaDon.xml");
                int quantityProduct = 0;
                
                foreach (DataRow row in dt.Rows)
                {
                    if (row["mahoadon"].ToString() == billCode && row["magiay"].ToString() == shoeCode)
                    {
                        quantityProduct = Convert.ToInt32(row["soluong"]);
                        break;
                    }
                }

                if (quantityProduct > 0)
                {
                    int newQuantity = quantityProduct + quantity;
                    updateQuantityProduct(billCode, newQuantity );
                    updateTotalCost(billCode, newQuantity, unitPrice);
                    updateQuantityRest(shoeCode, quantity);
                }
                else 
                {
                    string data = $@"<_x0027_ChiTietHoaDon_x0027_>
                        <mahoadon>{billCode}</mahoadon>
                        <magiay>{shoeCode}</magiay>
                        <soluong>{quantity}</soluong>
                        <dongia>{unitPrice:F2}</dongia>
                    </_x0027_ChiTietHoaDon_x0027_>";
                    cnn.Create("ChiTietHoaDon.xml", data);
                    updateTotalCost(billCode, quantity, unitPrice);
                    updateQuantityRest(shoeCode, quantity);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo chi tiết hóa đơn: {ex.Message}");
            }
        }

        public void createBill(string billCode, string shoeCode, string staffCode, string nameCustomer, string createDay, 
            string typeOfPayment, decimal unitPrice, string status, int quantity, decimal totalCost) 
        {
            try 
            {
                bool isTransfer = typeOfPayment.Equals("Chuyển khoản", StringComparison.OrdinalIgnoreCase);
                bool isPaid = status.Equals("Đã thanh toán", StringComparison.OrdinalIgnoreCase);

                string phuongThucThanhToan = isTransfer ? "true" : "false";
                string trangThai = isPaid ? "true" : "false";

                string hoaDonData = $@"<_x0027_HoaDon_x0027_>
                    <mahoadon>{billCode}</mahoadon>
                    <manhanvien>{staffCode}</manhanvien>
                    <tenkhachhang>{nameCustomer}</tenkhachhang>
                    <ngaytao>{createDay}</ngaytao>
                    <phuongthucthanhtoan>{phuongThucThanhToan}</phuongthucthanhtoan>
                    <tongtien>{totalCost:F2}</tongtien>
                    <trangthai>{trangThai}</trangthai>
                </_x0027_HoaDon_x0027_>";   

                cnn.Create(filePath, hoaDonData);
                
                createBillDetail(billCode, shoeCode, quantity, unitPrice);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo hóa đơn: {ex.Message}");
            }
        }

        public bool checkDuplicatesProduct(string billCode, string shoeCode)
        {
            try
            {
                DataTable dt = cnn.showTable("ChiTietHoaDon.xml");
                dt.DefaultView.RowFilter = $"mahoadon = '{billCode}' AND magiay = '{shoeCode}'";
                return dt.DefaultView.Count == 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi kiểm tra sản phẩm trùng lặp: {ex.Message}");
                return false; 
            }
        }

        public decimal searchTotalCost(string billCode)
        {
            decimal totalCost = 0;
            string billCodeTemp;
            xDoc = XDocument.Load(filePath);
            var list = xDoc.Descendants("_x0027_HoaDon_x0027_");
            foreach (var node in list)
            {
                billCodeTemp = node.Element("mahoadon")?.Value; 
                if (billCode == billCodeTemp)
                {
                    totalCost = decimal.Parse(node.Element("tongtien")?.Value ?? "0");
                    break; 
                }
            }
            return totalCost;
        }//other

        public void updateTotalCost(string billCode, int quantity, decimal unitPrice)
        {
            decimal total = (quantity * unitPrice) + searchTotalCost(billCode);
            xDoc = XDocument.Load(filePath);
            var node = xDoc.Descendants("_x0027_HoaDon_x0027_")
                .FirstOrDefault(x => x.Element("mahoadon")?.Value == billCode);
            if (node != null)
            {
                node.Element("tongtien").Value = total.ToString("F2");  
                xDoc.Save(filePath);
            }
        }

        public void updateQuantityRest(string shoeCode, int quantity)
        {
            try
            {
                int quantityRest = ThemHoaDon.quantityRest - quantity;
                xmlDoc.Load(Path.Combine(Application.StartupPath, "Giay.xml"));
                XmlNode node = xmlDoc.SelectSingleNode("NewDataSet/_x0027_Giay_x0027_[magiay = '" + shoeCode + "']");
                if (node != null) 
                {
                    node.ChildNodes[4].InnerText = quantityRest.ToString();
                    xmlDoc.Save(Path.Combine(Application.StartupPath, "Giay.xml"));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật số lượng tồn: {ex.Message}");
            }
        }

        public void deleteHoaDon(string billCode)
        {
            try
            {
                // 1. Xóa trong file HoaDon.xml
                string pathHD = Path.Combine(Application.StartupPath, "HoaDon.xml");
                if (File.Exists(pathHD))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(pathHD);

                    // Tìm node hóa đơn có mã tương ứng
                    // Lưu ý: Cấu trúc XPath phụ thuộc vào cách DataSet ghi file, thường là NewDataSet/_x0027_HoaDon_x0027_
                    XmlNode node = doc.SelectSingleNode($"NewDataSet/_x0027_HoaDon_x0027_[mahoadon = '{billCode}']");

                    if (node != null)
                    {
                        node.ParentNode.RemoveChild(node);
                        doc.Save(pathHD);
                    }
                }

                // 2. Xóa các chi tiết liên quan trong ChiTietHoaDon.xml (Cascade Delete)
                string pathCT = Path.Combine(Application.StartupPath, "ChiTietHoaDon.xml");
                if (File.Exists(pathCT))
                {
                    XmlDocument docCT = new XmlDocument();
                    docCT.Load(pathCT);

                    // Tìm tất cả các dòng chi tiết có mã hóa đơn này
                    XmlNodeList listNodes = docCT.SelectNodes($"NewDataSet/_x0027_ChiTietHoaDon_x0027_[mahoadon = '{billCode}']");

                    if (listNodes != null && listNodes.Count > 0)
                    {
                        foreach (XmlNode n in listNodes)
                        {
                            n.ParentNode.RemoveChild(n);
                        }
                        docCT.Save(pathCT);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa hóa đơn: " + ex.Message);
            }
        }
    }   
}
