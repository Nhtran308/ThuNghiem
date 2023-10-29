using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using ThuNghiem.Model;
using ThuNghiem.Utils;
using ThuNghiem.View;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThuNghiem.Control
{
    internal class KhoController
    {
        List<Kho> khoList;
        public KhoController() 
        { 
        khoList = new List<Kho>();
        }

        public List<Kho> Load()
        {
            khoList.Clear();
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kho", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string maKho = reader["MaKho"].ToString();
                    string tenKho = reader["TenKho"].ToString();
                    string diaChiKho = reader["DiaChiKho"].ToString();
                    Kho kho = new Kho(maKho, tenKho, diaChiKho);
                    khoList.Add(kho);
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
            return khoList;
        }

        public bool Insert(Kho kho)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Kho(MaKho, TenKho, DiaChiKho) VALUES('" + kho.getMaKho() + "',N'" + kho.getTenKho() + "',N'" + kho.getDiaChiKho() + "');", conn);
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

        public bool Edit(Kho kho)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Kho SET TenKho = N'" + kho.getTenKho() + "', DiaChiKho = N'"
                    + kho.getDiaChiKho() + "' WHERE MaKho = '" + kho.getMaKho() + "';", conn);
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

        public bool Delete(Kho kho)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Kho WHERE MaKho = '" + kho.getMaKho() + "';", conn);
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

        public List<Kho> Find(Kho kho)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                khoList.Clear();
                int count = 0;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kho WHERE MaKho = '" + kho.getMaKho() + "';", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string maKho = reader["MaKho"].ToString();
                    string tenKho = reader["TenKho"].ToString();
                    string diaChiKho = reader["DiaChiKho"].ToString();
                    kho = new Kho(maKho, tenKho, diaChiKho);
                    khoList.Add(kho);
                    count++;
                }
               
                if(count > 0)
                {
                    return khoList;
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
            return khoList;
        }
    }
}
