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
        private string ketQua = "ĐẬU"; // default

        public frmThongKeTheoKQUA(string kq) : this()
        {
            ketQua = (kq ?? "").Trim();
            if (string.IsNullOrWhiteSpace(ketQua))
                ketQua = "ĐẬU";
        }

        public frmThongKeTheoKQUA()
        {
            InitializeComponent();
        }

        private void frmThongKeTheoKQUA_Load(object sender, EventArgs e)
        {
            var re = new XtraReportThongKeTheoKQUA();

            // ✅ không hỏi parameters
            re.RequestParameters = false;

            // ✅ set parameter
            re.Parameters["pKQUA"].Value = ketQua;
            re.Parameters["pKQUA"].Visible = false;

            // ✅ gán nguồn + tạo document
            documentViewerThongKeTheoKQUA.DocumentSource = re;
            re.CreateDocument();
        }
    }
}