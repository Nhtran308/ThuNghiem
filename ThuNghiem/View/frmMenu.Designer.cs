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
            danhMucKhoToolStripMenuItem = new ToolStripMenuItem();
            hangHoaToolStripMenuItem = new ToolStripMenuItem();
            nhanVienToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { khoToolStripMenuItem, hangHoaToolStripMenuItem, nhanVienToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // khoToolStripMenuItem
            // 
            khoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhMucKhoToolStripMenuItem });
            khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            khoToolStripMenuItem.Size = new Size(49, 24);
            khoToolStripMenuItem.Text = "Kho";
            // 
            // danhMucKhoToolStripMenuItem
            // 
            danhMucKhoToolStripMenuItem.Name = "danhMucKhoToolStripMenuItem";
            danhMucKhoToolStripMenuItem.Size = new Size(224, 26);
            danhMucKhoToolStripMenuItem.Text = "Danh muc kho";
            danhMucKhoToolStripMenuItem.Click += danhMucKhoToolStripMenuItem_Click;
            // 
            // hangHoaToolStripMenuItem
            // 
            hangHoaToolStripMenuItem.Name = "hangHoaToolStripMenuItem";
            hangHoaToolStripMenuItem.Size = new Size(88, 24);
            hangHoaToolStripMenuItem.Text = "Hang hoa";
            // 
            // nhanVienToolStripMenuItem
            // 
            nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            nhanVienToolStripMenuItem.Size = new Size(89, 24);
            nhanVienToolStripMenuItem.Text = "Nhan vien";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "frmMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem khoToolStripMenuItem;
        private ToolStripMenuItem danhMucKhoToolStripMenuItem;
        private ToolStripMenuItem hangHoaToolStripMenuItem;
        private ToolStripMenuItem nhanVienToolStripMenuItem;
    }
}