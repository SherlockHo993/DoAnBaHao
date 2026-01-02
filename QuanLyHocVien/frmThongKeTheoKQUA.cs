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
    public partial class frmThongKeTheoKQUA : DevExpress.XtraEditors.XtraForm
    {
        private string ketQua;

        public frmThongKeTheoKQUA(string kq)
        {
            InitializeComponent();
            ketQua = kq;
        }

        public frmThongKeTheoKQUA()
        {
            InitializeComponent();
        }

        private void frmThongKeTheoKQUA_Load(object sender, EventArgs e)
        {
            var re = new XtraReportThongKeTheoKQUA();

            re.RequestParameters = false;

            re.Parameters["pKQUA"].Value = ketQua;
            re.Parameters["pKQUA"].Visible = false;

            documentViewerThongKeTheoKQUA.DocumentSource = re;
            re.CreateDocument();
        }
    }
}