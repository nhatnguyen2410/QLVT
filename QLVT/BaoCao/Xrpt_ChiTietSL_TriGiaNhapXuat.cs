using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.BaoCao
{
    public partial class Xrpt_ChiTietSL_TriGiaNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_ChiTietSL_TriGiaNhapXuat(String Role, String Loai, DateTime timeBegin, DateTime timeTo)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.constr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = Role;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = Loai;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = timeBegin;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = timeTo;
            this.sqlDataSource1.Fill();

        }
    }
}