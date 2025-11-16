using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BTL_XML_QL_BanGiay.Models
{
    internal class TaiKhoanModel
    {
        Connect cnn = new Connect();
        string filePath = "TaiKhoan.xml";

        public bool checkStaffCode(string staffCode)
        {

            try
            {      
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath); 

                string xpath = $"/NewDataSet/_x0027_TaiKhoan_x0027_[manhanvien='{staffCode}']";
                XmlNode node = doc.SelectSingleNode(xpath);
    
                return node != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra mã nhân viên: " + ex.Message);
                return false;
            }
        }

        public void createAccount(string staffCode, string passWord, bool authority)
        {
            string data = "<_x0027_TaiKhoan_x0027_>" +
                    "<manhanvien>" + staffCode + "</manhanvien>" +
                    "<matkhau>" + passWord + "</matkhau>" +
                    "<quyen>" + authority.ToString().ToLower() + "</quyen>" +
                    "</_x0027_TaiKhoan_x0027_>";
            cnn.Create("TaiKhoan.xml", data);
        }

        public void updateAccount(string staffCode, string passWord, bool authority)
        {
            string data = "<manhanvien>" + staffCode + "</manhanvien>" +
                    "<matkhau>" + passWord + "</matkhau>" +
                    "<quyen>" + authority.ToString().ToLower() + "</quyen>";
            cnn.Update("TaiKhoan.xml", "_x0027_TaiKhoan_x0027_", "manhanvien", staffCode, data);
        }

        internal void deleteAccount(string staffCode)
        {
            cnn.Delete("TaiKhoan.xml", "_x0027_TaiKhoan_x0027_", "manhanvien", staffCode);
        }

        public bool checkPassword(string staffCode, string passWordOld)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);

                if (ds.Tables.Count > 0)
                {                
                    DataTable dt = ds.Tables[0];

                    DataRow[] rows = dt.Select($"manhanvien = '{staffCode}' AND matKhau = '{passWordOld}'");

                    return rows.Length > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi kiểm tra mật khẩu: {ex.Message}");
            }
            return false;
        }
    }
}
