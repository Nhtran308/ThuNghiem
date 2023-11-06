using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ThuNghiem.Model
{
    internal class PhieuNhap
    {
        private string maPhieu;
        private string soHoaDon;
        private string maKho;
        private DateTime ngayNhapKho;
        private DateTime ngayHoaDon;
        private string nguoiGiaoHang;
        private string donViPhatHanh;

        public PhieuNhap(string maPhieu, string soHoaDon, string maKho, DateTime ngayNhapKho, DateTime ngayHoaDon, string nguoiGiaoHang, string donViPhatHanh)
        {
            this.maPhieu = maPhieu;
            this.soHoaDon = soHoaDon;
            this.maKho = maKho;
            this.ngayNhapKho = ngayNhapKho;
            this.ngayHoaDon = ngayHoaDon;
            this.nguoiGiaoHang = nguoiGiaoHang;
            this.donViPhatHanh = donViPhatHanh;
        }

        public PhieuNhap()
        {
        }

        public string getMaPhieu() { return maPhieu; }
        public void setMaPhieu(string maPhieu) { this.maPhieu = maPhieu; }

        public string getSoHoaDon() { return soHoaDon; }
        public void setSoHoaDon(string soHoaDon) { this.soHoaDon = soHoaDon; }

        public string getMaKho() { return maKho; }
        public void setMaKho(string maKho) { this.maKho = maKho; }

        public DateTime getNgayNhapKho() { return ngayNhapKho; }
        public void setNgayNhapKho(DateTime ngayNhapKho) { this.ngayNhapKho = ngayNhapKho; }

        public DateTime getNgayHoaDon() { return ngayHoaDon; }
        public void setNgayHoaDon(DateTime ngayHoaDon) { this.ngayHoaDon = ngayHoaDon; }

        public string getNguoiGiaoHang() { return nguoiGiaoHang; }
        public void setNguoiGiaoHang(string nguoiGiaoHang) { this.nguoiGiaoHang = nguoiGiaoHang; }

        public string getDonViPhatHanh() { return donViPhatHanh; }
        public void setDonViPhatHanh(string donViPhatHanh) { this.donViPhatHanh = donViPhatHanh; }
    }
}
