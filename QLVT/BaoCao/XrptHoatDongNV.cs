using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.BaoCao
{
    public partial class XrptHoatDongNV : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptHoatDongNV(int manv,DateTime TGbatdau,DateTime TGketthuc,String loai)
        {
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = manv;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = TGbatdau;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = TGketthuc;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = loai;
        }

    }
}
