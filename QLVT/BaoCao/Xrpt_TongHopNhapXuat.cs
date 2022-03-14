using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.Report
{
    public partial class Xrpt_TongHopNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_TongHopNhapXuat(DateTime from, DateTime to)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.constr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = from;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = to;
            this.sqlDataSource1.Fill();
        }

    }
}
