using DevExpress.XtraEditors;
using QuanLyHocVien.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocVien
{
    public partial class frmThongKePCGV : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKePCGV()
        {
            InitializeComponent();
        }

        private void frmThongKePCGV_Load(object sender, EventArgs e)
        {
            XtraReportThongKePCGV re = new XtraReportThongKePCGV();
            documentViewerThongKePCGV.DocumentSource = re;
            re.CreateDocument();
        }
    }
}