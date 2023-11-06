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

namespace ThuNghiem.View
{
    public partial class frmHangHoa : Form
    {
        HangHoaController hhcontroller;
        List<HangHoa> dsHangHoa;
        HangHoa currentHangHoa;

        public frmHangHoa()
        {
            InitializeComponent();
            hhcontroller = new HangHoaController();
        }

        public void btnLoadHH_Click(object sender, EventArgs e)
        {
            dgvHangHoa.Rows.Clear();
            dsHangHoa = hhcontroller.Load();
            foreach (HangHoa hh in dsHangHoa)
            {
                string[] row = { hh.getMaHangHoa(), hh.getTenHangHoa(), hh.getDonViTinh(), hh.getSoLuong().ToString(), hh.getDonGia().ToString() };
                dgvHangHoa.Rows.Add(row);
            }
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dgvHangHoa.Rows[e.RowIndex];
                txtMaHangHoa.Text = row.Cells[0].Value.ToString();
                txtTenHangHoa.Text = row.Cells[1].Value.ToString();
                txtDonViTinh.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                txtDonGia.Text = row.Cells[4].Value.ToString();

                dgvHangHoa.ReadOnly = true;
            }

        }

        private void btnAddHH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHangHoa.Text)
                || string.IsNullOrEmpty(txtTenHangHoa.Text)
                || string.IsNullOrEmpty(txtDonViTinh.Text)
                || string.IsNullOrEmpty(txtSoLuong.Text)
                || string.IsNullOrEmpty(txtDonGia.Text)
                || txtMaHangHoa.Text == ""
                || txtTenHangHoa.Text == ""
                || txtDonViTinh.Text == ""
                || txtSoLuong.Text == ""
                || txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtMaHangHoa.Focus();
                return;
            }
            HangHoa hh = new HangHoa();
            hh.setMaHangHoa(txtMaHangHoa.Text);
            hh.setTenHangHoa(txtTenHangHoa.Text);
            hh.setDonViTinh(txtDonViTinh.Text);
            hh.setSoLuong(int.Parse(txtSoLuong.Text));
            hh.setDonGia(float.Parse(txtDonGia.Text));
            hhcontroller.Insert(hh);
            btnLoadHH_Click(sender, e);
        }

        private void btnEditHH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHangHoa.Text)
                || string.IsNullOrEmpty(txtTenHangHoa.Text)
                || string.IsNullOrEmpty(txtDonViTinh.Text)
                || string.IsNullOrEmpty(txtSoLuong.Text)
                || string.IsNullOrEmpty(txtDonGia.Text)
                || txtMaHangHoa.Text == ""
                || txtTenHangHoa.Text == ""
                || txtDonViTinh.Text == ""
                || txtSoLuong.Text == ""
                || txtDonGia.Text == "")
            {
                MessageBox.Show("Không có thông tin để sửa");
                txtMaHangHoa.Focus();
                return;
            }
            HangHoa hh = new HangHoa();
            hh.setTenHangHoa(txtTenHangHoa.Text);
            hh.setDonViTinh(txtDonViTinh.Text);
            hh.setSoLuong(int.Parse(txtSoLuong.Text));
            hh.setDonGia(float.Parse(txtDonGia.Text));
            hh.setMaHangHoa(txtMaHangHoa.Text);
            hhcontroller.Edit(hh);
            btnLoadHH_Click(sender, e);
        }

        private void btnDeleteHH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHangHoa.Text))
            {
                MessageBox.Show("Không thể xóa");
                return;
            }
            HangHoa hh = new HangHoa();
            hh.setMaHangHoa(txtMaHangHoa.Text);
            hhcontroller.Delete(hh);
            txtMaHangHoa.Clear();
            txtTenHangHoa.Clear();
            txtDonViTinh.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            btnLoadHH_Click(sender, e);
        }

        private void btnFindHH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHangHoa.Text))
            {
                MessageBox.Show("Nhập mã thuốc để tìm");
                txtMaHangHoa.Focus();
                return;
            }
            dgvHangHoa.Rows.Clear();
            HangHoa hh = new HangHoa();
            hh.setMaHangHoa(txtMaHangHoa.Text);
            dsHangHoa = hhcontroller.Find(hh);
            foreach (HangHoa hha in dsHangHoa)
            {
                string[] row = { hh.getMaHangHoa(), hha.getTenHangHoa(), hha.getDonViTinh(), hha.getSoLuong().ToString(), hha.getDonGia().ToString() };
                dgvHangHoa.Rows.Add(row);
            }
        }

        private void btnCancelHH_Click(object sender, EventArgs e)
        {
            txtMaHangHoa.Clear();
            txtTenHangHoa.Clear();
            txtDonViTinh.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
        }

        private void btnExitHH_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Close();
            frmMenu.ShowDialog();
        }
    }
}
