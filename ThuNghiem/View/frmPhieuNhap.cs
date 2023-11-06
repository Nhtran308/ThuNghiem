using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuNghiem.Control;
using ThuNghiem.Model;
using ThuNghiem.Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThuNghiem.View
{
    public partial class frmPhieuNhap : Form
    {
        PhieuNhapController controller;
        List<PhieuNhap> dsPhieuNhap;
        List<HangHoa> dsHangHoa;

        public frmPhieuNhap()
        {
            InitializeComponent();
            controller = new PhieuNhapController();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            txtSoPhieu.Clear();
            txtSoHopDong.Clear();
            txtMaKho.Clear();
            txtNgay.Clear();
            txtNgayHopDong.Clear();
            txtNguoiGiaoHang.Clear();
            txtDonViPhatHanh.Clear();
            dgvPhieuNhap.Rows.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }


        private void dgvPhieuNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = DataHelper.getConnection();
            for (int i = 0; i < dgvPhieuNhap.Rows.Count; i++)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT *, (Soluong * DonGia) AS 'ThanhTien' FROM HangHoa WHERE TenHangHoa = N'" + dgvPhieuNhap.Rows[i].Cells[1].Value + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    dgvPhieuNhap.Rows[i].Cells[0].Value = reader["MaHangHoa"].ToString();
                    dgvPhieuNhap.Rows[i].Cells[2].Value = reader["DonViTinh"].ToString();
                    dgvPhieuNhap.Rows[i].Cells[3].Value = reader["SoLuong"].ToString();
                    dgvPhieuNhap.Rows[i].Cells[4].Value = reader["DonGia"].ToString();
                    dgvPhieuNhap.Rows[i].Cells[5].Value = reader["ThanhTien"].ToString();
                }
                conn.Close();
            }
        }

        private void dgvPhieuNhap_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.IsCurrentCellDirty)
            {
                dgvPhieuNhap.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void txtSoPhieu_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = DataHelper.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuNhap WHERE MaPhieuNhap = N'" + txtSoPhieu.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtSoPhieu.Text = reader["MaPhieuNhap"].ToString();
                txtSoHopDong.Text = reader["SoHoaDon"].ToString();
                txtMaKho.Text = reader["MaKho"].ToString();
                txtNgay.Text = Convert.ToDateTime(reader["NgayNhapKho"]).ToString("dd/MM/yyyy");
                txtNgayHopDong.Text = Convert.ToDateTime(reader["NgayHoaDon"]).ToString("dd/MM/yyyy");
                txtNguoiGiaoHang.Text = reader["NguoiGiaoHang"].ToString();
                txtDonViPhatHanh.Text = reader["DonViPhatHanh"].ToString();
            }
            conn.Close();
        }
    }
}
