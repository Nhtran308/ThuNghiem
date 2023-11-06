using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuNghiem.Control;
using ThuNghiem.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ThuNghiem.View
{
    public partial class frmMenu : Form
    {
        HangHoaController hhcontroller;
        List<HangHoa> dsHangHoa;
        public frmMenu()
        {
            InitializeComponent();
            hhcontroller = new HangHoaController();
        }

        private void thêmPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKho frmKho = new frmKho();
            frmKho.btnLoad_Click(sender, e);
            this.Hide();
            frmKho.ShowDialog();
        }

        private void chiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frmPhieuNhap = new frmPhieuNhap();
            HangHoaController hhController = new HangHoaController();
            List<HangHoa> hh = hhcontroller.Combobox();
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            foreach (HangHoa h in hh)
            {
                string row = h.getTenHangHoa();
                combo.Items.Add(row);
            }
            combo.Name = "Tên Hàng Hóa";
            frmPhieuNhap.dgvPhieuNhap.Columns.Insert(1, combo);
            this.Hide();
            frmPhieuNhap.ShowDialog();
        }

        private void hangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa frmHangHoa = new frmHangHoa();
            this.Hide();
            frmHangHoa.btnLoadHH_Click(sender, e);
            frmHangHoa.ShowDialog();
        }
    }
}
