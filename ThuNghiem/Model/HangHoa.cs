using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuNghiem.Model
{
    internal class HangHoa
    {
        private string maHangHoa;
        private string tenHangHoa;
        private string donViTinh;
        private int soLuong;
        private float donGia;
        private float thanhTien;

        public HangHoa(string maHangHoa, string tenHangHoa, string donViTinh, int soLuong, float donGia, float thanhTien )
        {
            this.maHangHoa = maHangHoa;
            this.tenHangHoa = tenHangHoa;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }

        public HangHoa(string maHangHoa, string tenHangHoa, string donViTinh, int soLuong, float donGia)
        {
            this.maHangHoa = maHangHoa;
            this.tenHangHoa = tenHangHoa;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public HangHoa(string maHangHoa, string donViTinh, int soLuong, float donGia, float thanhTien)
        {
            this.maHangHoa = maHangHoa;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }

        public HangHoa(string tenHangHoa)
        {
            this.tenHangHoa= tenHangHoa;
        }

        public HangHoa() 
        { 
        }

       

        public string getMaHangHoa() { return maHangHoa; }
        public void setMaHangHoa(String maHangHoa) { this.maHangHoa = maHangHoa; }

        public string getTenHangHoa() { return tenHangHoa; }
        public void setTenHangHoa(string tenHangHoa) { this.tenHangHoa = tenHangHoa; }

        public string getDonViTinh() {  return donViTinh; }
        public void setDonViTinh(string donViTinh) { this.donViTinh= donViTinh; }

        public int getSoLuong() { return soLuong; }
        public void setSoLuong(int soLuong) { this.soLuong = soLuong; }

        public float getDonGia() {  return donGia; }
        public void setDonGia(float donGia) { this.donGia = donGia; }

        public float getThanhTien() { return thanhTien; }
        public void setThanhTien(float thanhTien) { this.thanhTien = thanhTien; }
    }
}
