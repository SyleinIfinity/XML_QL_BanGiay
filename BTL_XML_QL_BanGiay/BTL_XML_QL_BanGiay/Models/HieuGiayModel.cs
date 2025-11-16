using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BTL_XML_QL_BanGiay.Models
{
    internal class HieuGiayModel
    {
        Connect cnn = new Connect();
        string filePath = "HieuGiay.xml";

        public bool checkShoeBrandCode(string shoeBrandCode)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                string xpath = $"/NewDataSet/_x0027_HieuGiay_x0027_[mahieugiay='{shoeBrandCode}']";
                XmlNode node = doc.SelectSingleNode(xpath);

                return node != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra mã hiệu giày: " + ex.Message);
                return false;
            }
        }

        public void deleteShoeBrand(string shoeBrandCode)
        {
            cnn.Delete(filePath, "_x0027_HieuGiay_x0027_", "mahieugiay", shoeBrandCode);
        }

        public void updateShoeBrand(string shoeBrandCode, string nameShoeBrand)
        {
            string data = "_x0027_HieuGiay_x0027_" +
                "<mahieugiay>" + shoeBrandCode + "</mahieugiay>" +
               "<tenhieugiay>" + nameShoeBrand + "</tenhieugiay>";
            cnn.Update(filePath, "_x0027_HieuGiay_x0027_", "mahieugiay", shoeBrandCode, data);
        }

        public void createShoeBrand(string shoeBrandCode, string nameShoeBrand)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                XmlElement newCategory = doc.CreateElement("_x0027_HieuGiay_x0027_");
                XmlElement codeElement = doc.CreateElement("mahieugiay");
                codeElement.InnerText = shoeBrandCode;
                XmlElement nameElement = doc.CreateElement("tenhieugiay");
                nameElement.InnerText = nameShoeBrand;

                newCategory.AppendChild(codeElement);
                newCategory.AppendChild(nameElement);

                doc.DocumentElement.AppendChild(newCategory);

                doc.Save(filePath);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm danh mục: " + ex.Message);
            }
        }
    }
}
