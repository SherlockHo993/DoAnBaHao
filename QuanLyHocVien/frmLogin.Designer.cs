
namespace QuanLyHocVien
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.groupControlDangNhap = new DevExpress.XtraEditors.GroupControl();
            this.checkEditHienMatKhau = new DevExpress.XtraEditors.CheckEdit();
            this.hyperlinkLabelControlDK = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.textEditPass = new DevExpress.XtraEditors.TextEdit();
            this.lblNonPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.textEditTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.lblTenDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDangNhap)).BeginInit();
            this.groupControlDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenDangNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlDangNhap
            // 
            this.groupControlDangNhap.Controls.Add(this.checkEditHienMatKhau);
            this.groupControlDangNhap.Controls.Add(this.hyperlinkLabelControlDK);
            this.groupControlDangNhap.Controls.Add(this.textEditPass);
            this.groupControlDangNhap.Controls.Add(this.lblNonPassword);
            this.groupControlDangNhap.Controls.Add(this.lblPassword);
            this.groupControlDangNhap.Controls.Add(this.textEditTenDangNhap);
            this.groupControlDangNhap.Controls.Add(this.lblTenDangNhap);
            this.groupControlDangNhap.Location = new System.Drawing.Point(52, 12);
            this.groupControlDangNhap.Name = "groupControlDangNhap";
            this.groupControlDangNhap.Size = new System.Drawing.Size(406, 203);
            this.groupControlDangNhap.TabIndex = 0;
            this.groupControlDangNhap.Text = "Thông Tin Đăng Nhập";
            // 
            // checkEditHienMatKhau
            // 
            this.checkEditHienMatKhau.Location = new System.Drawing.Point(290, 151);
            this.checkEditHienMatKhau.Name = "checkEditHienMatKhau";
            this.checkEditHienMatKhau.Properties.Caption = "Hiện Mật Khẩu";
            this.checkEditHienMatKhau.Size = new System.Drawing.Size(97, 20);
            this.checkEditHienMatKhau.TabIndex = 3;
            this.checkEditHienMatKhau.CheckedChanged += new System.EventHandler(this.checkEditHienMatKhau_CheckedChanged);
            // 
            // hyperlinkLabelControlDK
            // 
            this.hyperlinkLabelControlDK.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinkLabelControlDK.Appearance.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.hyperlinkLabelControlDK.Appearance.Options.UseFont = true;
            this.hyperlinkLabelControlDK.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControlDK.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.hyperlinkLabelControlDK.Location = new System.Drawing.Point(195, 151);
            this.hyperlinkLabelControlDK.Name = "hyperlinkLabelControlDK";
            this.hyperlinkLabelControlDK.Size = new System.Drawing.Size(48, 14);
            this.hyperlinkLabelControlDK.TabIndex = 2;
            this.hyperlinkLabelControlDK.Text = "Đăng Kí";
            this.hyperlinkLabelControlDK.Click += new System.EventHandler(this.hyperlinkLabelControlDK_Click);
            // 
            // textEditPass
            // 
            this.textEditPass.Location = new System.Drawing.Point(140, 93);
            this.textEditPass.Name = "textEditPass";
            this.textEditPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEditPass.Properties.UseSystemPasswordChar = true;
            this.textEditPass.Size = new System.Drawing.Size(191, 20);
            this.textEditPass.TabIndex = 1;
            // 
            // lblNonPassword
            // 
            this.lblNonPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNonPassword.Appearance.Options.UseFont = true;
            this.lblNonPassword.Location = new System.Drawing.Point(34, 151);
            this.lblNonPassword.Name = "lblNonPassword";
            this.lblNonPassword.Size = new System.Drawing.Size(133, 14);
            this.lblNonPassword.TabIndex = 0;
            this.lblNonPassword.Text = "Bạn chưa có mật khẩu ?";
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
            this.textEditTenDangNhap.Location = new System.Drawing.Point(140, 57);
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
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(130, 231);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(264, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 282);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupControlDangNhap);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmLogin.IconOptions.LargeImage")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDangNhap)).EndInit();
            this.groupControlDangNhap.ResumeLayout(false);
            this.groupControlDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenDangNhap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlDangNhap;
        private DevExpress.XtraEditors.LabelControl lblTenDangNhap;
        private DevExpress.XtraEditors.CheckEdit checkEditHienMatKhau;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControlDK;
        private DevExpress.XtraEditors.LabelControl lblNonPassword;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        public DevExpress.XtraEditors.TextEdit textEditTenDangNhap;
        public DevExpress.XtraEditors.TextEdit textEditPass;
    }
}