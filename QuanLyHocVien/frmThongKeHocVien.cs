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
    public partial class frmThongKeHocVien : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeHocVien()
        {
            InitializeComponent();
        }

        private void frmThongKeHocVien_Load(object sender, EventArgs e)
        {
            XtraReportThongKeHV re = new XtraReportThongKeHV();
            documentViewerThongKeHV.DocumentSource = re;
            re.CreateDocument();
        }
    }
}