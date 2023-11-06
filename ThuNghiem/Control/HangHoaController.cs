using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuNghiem.Model;
using ThuNghiem.Utils;

namespace ThuNghiem.Control
{
   
    internal class HangHoaController
    {
        List<HangHoa> dsHangHoa;

        public HangHoaController()
        {
            dsHangHoa = new List<HangHoa>();
        }

        public List<HangHoa> Combobox()
        {
            dsHangHoa.Clear();
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TenHangHoa FROM HangHoa", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tenHangHoa = reader["TenHangHoa"].ToString();
                    HangHoa hangHoa = new HangHoa(tenHangHoa);
                    dsHangHoa.Add(hangHoa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiển thị không thành công", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return dsHangHoa;
        }
    }
}
