using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14DC012_QLSV
{
    public partial class frmMain : Form
    {
        public static string strConn = @"Data Source=QUOCDAT-PC\SQLEXPRESS;Initial Catalog=QLSV;user=sa;pwd=123456";

        public frmMain()
        {
            InitializeComponent();
        }

        private void mnKhoa_mainMenu_Click(object sender, EventArgs e)
        {
            frmKhoa newFrmKhoa = new frmKhoa();
            newFrmKhoa.Show();
        }

        private void mnThoat_mainMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnSinhVien_mainMenu_Click(object sender, EventArgs e)
        {
            frmSinhVien newFrmSV = new frmSinhVien();
            newFrmSV.Show();
        }
    }
}
