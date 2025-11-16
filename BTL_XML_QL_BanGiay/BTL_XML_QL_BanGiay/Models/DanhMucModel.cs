using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BTL_XML_QL_BanGiay.Models
{
    internal class DanhMucModel
    {
        Connect cnn = new Connect();
        string filePath = "DanhMuc.xml";

        public bool checkCategoryCode(string categoryCode)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                string xpath = $"/NewDataSet/_x0027_DanhMuc_x0027_[madanhmuc='{categoryCode}']";
                XmlNode node = doc.SelectSingleNode(xpath);

                return node != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra mã danh mục: " + ex.Message);
                return false;
            }
        }


        public bool checkEmpty(string shoeBrandCode, string shoeBrandName)
        {
            if(string.IsNullOrEmpty(shoeBrandCode) || string.IsNullOrEmpty(shoeBrandName))
            {
                return false;
            }
            return true;
        }

        public void createCategory(string categoryCode, string nameCategory)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);
               
                XmlElement newCategory = doc.CreateElement("_x0027_DanhMuc_x0027_");
                XmlElement codeElement = doc.CreateElement("madanhmuc");
                codeElement.InnerText = categoryCode;
                XmlElement nameElement = doc.CreateElement("tendanhmuc");
                nameElement.InnerText = nameCategory;

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

        public void updateCategory(string categoryCode, string nameCategory)
        {
            string data = "_x0027_DanhMuc_x0027_" +
                "<madanhmuc>" + categoryCode + "</madanhmuc>" +
               "<tendanhmuc>" + nameCategory + "</tendanhmuc>";
            cnn.Update(filePath, "_x0027_DanhMuc_x0027_", "madanhmuc", categoryCode, data);
        }

        public void deleteCategory(string categoryCode)
        {
            cnn.Delete(filePath, "_x0027_DanhMuc_x0027_", "madanhmuc", categoryCode);
        }
    }
}
