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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private readonly AuthBLL auth = new AuthBLL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void hyperlinkLabelControlDK_Click(object sender, EventArgs e)
        {
            using (var f = new frmRegister())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    textEditTenDangNhap.Text = f.TenDangKy;
                    textEditPass.Text = "";
                    textEditPass.Focus();
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        public string UserName { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            var user = textEditTenDangNhap.Text;
            var pass = textEditPass.Text;

            var dto = auth.Login(user, pass, out string err);
            if (dto == null)
            {
                XtraMessageBox.Show(err, "Đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textEditPass.SelectAll();
                textEditPass.Focus();
                return;
            }

            XtraMessageBox.Show("Đăng nhập thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Common.AppSession.Set(dto.MADN, dto.TENDANGNHAP);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkEditHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkEditHienMatKhau.Checked;
            textEditPass.Properties.UseSystemPasswordChar = !show;
        }
    }
}