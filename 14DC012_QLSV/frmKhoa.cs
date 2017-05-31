using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace _14DC012_QLSV
{
    public partial class frmKhoa : Form
    {

        void themKhoa(string maKhoa, string tenKhoa)
        {
            SqlConnection connDB = new SqlConnection(frmMain.strConn);
            connDB.Open();
            string cmd = "INSERT INTO KHOA VALUES(N'" + maKhoa + "',N'" + tenKhoa + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
            txtMaKhoa.ResetText();
            txtTenKhoa.ResetText();
            load_DSKhoa();
        }
        void suaKhoa(string maKhoa, string tenKhoa)
        {
            SqlConnection connDB = new SqlConnection(frmMain.strConn);
            connDB.Open();
            string cmd = "UPDATE KHOA SET TenKhoa=N'" + tenKhoa + "' WHERE MaKhoa='" + maKhoa + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
            txtMaKhoa.ResetText();
            txtTenKhoa.ResetText();
            load_DSKhoa();
        }

        void xoaKhoa(string maKhoa)
        {
            SqlConnection connDB = new SqlConnection(frmMain.strConn);
            connDB.Open();
            string cmd = "DELETE FROM KHOA WHERE MaKhoa='" + maKhoa + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
            txtMaKhoa.ResetText();
            txtTenKhoa.ResetText();
            load_DSKhoa();
        }

        DataTable DSKhoa()
        {
            string cmd = "SELECT * FROM KHOA";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, frmMain.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }

        void load_DSKhoa()
        {
            frmKhoa_dgwListKhoa.DataSource = DSKhoa();
            frmKhoa_dgwListKhoa.Columns[0].HeaderText = "Mã khoa";
            frmKhoa_dgwListKhoa.Columns[1].HeaderText = "Tên khoa";
        }

        public frmKhoa()
        {
            InitializeComponent();
            load_DSKhoa();
        }

        private void btnThoat_frmKhoa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_frmKhoa_Click(object sender, EventArgs e)
        {
            themKhoa(txtMaKhoa.Text, txtTenKhoa.Text);
        }

        private void btnXoa_frmKhoa_Click(object sender, EventArgs e)
        {
            xoaKhoa(txtMaKhoa.Text);
        }

        private void btnSua_frmKhoa_Click(object sender, EventArgs e)
        {
            suaKhoa(txtMaKhoa.Text, txtTenKhoa.Text);
        }
    }
}
