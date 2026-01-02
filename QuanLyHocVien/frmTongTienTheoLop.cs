using DevExpress.XtraEditors;
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
    public partial class frmTongTienTheoLop : DevExpress.XtraEditors.XtraForm
    {
        public frmTongTienTheoLop()
        {
            InitializeComponent();
        }

        private void frmTongTienTheoLop_Load(object sender, EventArgs e)
        {
            XtraReportTongTienTheoLop re = new XtraReportTongTienTheoLop();
            documentViewerTongTienTheoLop.DocumentSource = re;
            re.CreateDocument();
        }
    }
}