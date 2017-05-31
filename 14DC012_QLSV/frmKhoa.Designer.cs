namespace _14DC012_QLSV
{
    partial class frmKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoa));
            this.lbTitleThongTinKhoa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.lbTenKhoa = new System.Windows.Forms.Label();
            this.btnLuu_frmKhoa = new System.Windows.Forms.Button();
            this.btnSua_frmKhoa = new System.Windows.Forms.Button();
            this.btnXoa_frmKhoa = new System.Windows.Forms.Button();
            this.btnThoat_frmKhoa = new System.Windows.Forms.Button();
            this.frmKhoa_dgwListKhoa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.frmKhoa_dgwListKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitleThongTinKhoa
            // 
            this.lbTitleThongTinKhoa.AutoSize = true;
            this.lbTitleThongTinKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleThongTinKhoa.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTitleThongTinKhoa.Location = new System.Drawing.Point(110, 14);
            this.lbTitleThongTinKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitleThongTinKhoa.Name = "lbTitleThongTinKhoa";
            this.lbTitleThongTinKhoa.Size = new System.Drawing.Size(205, 25);
            this.lbTitleThongTinKhoa.TabIndex = 1;
            this.lbTitleThongTinKhoa.Text = "THÔNG TIN KHOA";
            this.lbTitleThongTinKhoa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khoa";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(115, 58);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(139, 22);
            this.txtMaKhoa.TabIndex = 3;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(115, 98);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(272, 22);
            this.txtTenKhoa.TabIndex = 5;
            // 
            // lbTenKhoa
            // 
            this.lbTenKhoa.AutoSize = true;
            this.lbTenKhoa.Location = new System.Drawing.Point(17, 103);
            this.lbTenKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenKhoa.Name = "lbTenKhoa";
            this.lbTenKhoa.Size = new System.Drawing.Size(65, 16);
            this.lbTenKhoa.TabIndex = 4;
            this.lbTenKhoa.Text = "Tên khoa";
            // 
            // btnLuu_frmKhoa
            // 
            this.btnLuu_frmKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_frmKhoa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLuu_frmKhoa.Location = new System.Drawing.Point(20, 143);
            this.btnLuu_frmKhoa.Margin = new System.Windows.Forms.Padding(10);
            this.btnLuu_frmKhoa.Name = "btnLuu_frmKhoa";
            this.btnLuu_frmKhoa.Size = new System.Drawing.Size(80, 35);
            this.btnLuu_frmKhoa.TabIndex = 6;
            this.btnLuu_frmKhoa.Text = "Lưu";
            this.btnLuu_frmKhoa.UseVisualStyleBackColor = true;
            this.btnLuu_frmKhoa.Click += new System.EventHandler(this.btnLuu_frmKhoa_Click);
            // 
            // btnSua_frmKhoa
            // 
            this.btnSua_frmKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_frmKhoa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSua_frmKhoa.Location = new System.Drawing.Point(116, 143);
            this.btnSua_frmKhoa.Margin = new System.Windows.Forms.Padding(10);
            this.btnSua_frmKhoa.Name = "btnSua_frmKhoa";
            this.btnSua_frmKhoa.Size = new System.Drawing.Size(80, 35);
            this.btnSua_frmKhoa.TabIndex = 7;
            this.btnSua_frmKhoa.Text = "Sửa";
            this.btnSua_frmKhoa.UseVisualStyleBackColor = true;
            this.btnSua_frmKhoa.Click += new System.EventHandler(this.btnSua_frmKhoa_Click);
            // 
            // btnXoa_frmKhoa
            // 
            this.btnXoa_frmKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_frmKhoa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa_frmKhoa.Location = new System.Drawing.Point(212, 143);
            this.btnXoa_frmKhoa.Margin = new System.Windows.Forms.Padding(10);
            this.btnXoa_frmKhoa.Name = "btnXoa_frmKhoa";
            this.btnXoa_frmKhoa.Size = new System.Drawing.Size(80, 35);
            this.btnXoa_frmKhoa.TabIndex = 8;
            this.btnXoa_frmKhoa.Text = "Xóa";
            this.btnXoa_frmKhoa.UseVisualStyleBackColor = true;
            this.btnXoa_frmKhoa.Click += new System.EventHandler(this.btnXoa_frmKhoa_Click);
            // 
            // btnThoat_frmKhoa
            // 
            this.btnThoat_frmKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_frmKhoa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThoat_frmKhoa.Location = new System.Drawing.Point(307, 143);
            this.btnThoat_frmKhoa.Margin = new System.Windows.Forms.Padding(10);
            this.btnThoat_frmKhoa.Name = "btnThoat_frmKhoa";
            this.btnThoat_frmKhoa.Size = new System.Drawing.Size(80, 35);
            this.btnThoat_frmKhoa.TabIndex = 9;
            this.btnThoat_frmKhoa.Text = "Thoát";
            this.btnThoat_frmKhoa.UseVisualStyleBackColor = true;
            this.btnThoat_frmKhoa.Click += new System.EventHandler(this.btnThoat_frmKhoa_Click);
            // 
            // frmKhoa_dgwListKhoa
            // 
            this.frmKhoa_dgwListKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmKhoa_dgwListKhoa.Location = new System.Drawing.Point(20, 193);
            this.frmKhoa_dgwListKhoa.Name = "frmKhoa_dgwListKhoa";
            this.frmKhoa_dgwListKhoa.Size = new System.Drawing.Size(367, 150);
            this.frmKhoa_dgwListKhoa.TabIndex = 10;
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 355);
            this.Controls.Add(this.frmKhoa_dgwListKhoa);
            this.Controls.Add(this.btnThoat_frmKhoa);
            this.Controls.Add(this.btnXoa_frmKhoa);
            this.Controls.Add(this.btnSua_frmKhoa);
            this.Controls.Add(this.btnLuu_frmKhoa);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.lbTenKhoa);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitleThongTinKhoa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin khoa";
            ((System.ComponentModel.ISupportInitialize)(this.frmKhoa_dgwListKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitleThongTinKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label lbTenKhoa;
        private System.Windows.Forms.Button btnLuu_frmKhoa;
        private System.Windows.Forms.Button btnSua_frmKhoa;
        private System.Windows.Forms.Button btnXoa_frmKhoa;
        private System.Windows.Forms.Button btnThoat_frmKhoa;
        private System.Windows.Forms.DataGridView frmKhoa_dgwListKhoa;
    }
}