using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyHocVien.UserControl;

namespace QuanLyHocVien
{
    public partial class frmQuanLyHocVien : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly UC_HocVien ucHocVien = new UC_HocVien();
        private readonly UC_GiaoVien ucGiaoVien = new UC_GiaoVien();
        private readonly UC_LopHoc ucLopHoc = new UC_LopHoc();
        private readonly UC_BienLai ucBienLai = new UC_BienLai();
        public frmQuanLyHocVien()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += frmQuanLyHocVien_KeyDown;
            using (var fLogin = new frmLogin())
            {
                if (fLogin.ShowDialog() == DialogResult.OK)
                {
                    DisEndLogin(false);
                }
                else
                {
                    DisEndLogin(true);
                }
            }
            accordionControlElementHocVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
        }

        private void frmQuanLyHocVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                e.Handled = true;
                using (var f = new frmHelp())
                {
                    f.StartPosition = FormStartPosition.CenterParent;
                    f.ShowDialog(this);
                }
            }
        }

        private void accordionControlDangNhap_Click(object sender, EventArgs e)
        {
            using (var f = new frmLogin())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    DisEndLogin(false);
                }
            }
        }
        private void ClearAllUserControls()
        {
            fluentDesignFormContainerMain.Controls.Clear();
        }

        private void DisEndLogin(bool y)
        {
            accordionControlDangNhap.Enabled = y;
            accordionControlElementDK.Enabled = y;
            accordionControlDoiMatKhau.Enabled = !y;
            accordionControlElementThongTin.Enabled = !y;
            accordionControlElementDangXuat.Enabled = !y;
            accordionControlElementHocVien.Enabled = !y;
            accordionControlElementGiaoVien.Enabled = !y;
            accordionControlElementLopHoc.Enabled = !y;
            accordionControlElementBienLai.Enabled = !y;
        }

        private void frmQuanLyHocVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void accordionControlElementDangXuat_Click_1(object sender, EventArgs e)
        {
            DisEndLogin(true);
            ClearAllUserControls();
        }
        private void frmQuanLyHocVien_Load(object sender, EventArgs e)
        {

        }

        private void accordionControlDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (var f = new frmDoiMatKhau())
            {
                if (Common.AppSession.IsLoggedIn)
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        DisEndLogin(false);
                    }
                }
            }
        }

        private void accordionControlElementDK_Click(object sender, EventArgs e)
        {
            using (var f = new frmRegister())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    DisEndLogin(true);
                }
            }
        }


        private void ShowHocVien()
        {
            if (ucHocVien == null)
            {
                ucHocVien.Dock = DockStyle.Fill;
            }
            ucHocVien.Dock = DockStyle.Fill;
            fluentDesignFormContainerMain.Controls.Clear();
            fluentDesignFormContainerMain.Controls.Add(ucHocVien);
            ucHocVien.BringToFront();
        }

        private void ShowGiaoVien()
        {
            if (ucGiaoVien == null)
            {
                ucGiaoVien.Dock = DockStyle.Fill;
            }
            ucGiaoVien.Dock = DockStyle.Fill;
            fluentDesignFormContainerMain.Controls.Clear();
            fluentDesignFormContainerMain.Controls.Add(ucGiaoVien);
            ucGiaoVien.BringToFront();
        }

        private void ShowLopHoc()
        {
            if (ucLopHoc == null)
            {
                ucLopHoc.Dock = DockStyle.Fill;
            }
            ucLopHoc.Dock = DockStyle.Fill;
            fluentDesignFormContainerMain.Controls.Clear();
            fluentDesignFormContainerMain.Controls.Add(ucLopHoc);
            ucLopHoc.BringToFront();
        }

        private void ShowBienLai()
        {
            if (ucBienLai == null)
            {
                ucBienLai.Dock = DockStyle.Fill;
            }
            ucBienLai.Dock = DockStyle.Fill;
            fluentDesignFormContainerMain.Controls.Clear();
            fluentDesignFormContainerMain.Controls.Add(ucBienLai);
            ucBienLai.BringToFront();
        }

        private void accordionControlElementHocVien_Click(object sender, EventArgs e)
        {
            ShowHocVien();
        }

        private void accordionControlElementLopHoc_Click(object sender, EventArgs e)
        {
            ShowLopHoc();
        }

        private void accordionControlElementGiaoVien_Click_1(object sender, EventArgs e)
        {
            ShowGiaoVien();
        }

        private void accordionControlElementBienLai_Click(object sender, EventArgs e)
        {
            ShowBienLai();
        }

    }
}
