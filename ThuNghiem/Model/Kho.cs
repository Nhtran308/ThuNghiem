using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuNghiem.Model
{
    internal class Kho
    {
        private String maKho;
        private String tenKho;
        private String diaChiKho;
        public Kho(string maKho, string tenKho, string diaChiKho)
        {
            this.maKho = maKho;
            this.tenKho = tenKho;
            this.diaChiKho = diaChiKho;
        }

        public Kho()
        {
        }

        public string getMaKho() { return maKho; }
        public void setMaKho(String maKho) { this.maKho = maKho; }
        public string getTenKho() { return tenKho; }
        public void setTenKho(String tenKho) { this.tenKho = tenKho; }
        public string getDiaChiKho() { return diaChiKho; }
        public void setDiaChiKho(String diaChiKho) { this.diaChiKho = diaChiKho; }
    }
}
