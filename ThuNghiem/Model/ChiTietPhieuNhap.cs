using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuNghiem.Model
{
    internal class ChiTietPhieuNhap
    {
        private string maPhieu;
        private string maHang;
        private string tenHang;
        private string donViTinh;
        private int soLuong;
        private float donGia;

        public ChiTietPhieuNhap() 
        { 

        }

        public ChiTietPhieuNhap(string maPhieu, string maHang, string tenHang, string donViTinh, int soLuong, float donGia)
        {
            this.maPhieu = maPhieu;
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public string getMaPhieu() { return maPhieu; }
        public void setMaPhieu(string maPhieu) { this.maPhieu = maPhieu; }

        public string getMaHang() { return maHang; }
        public void setMaHang(string maHang) { this.maHang = maHang; }

        public string getTenHang() { return tenHang; }
        public void setTenHang(string tenHang) { this.tenHang = tenHang; }

        public int getSoLuong() { return soLuong; }
        public void setSoLuong(int soLuong) { this.soLuong = soLuong; }

        public float getDonGia() { return donGia; }
        public void setDonGia(float donGia) { this.donGia = donGia; }
    }
}
