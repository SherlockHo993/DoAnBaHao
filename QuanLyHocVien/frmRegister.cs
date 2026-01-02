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
    public partial class frmRegister : DevExpress.XtraEditors.XtraForm
    {
        private readonly AuthBLL auth = new AuthBLL();
        public string TenDangKy { get; private set; }
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            var user = textEditTenDangNhap.Text.Trim();
            var pass = textEditPass.Text;
            var confirm = textEditRePass.Text;

            bool ok = auth.Register(user, pass, confirm, out string err);
            if (!ok)
            {
                XtraMessageBox.Show(err, "Đăng ký",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textEditPass.SelectAll();
                textEditRePass.Focus();
                return; 
            }

            XtraMessageBox.Show("Đăng ký thành công!\n\nHãy ĐĂNG NHẬP để sử dụng ngay ứng dụng!!!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            TenDangKy = user;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    

        private void checkEditHienMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            bool show = checkEditHienMatKhau.Checked;
            textEditPass.Properties.UseSystemPasswordChar = !show;
            textEditRePass.Properties.UseSystemPasswordChar = !show;
        }
    }
}
    
