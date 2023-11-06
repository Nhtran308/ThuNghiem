namespace ThuNghiem.View
{
    partial class frmMenu
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
            menuStrip1 = new MenuStrip();
            khoToolStripMenuItem = new ToolStripMenuItem();
            hangHoaToolStripMenuItem = new ToolStripMenuItem();
            nhanVienToolStripMenuItem = new ToolStripMenuItem();
            thêmPhiếuNhậpToolStripMenuItem = new ToolStripMenuItem();
            chiTiếtPhiếuNhậpToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.CornflowerBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { khoToolStripMenuItem, hangHoaToolStripMenuItem, nhanVienToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 2, 0, 2);
            menuStrip1.Size = new Size(1099, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // khoToolStripMenuItem
            // 
            khoToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            khoToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            khoToolStripMenuItem.Size = new Size(58, 27);
            khoToolStripMenuItem.Text = "Kho";
            khoToolStripMenuItem.Click += khoToolStripMenuItem_Click;
            // 
            // hangHoaToolStripMenuItem
            // 
            hangHoaToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hangHoaToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            hangHoaToolStripMenuItem.Name = "hangHoaToolStripMenuItem";
            hangHoaToolStripMenuItem.Size = new Size(109, 27);
            hangHoaToolStripMenuItem.Text = "Hàng Hóa";
            hangHoaToolStripMenuItem.Click += hangHoaToolStripMenuItem_Click;
            // 
            // nhanVienToolStripMenuItem
            // 
            nhanVienToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmPhiếuNhậpToolStripMenuItem, chiTiếtPhiếuNhậpToolStripMenuItem });
            nhanVienToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nhanVienToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            nhanVienToolStripMenuItem.Size = new Size(120, 27);
            nhanVienToolStripMenuItem.Text = "Phiếu Nhập";
            // 
            // thêmPhiếuNhậpToolStripMenuItem
            // 
            thêmPhiếuNhậpToolStripMenuItem.BackColor = Color.LightSkyBlue;
            thêmPhiếuNhậpToolStripMenuItem.Name = "thêmPhiếuNhậpToolStripMenuItem";
            thêmPhiếuNhậpToolStripMenuItem.Size = new Size(264, 28);
            thêmPhiếuNhậpToolStripMenuItem.Text = "Thêm Phiếu Nhập";
            thêmPhiếuNhậpToolStripMenuItem.Click += thêmPhiếuNhậpToolStripMenuItem_Click;
            // 
            // chiTiếtPhiếuNhậpToolStripMenuItem
            // 
            chiTiếtPhiếuNhậpToolStripMenuItem.BackColor = Color.LightSkyBlue;
            chiTiếtPhiếuNhậpToolStripMenuItem.Name = "chiTiếtPhiếuNhậpToolStripMenuItem";
            chiTiếtPhiếuNhậpToolStripMenuItem.Size = new Size(264, 28);
            chiTiếtPhiếuNhậpToolStripMenuItem.Text = "Chi Tiết Phiếu Nhập";
            chiTiếtPhiếuNhậpToolStripMenuItem.Click += chiTiếtPhiếuNhậpToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 55.8000031F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(30, 202);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1043, 104);
            label1.TabIndex = 2;
            label1.Text = "NHẬT TRẦN LOGISTIC";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(1099, 518);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhật Trần Logistic";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem khoToolStripMenuItem;
        private ToolStripMenuItem hangHoaToolStripMenuItem;
        private ToolStripMenuItem nhanVienToolStripMenuItem;
        private ToolStripMenuItem thêmPhiếuNhậpToolStripMenuItem;
        private ToolStripMenuItem chiTiếtPhiếuNhậpToolStripMenuItem;
        private Label label1;
    }
}