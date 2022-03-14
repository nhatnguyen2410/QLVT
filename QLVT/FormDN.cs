using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace QLVT
{
    public partial class FormDN : DevExpress.XtraEditors.XtraForm
    {
       

        private SqlConnection conn_publisher = new SqlConnection();
        public FormDN()
        {
            InitializeComponent();
           
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            
            if (KetNoi_CSDLGOC() == 0) return;
            /*LayDSPM("SELECT * From V_DS_PHANMANH WHERE TENSERVER!='ADMIN//NGUYENTRONGNHAN'");*/
            LayDSPM("SELECT * From V_DS_PHANMANH WHERE TENSERVER!='NHATNG\\NHATNG3'");

            cmbChinhanh.SelectedIndex = 1;
            cmbChinhanh.SelectedIndex = 0;
        }

        //test git
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbChinhanh.DataSource = Program.bds_dspm;
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            


        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.constr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về CSDL gốc. \nBạn xem lại Tên Server của Publisher và tên CSDL trong chuỗi kết nối.\n" + e.Message);
                return 0;
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.Trim() == "" || txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản hoặc Mật khẩu không được để trống", "", MessageBoxButtons.OK);
                return;
            }


            Program.mlogin = txtTK.Text;
            Program.password = txtMK.Text;
            if (Program.KetNoi() == 0) return;

            Program.mchiNhanh = cmbChinhanh.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu \n Bạn xem lại username và password", "", MessageBoxButtons.OK);
                return;
            }
            Program.maNV = int.Parse(Program.username);
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            this.Hide();
            Program.frmChinh = new FormMain();
            try
            {
                Program.frmChinh.HienThiMenu();
            }
            catch (Exception t)
            {
                MessageBox.Show("Lỗi:" + t.Message);
            }
            Program.frmChinh.Show();





        }



        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChinhanh.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnDN_keyPress(object sender, KeyPressEventArgs e)
        {
        
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDN_Click_2(object sender, EventArgs e)
        {
            if (txtTK.Text.Trim() == "" || txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản hoặc Mật khẩu không được để trống", "", MessageBoxButtons.OK);
                return;
            }


            Program.mlogin = txtTK.Text;
            Program.password = txtMK.Text;
            if (Program.KetNoi() == 0) return;

            Program.mchiNhanh = cmbChinhanh.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            try
            {
                Program.myReader.Read();
            }
            catch
            {
                MessageBox.Show("Tài khoản này k có quyền đăng nhập", "", MessageBoxButtons.OK);
                return;
            }

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu \n Bạn xem lại username và password", "", MessageBoxButtons.OK);
                return;
            }
            Program.maNV = int.Parse(Program.username);
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            this.Hide();
            Program.frmChinh = new FormMain();
            try
            {
                Program.frmChinh.HienThiMenu();
            }
            catch (Exception t)
            {
                MessageBox.Show("Lỗi :" + t.Message);
            }
            Program.frmChinh.Show();


        }

        private void cmbChinhanh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChinhanh.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}