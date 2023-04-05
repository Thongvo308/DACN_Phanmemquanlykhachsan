using BusinessLayer;
using DataLayer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace KhachSan.Report
{
    public partial class reportdatphong : DevExpress.XtraReports.UI.XtraReport
    {
        public reportdatphong()
        {
            InitializeComponent();
        }

        
        public void InitData(List<tb_datphong> data)
        {
                objectDataSource1.DataSource = data;
        }

    }
}
