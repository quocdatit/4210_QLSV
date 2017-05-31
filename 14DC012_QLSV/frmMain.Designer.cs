namespace _14DC012_QLSV
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.cậpNhậtDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKhoa_mainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMonHoc_mainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSinhVien_mainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDKMH_mainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnThoat_mainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtDữLiệuToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(640, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // cậpNhậtDữLiệuToolStripMenuItem
            // 
            this.cậpNhậtDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnKhoa_mainMenu,
            this.mnMonHoc_mainMenu,
            this.mnSinhVien_mainMenu,
            this.mnDKMH_mainMenu,
            this.toolStripSeparator1,
            this.mnThoat_mainMenu});
            this.cậpNhậtDữLiệuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cậpNhậtDữLiệuToolStripMenuItem.Name = "cậpNhậtDữLiệuToolStripMenuItem";
            this.cậpNhậtDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.cậpNhậtDữLiệuToolStripMenuItem.Text = "Cập nhật dữ liệu";
            // 
            // mnKhoa_mainMenu
            // 
            this.mnKhoa_mainMenu.Name = "mnKhoa_mainMenu";
            this.mnKhoa_mainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.mnKhoa_mainMenu.Size = new System.Drawing.Size(211, 22);
            this.mnKhoa_mainMenu.Text = "Khoa";
            this.mnKhoa_mainMenu.Click += new System.EventHandler(this.mnKhoa_mainMenu_Click);
            // 
            // mnMonHoc_mainMenu
            // 
            this.mnMonHoc_mainMenu.Name = "mnMonHoc_mainMenu";
            this.mnMonHoc_mainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnMonHoc_mainMenu.Size = new System.Drawing.Size(211, 22);
            this.mnMonHoc_mainMenu.Text = "Môn học";
            // 
            // mnSinhVien_mainMenu
            // 
            this.mnSinhVien_mainMenu.Name = "mnSinhVien_mainMenu";
            this.mnSinhVien_mainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnSinhVien_mainMenu.Size = new System.Drawing.Size(211, 22);
            this.mnSinhVien_mainMenu.Text = "Sinh viên";
            this.mnSinhVien_mainMenu.Click += new System.EventHandler(this.mnSinhVien_mainMenu_Click);
            // 
            // mnDKMH_mainMenu
            // 
            this.mnDKMH_mainMenu.Name = "mnDKMH_mainMenu";
            this.mnDKMH_mainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnDKMH_mainMenu.Size = new System.Drawing.Size(211, 22);
            this.mnDKMH_mainMenu.Text = "Đăng ký môn học";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // mnThoat_mainMenu
            // 
            this.mnThoat_mainMenu.Name = "mnThoat_mainMenu";
            this.mnThoat_mainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnThoat_mainMenu.Size = new System.Drawing.Size(211, 22);
            this.mnThoat_mainMenu.Text = "Thoát";
            this.mnThoat_mainMenu.Click += new System.EventHandler(this.mnThoat_mainMenu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 373);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.Text = "Quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnKhoa_mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnMonHoc_mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnSinhVien_mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnDKMH_mainMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnThoat_mainMenu;
    }
}

