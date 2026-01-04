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

namespace QuanLyHocVien.UserControl
{
    public partial class frmThongKeLopHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeLopHoc()
        {
            InitializeComponent();
        }

        private void frmThongKeLopHoc_Load(object sender, EventArgs e)
        {
            XtraReportThongKeLopHoc re = new XtraReportThongKeLopHoc();
            documentViewerThongKeLopHoc.DocumentSource = re;
            re.CreateDocument();
        }
    }
}