using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.SubForm
{
    public partial class FormCCN : DevExpress.XtraEditors.XtraForm
    {
        
        public FormCCN()
        {
            InitializeComponent();
            

        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnChuyenCN_Click(object sender, EventArgs e)
        {
           if(Program.mchiNhanh==cbbCN.SelectedIndex)
            {
                MessageBox.Show("Vui lòng chọn chi nhánh khác chi nhánh hiện tại ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           else
            {
                if((MessageBox.Show("Bạn có muốn chuyển chi nhánh nhân viên này không?", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK))
                    {
                        Program.eventClick = 1;
                        this.Close();
    
                }
                
                
            }    
           
        }

        private void FormCCN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);

        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCCN_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Program.frmChinh.Enabled = true;
        }
    }
}