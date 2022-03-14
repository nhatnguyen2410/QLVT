using DevExpress.Skins;
using DevExpress.UserSkins;
using QLVT.SubForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace QLVT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String constr;
        public static int eventClick=0;
       /* public static String constr_publisher = "Data Source=ADMIN\\NGUYENTRONGNHAN;Initial Catalog=QLVT;Integrated Security=True";*/
        public static String constr_publisher = "Data Source=NHATNG; Initial Catalog=QLVT_DATHANG ; Integrated Security=True";

        public static SqlDataReader myReader;
        public static String servername ="";
        public static String username ="";
        public static String mlogin ="";
        public static String password ="";

        public static String database = "QLVT_DATHANG";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";
        public static String mloginDN ="";
        public static String passwordDN ="";
        public static String mGroup ="";
        public static String mHoten ="";
        public static int maNV = 0;
        public static int mchiNhanh = 0;


        public static BindingSource bds_dspm = new BindingSource();


        public static FormMain frmChinh;
        public static FormLapPhieu formLapPhieu;
        public static SubFormCTDDH subFormCTDDH;
        public static SubFormCTPX subFormCTPX;
        public static SubFormCTPN subFormCTPN;
        public static SubFormKho subFormKho;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();

            try
            {
                Program.constr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User Id=" +
                    Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.constr;
                Program.conn.Open();    
                return 1;

            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối CSDL.\n Bạn xem lại username và password.\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String StrLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(StrLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }

        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;

        }


        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày thi\" qua kiểu number hoặc mở file Excel");
                else
                    MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;// trạng thái lỗi từ RAISEerror trong sql server
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*frmChinh = new FormMain();*/
            FormDN form = new FormDN();
            Application.Run(form);

        }
    }
}
