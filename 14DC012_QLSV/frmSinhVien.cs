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
    public partial class frmSinhVien : Form
    {

        public frmSinhVien()
        {
            InitializeComponent();
            resetForm();
            load_DSSinhVien();
        }
        DataTable DSKhoa()
        {
            string cmd = "SELECT * FROM KHOA";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, frmMain.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        DataTable DSSinhVien()
        {
            string cmd = "SELECT * FROM SINHVIEN";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, frmMain.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }

        void load_DSSinhVien()
        {
            frmSinhVien_dgw_DSSinhVien.DataSource = DSSinhVien();

            frmSinhVien_dgw_DSSinhVien.Columns[0].HeaderText = "Mã SV";
            frmSinhVien_dgw_DSSinhVien.Columns[1].HeaderText = "Họ SV";
            frmSinhVien_dgw_DSSinhVien.Columns[2].HeaderText = "Tên SV";
            frmSinhVien_dgw_DSSinhVien.Columns[3].HeaderText = "Giới tính";
            frmSinhVien_dgw_DSSinhVien.Columns[4].HeaderText = "Ngày sinh";
            frmSinhVien_dgw_DSSinhVien.Columns[5].HeaderText = "Nơi sinh";
            frmSinhVien_dgw_DSSinhVien.Columns[6].HeaderText = "Mã khoa";
        }

        void themSinhVien(string maSV, string hoSV, string tenSV, string gioiTinh, string ngaySinh, string noiSinh, string maKhoa)
        {
            string cmd = "INSERT INTO SINHVIEN VALUES(N'" + maSV + "',N'" + hoSV + "',N'" + tenSV + "', N'" + gioiTinh + "' ,'" + ngaySinh + "',N'" + noiSinh + "',N'" + maKhoa + "')";
            SqlConnection dbConn = new SqlConnection(frmMain.strConn);
            dbConn.Open();
            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
            dbCmd.ExecuteNonQuery();
            dbConn.Close();

            resetForm();
            load_DSSinhVien();
        }

        void suaSinhVien(string maSV, string hoSV, string tenSV, string gioiTinh, string ngaySinh, string noiSinh, string maKhoa)
        {
            string cmd = "UPDATE SINHVIEN SET HoSV=N'" + hoSV + "',TenSV=N'" + tenSV + "',GioiTinh=N'" + gioiTinh + "' ,NgaySinh='" + ngaySinh + "',NoiSinh=N'" + noiSinh + "',MaKhoa=N'" + maKhoa + "' WHERE  MaSV='" + maSV + "'";

            SqlConnection dbConn = new SqlConnection(frmMain.strConn);
            dbConn.Open();
            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
            dbCmd.ExecuteNonQuery();
            dbConn.Close();

            resetForm();
            load_DSSinhVien();
        }

        void xoaSinhVien(string maSV)
        {
            SqlConnection connDB = new SqlConnection(frmMain.strConn);
            connDB.Open();
            string cmd = "DELETE FROM SINHVIEN WHERE MaSV='" + maSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
            resetForm();
            load_DSSinhVien();
        }

        void resetForm()
        {
            txtMaSV.ResetText();
            txtHoSV.ResetText();
            txtTenSV.ResetText();
            txtNoiSinh.ResetText();
            rad_Nam.Checked = true;
            rad_Nu.Checked = false;
            date_NgaySinh.ResetText();
            cbox_Khoa.DataSource = DSKhoa();
            cbox_Khoa.DisplayMember = "TenKhoa";
            cbox_Khoa.ValueMember = "MaKhoa";
        }

        private void btnThoat_frmSinhVien_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_frmSinhVien_Click(object sender, EventArgs e)
        {
            String gt;
            if (rad_Nam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";

            themSinhVien(txtMaSV.Text.Trim(), txtHoSV.Text.Trim(), txtTenSV.Text.Trim(), gt.Trim(), date_NgaySinh.Text.Trim(), txtNoiSinh.Text.Trim(), cbox_Khoa.SelectedValue.ToString().Trim());
        }

        private void btnSua_frmSinhVien_Click(object sender, EventArgs e)
        {
            String gt;
            if (rad_Nam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";

            suaSinhVien(txtMaSV.Text, txtHoSV.Text.Trim(), txtTenSV.Text.Trim(), gt.Trim(), date_NgaySinh.Text.Trim(), txtNoiSinh.Text.Trim(), cbox_Khoa.SelectedValue.ToString().Trim());
        }

        private void btnXoa_frmSinhVien_Click(object sender, EventArgs e)
        {
            xoaSinhVien(txtMaSV.Text);
        }
    }
}
