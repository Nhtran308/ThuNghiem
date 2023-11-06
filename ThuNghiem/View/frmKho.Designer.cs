namespace ThuNghiem.View
{
    partial class frmKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            dgvKho = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnLoad = new Button();
            txtMaKho = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTenKho = new TextBox();
            label3 = new Label();
            txtDiaChiKho = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            SuspendLayout();
            // 
            // dgvKho
            // 
            dgvKho.BackgroundColor = Color.CornflowerBlue;
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKho.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvKho.GridColor = SystemColors.InactiveCaptionText;
            dgvKho.Location = new Point(14, 12);
            dgvKho.Name = "dgvKho";
            dgvKho.RowHeadersWidth = 51;
            dgvKho.RowTemplate.Height = 29;
            dgvKho.Size = new Size(873, 269);
            dgvKho.TabIndex = 0;
            dgvKho.CellContentClick += dgvKho_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã Kho";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 166;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên Kho";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 327;
            // 
            // Column3
            // 
            Column3.FillWeight = 300F;
            Column3.HeaderText = "Địa chỉ kho";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 327;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(255, 224, 192);
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.ForeColor = SystemColors.ActiveCaptionText;
            btnLoad.Location = new Point(3, 409);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(106, 29);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Hiển thị";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtMaKho
            // 
            txtMaKho.Location = new Point(201, 313);
            txtMaKho.Name = "txtMaKho";
            txtMaKho.PlaceholderText = "Mã kho";
            txtMaKho.Size = new Size(140, 27);
            txtMaKho.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(115, 316);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 3;
            label1.Text = "Mã kho:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(424, 312);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 5;
            label2.Text = "Tên kho:";
            // 
            // txtTenKho
            // 
            txtTenKho.Location = new Point(514, 309);
            txtTenKho.Name = "txtTenKho";
            txtTenKho.PlaceholderText = "Tên kho";
            txtTenKho.Size = new Size(292, 27);
            txtTenKho.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(429, 362);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 7;
            label3.Text = "Địa chỉ:";
            // 
            // txtDiaChiKho
            // 
            txtDiaChiKho.Location = new Point(514, 359);
            txtDiaChiKho.Name = "txtDiaChiKho";
            txtDiaChiKho.PlaceholderText = "Địa chỉ kho";
            txtDiaChiKho.Size = new Size(292, 27);
            txtDiaChiKho.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(128, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 255, 192);
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ActiveCaptionText;
            btnEdit.Location = new Point(258, 409);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(106, 29);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(386, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(192, 192, 255);
            btnFind.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFind.ForeColor = SystemColors.ActiveCaptionText;
            btnFind.Location = new Point(514, 409);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(106, 29);
            btnFind.TabIndex = 11;
            btnFind.Text = "Tìm";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 255);
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(647, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Fuchsia;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(781, 409);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(106, 29);
            btnExit.TabIndex = 13;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmKho
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(900, 450);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(txtDiaChiKho);
            Controls.Add(label2);
            Controls.Add(txtTenKho);
            Controls.Add(label1);
            Controls.Add(txtMaKho);
            Controls.Add(btnLoad);
            Controls.Add(dgvKho);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kho";
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvKho;
        public Button btnLoad;
        public TextBox txtMaKho;
        public Label label1;
        public Label label2;
        public TextBox txtTenKho;
        public Label label3;
        public TextBox txtDiaChiKho;
        public Button btnAdd;
        public Button btnEdit;
        public Button btnDelete;
        public Button btnFind;
        public Button btnCancel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        public Button btnExit;
    }
}