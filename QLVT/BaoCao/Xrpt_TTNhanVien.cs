using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.BaoCao
{
    public partial class Xrpt_TTNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_TTNhanVien()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.constr;
            this.sqlDataSource1.Fill();

        }

    }
}
