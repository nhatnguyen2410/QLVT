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
    public partial class FormDK : DevExpress.XtraEditors.XtraForm
    {
        int manv;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public FormDK()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            qLVT_DATHANGDataSet.EnforceConstraints = false;
            if (Program.mGroup=="CONGTY")
            {
                radioButton_CN.Visible = radioButton_USER.Visible = false;
                radioButton_CONGTY.Visible = true;
                radioButton_CONGTY.Checked = true;
                radioButton_CONGTY.Enabled = false;
                
            } 
            else
            {
                radioButton_CONGTY.Visible = false;
                radioButton_CN.Visible = radioButton_USER.Visible = true;
            }    
        }

        private void pnDky_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.frmChinh.Enabled = true;
        }

        private void FormDK_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DSNV_CHUATK' table. You can move, or remove it, as needed.
            this.v_DSNV_CHUATKTableAdapter.Connection.ConnectionString = Program.constr;
            this.v_DSNV_CHUATKTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DSNV_CHUATK);
            
            cmbCN.DataSource = Program.bds_dspm;
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
            
            if (Program.mGroup == "CONGTY")
            {
                cmbCN.Enabled = true;
            }
            else
            {
                cmbCN.Enabled = false;
            }
        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbCN.SelectedValue.ToString();
            if (cmbCN.SelectedIndex != Program.mchiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);

            }
            else
            {
                this.v_DSNV_CHUATKTableAdapter.Connection.ConnectionString = Program.constr;
                this.v_DSNV_CHUATKTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DSNV_CHUATK);

            }
        }
     
        private void mANVComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                manv = int.Parse(cmbMANV.SelectedValue.ToString());
                
            }
            catch(Exception ex)
            {

            }
        }

        private void btnDky_Click(object sender, EventArgs e)
        {
            manv = int.Parse(cmbMANV.SelectedValue.ToString());
            Program.conn = new SqlConnection(Program.constr);
            Program.conn.Open();
            SqlCommand cmd = new SqlCommand("sp_TaoTaiKhoan", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@LGNAME", txtTKDK.Text));
            cmd.Parameters.Add(new SqlParameter("@PASS", txtMKDK.Text));
            cmd.Parameters.Add(new SqlParameter("@USERNAME", manv));
            if(radioButton_CN.Checked==true)
            {
                cmd.Parameters.Add(new SqlParameter("@ROLE", "CHINHANH"));
            }
             if(radioButton_CONGTY.Checked == true)
            {
                cmd.Parameters.Add(new SqlParameter("@ROLE", "CONGTY"));

            }
            if(radioButton_USER.Checked == true)
            {
                cmd.Parameters.Add(new SqlParameter("@ROLE", "USER"));

            }
            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("tạo tài khoản thành công ! ", "", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("tạo tài khoản that bai! "+ex.Message, "", MessageBoxButtons.OK);
            }
            
        }
    }
}