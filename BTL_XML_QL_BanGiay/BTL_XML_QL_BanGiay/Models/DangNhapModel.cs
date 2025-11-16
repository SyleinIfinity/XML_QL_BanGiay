using BTL_XML_QL_BanGiay.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace BTL_XML_QL_BanGiay.Models
{
    internal class DangNhapModel
    {
        Connect cnn = new Connect();

        public bool checkLogin(string filePath, string staffCode, string password) 
        {
            try
            {
                XDocument xDoc = XDocument.Load(filePath);
                var user = xDoc.Descendants("_x0027_TaiKhoan_x0027_")
                    .FirstOrDefault(x => x.Element("manhanvien")?.Value == staffCode &&
                                         x.Element("matkhau")?.Value == password);

                return user != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi kiểm tra đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool getRole(string filePath, string staffCode)
        {
            try
            {
                XDocument doc = XDocument.Load(filePath);

                var account = doc.Descendants("_x0027_TaiKhoan_x0027_")
                                 .FirstOrDefault(x => x.Element("manhanvien").Value == staffCode);

                if (account != null)
                {
                    return bool.Parse(account.Element("quyen").Value);
                }

                return false; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy quyền: {ex.Message}");
                return false;
            }
        }

        public string getStaffName(string filePath, string staffCode)
        {
            try 
            {
                var xmlDoc = XDocument.Load("NhanVien.xml");
                var staff = xmlDoc.Descendants("_x0027_NhanVien_x0027_")
                                  .FirstOrDefault(x => x.Element("manhanvien")?.Value == staffCode);
                
                if (staff == null)
                {
                    MessageBox.Show($"Không tìm thấy thông tin nhân viên với mã {staffCode}");
                    return staffCode;
                }
                
                return staff.Element("hoten")?.Value ?? staffCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy tên nhân viên: {ex.Message}");
                return staffCode;
            }
        }

    }
}
