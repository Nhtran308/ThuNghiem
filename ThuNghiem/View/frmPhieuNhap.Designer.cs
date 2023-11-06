namespace ThuNghiem.View
{
    partial class frmPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtSoPhieu = new TextBox();
            txtSoHopDong = new TextBox();
            txtMaKho = new TextBox();
            txtNgay = new TextBox();
            txtNgayHopDong = new TextBox();
            txtDonViPhatHanh = new TextBox();
            dgvPhieuNhap = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            label9 = new Label();
            txtNguoiGiaoHang = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(317, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 35);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(23, 69);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 1;
            label2.Text = "Số phiếu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(23, 108);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 2;
            label3.Text = "Số HĐ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(23, 147);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 3;
            label4.Text = "Mã kho:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(259, 69);
            label5.Name = "label5";
            label5.Size = new Size(52, 19);
            label5.TabIndex = 4;
            label5.Text = "Ngày:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(512, 69);
            label6.Name = "label6";
            label6.Size = new Size(80, 19);
            label6.TabIndex = 5;
            label6.Text = "Ngày HĐ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(259, 147);
            label7.Name = "label7";
            label7.Size = new Size(141, 19);
            label7.TabIndex = 6;
            label7.Text = "ĐV phát hành HĐ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(23, 192);
            label8.Name = "label8";
            label8.Size = new Size(154, 19);
            label8.TabIndex = 7;
            label8.Text = "Danh sách mặt hàng";
            // 
            // txtSoPhieu
            // 
            txtSoPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtSoPhieu.Location = new Point(106, 67);
            txtSoPhieu.Name = "txtSoPhieu";
            txtSoPhieu.PlaceholderText = "Số phiếu";
            txtSoPhieu.Size = new Size(147, 27);
            txtSoPhieu.TabIndex = 8;
            txtSoPhieu.TextChanged += txtSoPhieu_TextChanged;
            // 
            // txtSoHopDong
            // 
            txtSoHopDong.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtSoHopDong.Location = new Point(106, 104);
            txtSoHopDong.Name = "txtSoHopDong";
            txtSoHopDong.PlaceholderText = "Số hợp đồng";
            txtSoHopDong.Size = new Size(147, 27);
            txtSoHopDong.TabIndex = 9;
            // 
            // txtMaKho
            // 
            txtMaKho.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtMaKho.Location = new Point(106, 143);
            txtMaKho.Name = "txtMaKho";
            txtMaKho.PlaceholderText = "Mã kho";
            txtMaKho.Size = new Size(147, 27);
            txtMaKho.TabIndex = 10;
            // 
            // txtNgay
            // 
            txtNgay.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtNgay.Location = new Point(317, 67);
            txtNgay.Name = "txtNgay";
            txtNgay.PlaceholderText = "Ngày";
            txtNgay.Size = new Size(171, 27);
            txtNgay.TabIndex = 11;
            // 
            // txtNgayHopDong
            // 
            txtNgayHopDong.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtNgayHopDong.Location = new Point(597, 67);
            txtNgayHopDong.Name = "txtNgayHopDong";
            txtNgayHopDong.PlaceholderText = "Ngày hợp đồng";
            txtNgayHopDong.Size = new Size(191, 27);
            txtNgayHopDong.TabIndex = 12;
            // 
            // txtDonViPhatHanh
            // 
            txtDonViPhatHanh.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtDonViPhatHanh.Location = new Point(406, 143);
            txtDonViPhatHanh.Name = "txtDonViPhatHanh";
            txtDonViPhatHanh.PlaceholderText = "Đơn vị phát hành hợp đồng";
            txtDonViPhatHanh.Size = new Size(383, 27);
            txtDonViPhatHanh.TabIndex = 13;
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.BackgroundColor = Color.CornflowerBlue;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4, Column5, Column6 });
            dgvPhieuNhap.Location = new Point(23, 213);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.RowHeadersWidth = 51;
            dgvPhieuNhap.RowTemplate.Height = 29;
            dgvPhieuNhap.Size = new Size(803, 188);
            dgvPhieuNhap.TabIndex = 14;
            dgvPhieuNhap.CellValueChanged += dgvPhieuNhap_CellValueChanged;
            dgvPhieuNhap.CurrentCellDirtyStateChanged += dgvPhieuNhap_CurrentCellDirtyStateChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã Hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn Vị";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số Lượng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Đơn Giá";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Thành Tiền";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(533, 408);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(633, 408);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(731, 408);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(259, 108);
            label9.Name = "label9";
            label9.Size = new Size(134, 19);
            label9.TabIndex = 18;
            label9.Text = "Người giao hàng:";
            // 
            // txtNguoiGiaoHang
            // 
            txtNguoiGiaoHang.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtNguoiGiaoHang.Location = new Point(406, 104);
            txtNguoiGiaoHang.Name = "txtNguoiGiaoHang";
            txtNguoiGiaoHang.PlaceholderText = "Người giao hàng";
            txtNguoiGiaoHang.Size = new Size(383, 27);
            txtNguoiGiaoHang.TabIndex = 19;
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(848, 448);
            Controls.Add(txtNguoiGiaoHang);
            Controls.Add(label9);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(dgvPhieuNhap);
            Controls.Add(txtDonViPhatHanh);
            Controls.Add(txtNgayHopDong);
            Controls.Add(txtNgay);
            Controls.Add(txtMaKho);
            Controls.Add(txtSoHopDong);
            Controls.Add(txtSoPhieu);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu Nhập Kho";
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSoPhieu;
        private TextBox txtSoHopDong;
        private TextBox txtMaKho;
        private TextBox txtNgay;
        private TextBox txtNgayHopDong;
        private TextBox txtDonViPhatHanh;
        public DataGridView dgvPhieuNhap;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClose;
        private Label label9;
        private TextBox txtNguoiGiaoHang;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}