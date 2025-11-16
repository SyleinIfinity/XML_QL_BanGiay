using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BTL_XML_QL_BanGiay.Models
{
    internal class NhanVienModel
    {
        Connect file = new Connect();

        public bool checkStaffCode(string staffCode)
        {
            try
            {
      
                XmlTextReader reader = new XmlTextReader("NhanVien.xml");
                DataSet ds = new DataSet();
                ds.ReadXml(reader);
                reader.Close();

         
                DataTable dt = ds.Tables[0];  
                DataRow[] foundRows = dt.Select("manhanvien = '" + staffCode + "'");
        
                return foundRows.Length > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra mã nhân viên: " + ex.Message);
                return false;
            }
        }

        public void createStaff(string staffCode, string fullName, string address, string phoneNumber, string email)
        {
            try
            {              
                XmlDocument xmlDoc = new XmlDocument();

                if (File.Exists("NhanVien.xml"))
                {
                    xmlDoc.Load("NhanVien.xml");
                }
                else
                {
                    XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlElement root = xmlDoc.CreateElement("_x0027_NhanVien_x0027_");
                    xmlDoc.AppendChild(root);
                }

                XmlElement staffElement = xmlDoc.CreateElement("_x0027_NhanVien_x0027_");

                XmlElement manhanvienElement = xmlDoc.CreateElement("manhanvien");
                manhanvienElement.InnerText = staffCode;
                staffElement.AppendChild(manhanvienElement);

                XmlElement tennhanvienElement = xmlDoc.CreateElement("hoten");
                tennhanvienElement.InnerText = fullName;
                staffElement.AppendChild(tennhanvienElement);

                XmlElement diachiElement = xmlDoc.CreateElement("diachi");
                diachiElement.InnerText = address;
                staffElement.AppendChild(diachiElement);

                XmlElement sdtElement = xmlDoc.CreateElement("sdt");
                sdtElement.InnerText = phoneNumber;
                staffElement.AppendChild(sdtElement);

                XmlElement emailElement = xmlDoc.CreateElement("email");
                emailElement.InnerText = email;
                staffElement.AppendChild(emailElement);

                xmlDoc.DocumentElement.AppendChild(staffElement);

                xmlDoc.Save("NhanVien.xml");
         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }

        public void updateStaff(string staffCode, string fullName, string address, string phoneNumber, string email)
        {
            string data = "<manhanvien>" + staffCode + "</manhanvien>" +
                "<hoten>" + fullName + "</hoten>" +
                "<diachi>" + address + "</diachi>" +
                "<sdt>" + phoneNumber + "</sdt>" +
                "<email>" + email + "</email>";
            file.Update("NhanVien.xml", "_x0027_NhanVien_x0027_", "manhanvien", staffCode, data);
        }

        public void deleteStaff(string staffCode)
        {
            file.Delete("NhanVien.xml", "_x0027_NhanVien_x0027_", "manhanvien", staffCode);
        }

        public bool checkEmpty(string staffCode, string fullName, string address, string phoneNumber, string email)
        {
            if (string.IsNullOrEmpty(staffCode) || string.IsNullOrEmpty(fullName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
