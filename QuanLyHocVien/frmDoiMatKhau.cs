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
using BLL;

namespace QuanLyHocVien
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        private readonly int ma = Common.AppSession.MADN;
        private readonly AuthBLL auth = new AuthBLL();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var oldPass = txtOldPass.Text;
            var newPass = txtNewPass.Text;
            var confirm = txtConfirm.Text;

            bool ok = auth.ChangePassword(ma, oldPass, newPass, confirm, out string err);

            if (!ok)
            {
                XtraMessageBox.Show(err, "Đổi mật khẩu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtOldPass.SelectAll();
                txtOldPass.Focus();
                return;
            }
            XtraMessageBox.Show("Đổi Mật Khẩu thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textEditTenDangNhap_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkEditHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkEditHienMatKhau.Checked;
            txtOldPass.Properties.UseSystemPasswordChar = !show;
            txtNewPass.Properties.UseSystemPasswordChar = !show;
            txtConfirm.Properties.UseSystemPasswordChar = !show;
        }
    }
}