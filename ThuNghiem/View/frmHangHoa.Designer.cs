namespace ThuNghiem.View
{
    partial class frmHangHoa
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvHangHoa = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTenHangHoa = new TextBox();
            txtMaHangHoa = new TextBox();
            txtDonViTinh = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            btnLoadHH = new Button();
            btnAddHH = new Button();
            btnEditHH = new Button();
            btnDeleteHH = new Button();
            btnFindHH = new Button();
            btnCancelHH = new Button();
            btnExitHH = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            SuspendLayout();
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.BackgroundColor = Color.CornflowerBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHangHoa.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHangHoa.GridColor = SystemColors.InactiveCaptionText;
            dgvHangHoa.Location = new Point(12, 12);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersWidth = 51;
            dgvHangHoa.RowTemplate.Height = 29;
            dgvHangHoa.Size = new Size(873, 269);
            dgvHangHoa.TabIndex = 0;
            dgvHangHoa.CellContentClick += dgvHangHoa_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã Hàng Hóa";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên Hàng Hóa";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 225;
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn Vị Tính";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 225;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 304);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 4;
            label1.Text = "Mã hàng hóa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 355);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 5;
            label2.Text = "Tên hàng hóa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(346, 304);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 6;
            label3.Text = "Đơn vị tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(346, 355);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 7;
            label4.Text = "Số lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(590, 355);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 8;
            label5.Text = "Đơn giá:";
            // 
            // txtTenHangHoa
            // 
            txtTenHangHoa.Location = new Point(147, 356);
            txtTenHangHoa.Name = "txtTenHangHoa";
            txtTenHangHoa.PlaceholderText = "Tên hàng hóa";
            txtTenHangHoa.Size = new Size(193, 27);
            txtTenHangHoa.TabIndex = 10;
            // 
            // txtMaHangHoa
            // 
            txtMaHangHoa.Location = new Point(147, 307);
            txtMaHangHoa.Name = "txtMaHangHoa";
            txtMaHangHoa.PlaceholderText = "Mã hàng hóa";
            txtMaHangHoa.Size = new Size(193, 27);
            txtMaHangHoa.TabIndex = 9;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Location = new Point(463, 307);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.PlaceholderText = "Đơn vị tính";
            txtDonViTinh.Size = new Size(210, 27);
            txtDonViTinh.TabIndex = 11;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(434, 356);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.PlaceholderText = "Số lượng";
            txtSoLuong.Size = new Size(150, 27);
            txtSoLuong.TabIndex = 12;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(679, 356);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.PlaceholderText = "Đơn giá";
            txtDonGia.Size = new Size(193, 27);
            txtDonGia.TabIndex = 13;
            // 
            // btnLoadHH
            // 
            btnLoadHH.BackColor = Color.FromArgb(255, 224, 192);
            btnLoadHH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadHH.ForeColor = SystemColors.ActiveCaptionText;
            btnLoadHH.Location = new Point(12, 409);
            btnLoadHH.Name = "btnLoadHH";
            btnLoadHH.Size = new Size(106, 29);
            btnLoadHH.TabIndex = 14;
            btnLoadHH.Text = "Hiển thị";
            btnLoadHH.UseVisualStyleBackColor = false;
            btnLoadHH.Click += btnLoadHH_Click;
            // 
            // btnAddHH
            // 
            btnAddHH.BackColor = Color.FromArgb(192, 255, 192);
            btnAddHH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddHH.ForeColor = SystemColors.ControlText;
            btnAddHH.Location = new Point(147, 409);
            btnAddHH.Name = "btnAddHH";
            btnAddHH.Size = new Size(106, 29);
            btnAddHH.TabIndex = 15;
            btnAddHH.Text = "Thêm";
            btnAddHH.UseVisualStyleBackColor = false;
            btnAddHH.Click += btnAddHH_Click;
            // 
            // btnEditHH
            // 
            btnEditHH.BackColor = Color.FromArgb(255, 255, 192);
            btnEditHH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditHH.ForeColor = SystemColors.ActiveCaptionText;
            btnEditHH.Location = new Point(282, 409);
            btnEditHH.Name = "btnEditHH";
            btnEditHH.Size = new Size(106, 29);
            btnEditHH.TabIndex = 16;
            btnEditHH.Text = "Sửa";
            btnEditHH.UseVisualStyleBackColor = false;
            btnEditHH.Click += btnEditHH_Click;
            // 
            // btnDeleteHH
            // 
            btnDeleteHH.BackColor = Color.FromArgb(255, 128, 128);
            btnDeleteHH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteHH.ForeColor = SystemColors.ActiveCaptionText;
            btnDeleteHH.Location = new Point(408, 409);
            btnDeleteHH.Name = "btnDeleteHH";
            btnDeleteHH.Size = new Size(106, 29);
            btnDeleteHH.TabIndex = 17;
            btnDeleteHH.Text = "Xóa";
            btnDeleteHH.UseVisualStyleBackColor = false;
            btnDeleteHH.Click += btnDeleteHH_Click;
            // 
            // btnFindHH
            // 
            btnFindHH.BackColor = Color.FromArgb(192, 192, 255);
            btnFindHH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFindHH.ForeColor = SystemColors.ActiveCaptionText;
            btnFindHH.Location = new Point(535, 409);
            btnFindHH.Name = "btnFindHH";
            btnFindHH.Size = new Size(106, 29);
            btnFindHH.TabIndex = 18;
            btnFindHH.Text = "Tìm";
            btnFindHH.UseVisualStyleBackColor = false;
            btnFindHH.Click += btnFindHH_Click;
            // 
            // btnCancelHH
            // 
            btnCancelHH.BackColor = Color.FromArgb(255, 192, 255);
            btnCancelHH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelHH.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelHH.Location = new Point(659, 409);
            btnCancelHH.Name = "btnCancelHH";
            btnCancelHH.Size = new Size(106, 29);
            btnCancelHH.TabIndex = 19;
            btnCancelHH.Text = "Hủy";
            btnCancelHH.UseVisualStyleBackColor = false;
            btnCancelHH.Click += btnCancelHH_Click;
            // 
            // btnExitHH
            // 
            btnExitHH.BackColor = Color.Fuchsia;
            btnExitHH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExitHH.ForeColor = SystemColors.ActiveCaptionText;
            btnExitHH.Location = new Point(782, 409);
            btnExitHH.Name = "btnExitHH";
            btnExitHH.Size = new Size(106, 29);
            btnExitHH.TabIndex = 20;
            btnExitHH.Text = "Thoát";
            btnExitHH.UseVisualStyleBackColor = false;
            btnExitHH.Click += btnExitHH_Click;
            // 
            // frmHangHoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(900, 450);
            Controls.Add(btnExitHH);
            Controls.Add(btnCancelHH);
            Controls.Add(btnFindHH);
            Controls.Add(btnDeleteHH);
            Controls.Add(btnEditHH);
            Controls.Add(btnAddHH);
            Controls.Add(btnLoadHH);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonViTinh);
            Controls.Add(txtTenHangHoa);
            Controls.Add(txtMaHangHoa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvHangHoa);
            Name = "frmHangHoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hàng Hóa";
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvHangHoa;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public TextBox txtTenHangHoa;
        public TextBox txtMaHangHoa;
        public TextBox txtDonViTinh;
        public TextBox txtSoLuong;
        public TextBox txtDonGia;
        public Button btnLoadHH;
        public Button btnAddHH;
        public Button btnEditHH;
        public Button btnDeleteHH;
        public Button btnFindHH;
        public Button btnCancelHH;
        public Button btnExitHH;
    }
}