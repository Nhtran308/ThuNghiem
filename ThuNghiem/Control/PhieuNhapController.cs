using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ThuNghiem.Model;
using ThuNghiem.Utils;
using ThuNghiem.View;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;


namespace ThuNghiem.Control
{
    internal class PhieuNhapController
    {
        List<PhieuNhap> dsPhieuNhap;
        List<ChiTietPhieuNhap> dsCTPN;

        public PhieuNhapController()
        {
            dsPhieuNhap = new List<PhieuNhap>();
            dsCTPN = new List<ChiTietPhieuNhap>();
        }

        public List<PhieuNhap> Load()
        {
            dsPhieuNhap.Clear();
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuNhap", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maPhieu = reader["MaPhieuNhap"].ToString();
                    string soHoaDon = reader["SoHoaDon"].ToString();
                    string maKho = reader["MaKho"].ToString();
                    DateTime ngayNhapKho = (DateTime)reader["NgayNhapKho"];
                    DateTime ngayHoaDon = (DateTime)reader["NgayHoaDon"];
                    string nguoiGiaoHang = reader["NguoiGiaoHang"].ToString();
                    string donViPhatHanh = reader["DonViPhatHanh"].ToString();
                    PhieuNhap phieuNhap = new PhieuNhap( maPhieu, soHoaDon, maKho, ngayNhapKho, ngayHoaDon, nguoiGiaoHang, donViPhatHanh );
                    dsPhieuNhap.Add(phieuNhap);
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
            return dsPhieuNhap;
        }

        public bool Insert(ChiTietPhieuNhap ctpn)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("", conn);
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
    }
}
