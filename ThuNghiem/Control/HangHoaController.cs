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
        public List<HangHoa> Load()
        {
            dsHangHoa.Clear();
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HangHoa", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maHangHoa = reader["MaHangHoa"].ToString();
                    string tenHangHoa = reader["TenHangHoa"].ToString();
                    string donViTinh = reader["DonViTinh"].ToString();
                    int soLuong = (int)reader["SoLuong"];
                    float donGia = float.Parse(reader["DonGia"].ToString());
                    HangHoa hh = new HangHoa(maHangHoa, tenHangHoa, donViTinh, soLuong, donGia);
                    dsHangHoa.Add(hh);
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

        public bool Insert(HangHoa hh)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO HangHoa(MaHangHoa, TenhangHoa, DonViTinh, SoLuong, DonGia) VALUES('" + hh.getMaHangHoa() + "',N'" + hh.getTenHangHoa() + "',N'" + hh.getDonViTinh() + "','" +hh.getSoLuong() + "','" +hh.getDonGia() +"');", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin bị trùng hoặc không đúng", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool Edit(HangHoa hh)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE HangHoa SET TenHangHoa = N'" + hh.getTenHangHoa() + "', DonViTinh = N'"
                    + hh.getDonViTinh() + "', SoLuong = " + hh.getSoLuong() + ", DonGia = '" + hh.getDonGia() +"' WHERE MaHangHoa = '" + hh.getMaHangHoa() + "';", conn);
                if (MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool Delete(HangHoa hh)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM HangHoa WHERE MaHangHoa = '" + hh.getMaHangHoa() + "';", conn);
                if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);

                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public List<HangHoa> Find(HangHoa hh)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                dsHangHoa.Clear();
                int count = 0;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HangHoa WHERE MaHangHoa = '" + hh.getMaHangHoa() + "';", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maHangHoa = reader["MaHangHoa"].ToString();
                    string tenHangHoa = reader["TenHangHoa"].ToString();
                    string donViTinh = reader["DonViTinh"].ToString();
                    int soLuong = (int)reader["SoLuong"];
                    float donGia = float.Parse(reader["DonGia"].ToString());
                    hh = new HangHoa(maHangHoa, tenHangHoa, donViTinh, soLuong, donGia);
                    dsHangHoa.Add(hh);
                    count++;
                }

                if (count > 0)
                {
                    return dsHangHoa;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!!!", "Thông báo!", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return dsHangHoa;
        }
    }
}
