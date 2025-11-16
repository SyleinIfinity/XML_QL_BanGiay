using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_XML_QL_BanGiay.Models
{
    internal class GiayModel
    {
        Connect file = new Connect();


        public bool checkShoeCode(string staffCode)
        {
            try
            {

                XmlTextReader reader = new XmlTextReader("Giay.xml");
                DataSet ds = new DataSet();
                ds.ReadXml(reader);
                reader.Close();


                DataTable dt = ds.Tables[0];
                DataRow[] foundRows = dt.Select("magiay = '" + staffCode + "'");

                return foundRows.Length > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra mã giày: " + ex.Message);
                return false;
            }
        }

        public bool checkEmpty(string shoeCode, string brandShoeCode, string nameShoe, string size, string color , string unitPrice, string quantity)
        {
            if (string.IsNullOrEmpty(shoeCode) || string.IsNullOrEmpty(brandShoeCode) || string.IsNullOrEmpty(nameShoe) || string.IsNullOrEmpty(size) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(unitPrice) || string.IsNullOrEmpty(quantity))
            {
                return false;
            }
            return true;
        }

        public bool checkExistence(string shoeCode)
        {
            XmlTextReader r = new XmlTextReader("Giay.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(r);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "magiay";
            r.Close();
            int index = dv.Find(shoeCode);
            if (index == -1)
            {
                return false;
            }
            return true;
        }

        public void createShoe(string shoeCode, string shoeBrandCode, string nameShoe, string size, string color, string unitPrice, string quantity)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Giay.xml");

                XmlElement newShoe = doc.CreateElement("_x0027_Giay_x0027_");
                XmlElement codeElement = doc.CreateElement("magiay");
                codeElement.InnerText = shoeCode;
                XmlElement brandElement = doc.CreateElement("mahieugiay");
                brandElement.InnerText = shoeBrandCode;
                XmlElement nameElement = doc.CreateElement("tengiay");
                nameElement.InnerText = nameShoe;
                XmlElement sizeElement = doc.CreateElement("size");
                sizeElement.InnerText = size;
                XmlElement colorElement = doc.CreateElement("mau");
                colorElement.InnerText = color;
                XmlElement priceElement = doc.CreateElement("dongia");
                priceElement.InnerText = unitPrice;
                XmlElement quantityElement = doc.CreateElement("soluong");
                quantityElement.InnerText = quantity;

                newShoe.AppendChild(codeElement);
                newShoe.AppendChild(brandElement);
                newShoe.AppendChild(nameElement);
                newShoe.AppendChild(sizeElement);
                newShoe.AppendChild(colorElement);
                newShoe.AppendChild(priceElement);
                newShoe.AppendChild(quantityElement);

                doc.DocumentElement.AppendChild(newShoe);

                doc.Save("Giay.xml");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm giày: " + ex.Message);
            }
        }

        public void updateShoe(string shoeCode, string shoeBrandCode, string nameShoe, string size, string color, string unitPrice, string quantity)
        {
            string data = "_x0027_Giay_x0027_" +
                "<magiay>" + shoeCode + "</magiay>" +
               "<mahieugiay>" + shoeBrandCode + "</mahieugiay>" +
               "<tengiay>" + nameShoe + "</tengiay>" +
               "<size>" + size + "</size>" +
               "<mau>" + color + "</mau>" +
               "<dongia>" + unitPrice + "</dongia>" +
               "<soluong>" + quantity + "</soluong>";
            file.Update("Giay.xml", "_x0027_Giay_x0027_", "magiay", shoeCode, data);
        }

        public void deleteShoe(string shoeCode)
        {
            file.Delete("Giay.xml", "_x0027_Giay_x0027_", "magiay", shoeCode);
        }

        public DataTable loadShoeCode() 
        {
            DataTable data = new DataTable();
            data = file.showTable("Giay.xml");
            return data;
        }
    }
}
