
namespace QuanLyHocVien
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangKi = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlDangKy = new DevExpress.XtraEditors.GroupControl();
            this.checkEditHienMatKhau = new DevExpress.XtraEditors.CheckEdit();
            this.textEditRePass = new DevExpress.XtraEditors.TextEdit();
            this.lblNhapLaiMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.textEditPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlStar = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.textEditTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.lblTenDangNhap = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDangKy)).BeginInit();
            this.groupControlDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRePass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenDangNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(257, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKi.Appearance.Options.UseFont = true;
            this.btnDangKi.Location = new System.Drawing.Point(123, 231);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(92, 30);
            this.btnDangKi.TabIndex = 3;
            this.btnDangKi.Text = "Đăng Ký";
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // groupControlDangKy
            // 
            this.groupControlDangKy.Controls.Add(this.checkEditHienMatKhau);
            this.groupControlDangKy.Controls.Add(this.textEditRePass);
            this.groupControlDangKy.Controls.Add(this.lblNhapLaiMatKhau);
            this.groupControlDangKy.Controls.Add(this.textEditPass);
            this.groupControlDangKy.Controls.Add(this.labelControl2);
            this.groupControlDangKy.Controls.Add(this.labelControl1);
            this.groupControlDangKy.Controls.Add(this.labelControlStar);
            this.groupControlDangKy.Controls.Add(this.lblPassword);
            this.groupControlDangKy.Controls.Add(this.textEditTenDangNhap);
            this.groupControlDangKy.Controls.Add(this.lblTenDangNhap);
            this.groupControlDangKy.Location = new System.Drawing.Point(45, 12);
            this.groupControlDangKy.Name = "groupControlDangKy";
            this.groupControlDangKy.Size = new System.Drawing.Size(406, 203);
            this.groupControlDangKy.TabIndex = 2;
            this.groupControlDangKy.Text = "Thông Tin Đăng Ký";
            // 
            // checkEditHienMatKhau
            // 
            this.checkEditHienMatKhau.Location = new System.Drawing.Point(155, 167);
            this.checkEditHienMatKhau.Name = "checkEditHienMatKhau";
            this.checkEditHienMatKhau.Properties.Caption = "Hiện Mật Khẩu";
            this.checkEditHienMatKhau.Size = new System.Drawing.Size(97, 20);
            this.checkEditHienMatKhau.TabIndex = 4;
            this.checkEditHienMatKhau.CheckedChanged += new System.EventHandler(this.checkEditHienMatKhau_CheckedChanged_1);
            // 
            // textEditRePass
            // 
            this.textEditRePass.Location = new System.Drawing.Point(179, 130);
            this.textEditRePass.Name = "textEditRePass";
            this.textEditRePass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEditRePass.Properties.UseSystemPasswordChar = true;
            this.textEditRePass.Size = new System.Drawing.Size(191, 20);
            this.textEditRePass.TabIndex = 1;
            // 
            // lblNhapLaiMatKhau
            // 
            this.lblNhapLaiMatKhau.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapLaiMatKhau.Appearance.Options.UseFont = true;
            this.lblNhapLaiMatKhau.Location = new System.Drawing.Point(34, 133);
            this.lblNhapLaiMatKhau.Name = "lblNhapLaiMatKhau";
            this.lblNhapLaiMatKhau.Size = new System.Drawing.Size(115, 14);
            this.lblNhapLaiMatKhau.TabIndex = 0;
            this.lblNhapLaiMatKhau.Text = "Nhập Lại Mật Khẩu";
            // 
            // textEditPass
            // 
            this.textEditPass.Location = new System.Drawing.Point(179, 94);
            this.textEditPass.Name = "textEditPass";
            this.textEditPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEditPass.Properties.UseSystemPasswordChar = true;
            this.textEditPass.Size = new System.Drawing.Size(191, 20);
            this.textEditPass.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(155, 132);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(8, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "*";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(99, 96);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(8, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "*";
            // 
            // labelControlStar
            // 
            this.labelControlStar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlStar.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControlStar.Appearance.Options.UseFont = true;
            this.labelControlStar.Appearance.Options.UseForeColor = true;
            this.labelControlStar.Location = new System.Drawing.Point(141, 60);
            this.labelControlStar.Name = "labelControlStar";
            this.labelControlStar.Size = new System.Drawing.Size(8, 14);
            this.labelControlStar.TabIndex = 0;
            this.labelControlStar.Text = "*";
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Location = new System.Drawing.Point(34, 97);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 14);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Mật Khẩu";
            // 
            // textEditTenDangNhap
            // 
            this.textEditTenDangNhap.Location = new System.Drawing.Point(179, 58);
            this.textEditTenDangNhap.Name = "textEditTenDangNhap";
            this.textEditTenDangNhap.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEditTenDangNhap.Size = new System.Drawing.Size(191, 20);
            this.textEditTenDangNhap.TabIndex = 1;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Appearance.Options.UseFont = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(34, 61);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(93, 14);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 282);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.groupControlDangKy);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmRegister.IconOptions.LargeImage")));
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDangKy)).EndInit();
            this.groupControlDangKy.ResumeLayout(false);
            this.groupControlDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRePass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenDangNhap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnDangKi;
        private DevExpress.XtraEditors.GroupControl groupControlDangKy;
        private DevExpress.XtraEditors.TextEdit textEditRePass;
        private DevExpress.XtraEditors.LabelControl lblNhapLaiMatKhau;
        private DevExpress.XtraEditors.TextEdit textEditPass;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.TextEdit textEditTenDangNhap;
        private DevExpress.XtraEditors.LabelControl lblTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControlStar;
        private DevExpress.XtraEditors.CheckEdit checkEditHienMatKhau;
    }
}