using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Text;

namespace BTL_XML_QL_BanGiay.Models
{
    internal class Connect
    {
        string cnn = "Data Source=SYLEIN\\PHANVANKHANH;Initial Catalog=db_BTL_XML_QL_BanGiay;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public DataTable showTable(string filePath)
        {         
            DataTable dt = new DataTable();
            string FilePath = Application.StartupPath + "\\" + filePath;
            if (File.Exists(FilePath))
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(FilePath);
                    XmlReader reader = new XmlNodeReader(doc);
                    dt.ReadXml(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi đọc file XML: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File XML '" + filePath + "' không tồn tại");
            }
            return dt;
        }

        public void createXML(string table)
        {
            
            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();
            string sql = "Select * from " + table;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable("'" + table + "'");
            adapter.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\" + table + ".xml", XmlWriteMode.WriteSchema);
        }

        public string getValue(string path, string A, string valueA, string B)
        {
            string valueB = "";
            DataTable dt = new DataTable();
            dt = showTable(path);
            int p = dt.Rows.Count;
            for (int i = 0; i < p; i++)
            {
                if (dt.Rows[i][A].ToString().Trim().Equals(valueA))
                {
                    valueB = dt.Rows[i][B].ToString();
                    return valueB;
                }
            }
            return valueB;
        }

        public void Create(string path, string data) 
        {
            string fullPath = Application.StartupPath + "\\" + path;
            XmlTextReader reader = new XmlTextReader(fullPath);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();

            try {
                XmlDocumentFragment docFrag = doc.CreateDocumentFragment();
                docFrag.InnerXml = data;
                
                XmlElement root = doc.DocumentElement;
                root.AppendChild(docFrag);
                
                doc.Save(fullPath);
            }
            catch (XmlException ex) {
                MessageBox.Show("Lỗi XML: " + ex.Message + "\nDữ liệu không hợp lệ: " + data);
            }
        }

        public void Update(string path, string fileName, string updateDataField, string fieldValue, string data)
        {
            XmlTextReader reader = new XmlTextReader(path);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();
            XmlNode oldHang;
            XmlElement root = doc.DocumentElement;
            oldHang = root.SelectSingleNode("/NewDataSet/" + fileName + "[" + updateDataField + " ='" + fieldValue + "']");
            XmlElement newhang = doc.CreateElement(fileName);
            newhang.InnerXml = data;
            root.ReplaceChild(newhang, oldHang);
            doc.Save(path);
        }

        public void Delete(string path, string fileName, string deleteDataField, string fieldValue) 
        {
            string fName = Application.StartupPath + "\\" + path;
            XmlDocument r = new XmlDocument();
            r.Load(fName);
            XmlNode nodeOld = r.SelectSingleNode("NewDataSet/" + fileName + "[" + deleteDataField + "='" + fieldValue + "']");
            r.DocumentElement.RemoveChild(nodeOld);
            r.Save(fName);
        }

        public void InsertOrUpDateSQL(string sql)
        {
            SqlConnection con = new SqlConnection(cnn);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ConvertXMLtoSQL()
        {
            try
            {
                InsertOrUpDateSQL("DELETE FROM ChiTietHoaDon");
                InsertOrUpDateSQL("DELETE FROM ChiTietDanhMucGiay"); 
                InsertOrUpDateSQL("DELETE FROM HoaDon");
                InsertOrUpDateSQL("DELETE FROM Giay");
                InsertOrUpDateSQL("DELETE FROM HieuGiay");
                InsertOrUpDateSQL("DELETE FROM DanhMuc");
                InsertOrUpDateSQL("DELETE FROM TaiKhoan");
                InsertOrUpDateSQL("DELETE FROM NhanVien");

                string[] tables = {
                    "NhanVien",     
                    "TaiKhoan",    
                    "HieuGiay",     
                    "DanhMuc",     
                    "Giay",       
                    "ChiTietDanhMucGiay", 
                    "HoaDon",       
                    "ChiTietHoaDon" 
                };

                foreach(string table in tables)
                {
                    UpdateTableFromXML(table);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi chuyển đổi XML sang SQL: {ex.Message}");
            }
        }

        private void UpdateTableFromXML(string tableName)
        {
            string filePath = tableName + ".xml";
            DataTable dt = showTable(filePath);
            
            foreach(DataRow row in dt.Rows)
            {
                StringBuilder sql = new StringBuilder($"INSERT INTO {tableName} VALUES(");
                for (int i = 0; i < dt.Columns.Count - 1; i++)
                {
                    sql.Append($"N'{row[i].ToString().Trim().Replace("'","''")}',");
                }
                sql.Append($"N'{row[dt.Columns.Count - 1].ToString().Trim().Replace("'","''")}')");

                InsertOrUpDateSQL(sql.ToString());
            }
        }

        public void ConvertSQLtoXML()
        {
            try
            {
                string[] tables = {
                    "NhanVien", "TaiKhoan", "HieuGiay", "DanhMuc",
                    "Giay", "HoaDon", "ChiTietDanhMucGiay", "ChiTietHoaDon"
                };

                foreach (string table in tables)
                {
                    createXML(table);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi chuyển đổi SQL sang XML: {ex.Message}");
            }
        }
        
    }
}
