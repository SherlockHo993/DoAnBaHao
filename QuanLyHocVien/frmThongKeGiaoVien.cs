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
    public partial class frmThongKeGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeGiaoVien()
        {
            InitializeComponent();
        }

        private void frmThongKeGiaoVien_Load(object sender, EventArgs e)
        {
            XtraReportThongKeGiaoVien re = new XtraReportThongKeGiaoVien();
            documentViewerThongKeGV.DocumentSource = re;
            re.CreateDocument();
        }
    }
}