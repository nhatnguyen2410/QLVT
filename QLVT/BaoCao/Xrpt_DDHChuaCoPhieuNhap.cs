using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.Report
{
    public partial class Xrpt_DDHChuaCoPhieuNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DDHChuaCoPhieuNhap()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.constr;
            this.sqlDataSource1.Fill();
        }

    }
}
