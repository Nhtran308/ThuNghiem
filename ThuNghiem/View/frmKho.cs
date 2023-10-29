using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuNghiem.Control;
using ThuNghiem.Model;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ThuNghiem.View
{
    public partial class frmKho : Form
    {
        KhoController controller;
        List<Kho> dsKho;
        Kho currentKho;
        public frmKho()
        {
            InitializeComponent();
            controller = new KhoController();
        }

        public void btnLoad_Click(object sender, EventArgs e)
        {
            dgvKho.Rows.Clear();
            dsKho = controller.Load();
            foreach (Kho k in dsKho)
            {
                string[] row = { k.getMaKho(), k.getTenKho(), k.getDiaChiKho() };
                dgvKho.Rows.Add(row);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKho.Text)
                || string.IsNullOrEmpty(txtTenKho.Text)
                || string.IsNullOrEmpty(txtDiaChiKho.Text)
                || txtMaKho.Text == ""
                || txtTenKho.Text == ""
                || txtDiaChiKho.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtMaKho.Focus();
                return;
            }
            Kho kho = new Kho();
            kho.setMaKho(txtMaKho.Text);
            kho.setTenKho(txtTenKho.Text);
            kho.setDiaChiKho(txtDiaChiKho.Text);
            controller.Insert(kho);
            btnLoad_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKho.Text)
                || string.IsNullOrEmpty(txtTenKho.Text)
                || string.IsNullOrEmpty(txtDiaChiKho.Text))
            {
                MessageBox.Show("Không có thông tin để sửa");
                txtMaKho.Focus();
                return;
            }
            Kho kho = new Kho();
            kho.setTenKho(txtTenKho.Text);
            kho.setDiaChiKho(txtDiaChiKho.Text);
            kho.setMaKho(txtMaKho.Text);
            controller.Edit(kho);
            btnLoad_Click(sender, e);
        }

        private void dgvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dgvKho.Rows[e.RowIndex];
                txtMaKho.Text = row.Cells[0].Value.ToString();
                txtTenKho.Text = row.Cells[1].Value.ToString();
                txtDiaChiKho.Text = row.Cells[2].Value.ToString();
            }
            dgvKho.ReadOnly = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKho.Text))
            {
                MessageBox.Show("Không thể xóa");
                return;
            }
            Kho kho = new Kho();
            kho.setMaKho(txtMaKho.Text);
            controller.Delete(kho);
            txtMaKho.Clear();
            txtTenKho.Clear();
            txtDiaChiKho.Clear();
            btnLoad_Click(sender, e);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKho.Text))
            {
                MessageBox.Show("Nhập mã thuốc để tìm");
                txtMaKho.Focus();
                return;
            }
            dgvKho.Rows.Clear();
            Kho kho = new Kho();
            kho.setMaKho(txtMaKho.Text);
            dsKho = controller.Find(kho);
            foreach (Kho k in dsKho)
            {
                string[] row = { k.getMaKho(), k.getTenKho(), k.getDiaChiKho() };
                dgvKho.Rows.Add(row);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaKho.Clear();
            txtTenKho.Clear();
            txtDiaChiKho.Clear();
        }
    }
}
