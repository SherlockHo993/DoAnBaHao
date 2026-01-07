
namespace QuanLyHocVien
{
    partial class frmQuanLyHocVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHocVien));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.fluentDesignFormContainerMain = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlHeThong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlDangNhap = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElementDK = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlDoiMatKhau = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElementDangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementThongTin = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementHocVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElementGiaoVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator5 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElementLopHoc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator6 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElementBienLai = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementExit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainerMain
            // 
            this.fluentDesignFormContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainerMain.Location = new System.Drawing.Point(250, 31);
            this.fluentDesignFormContainerMain.Name = "fluentDesignFormContainerMain";
            this.fluentDesignFormContainerMain.Size = new System.Drawing.Size(820, 613);
            this.fluentDesignFormContainerMain.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlHeThong,
            this.accordionControlElementThongTin,
            this.accordionControlElementExit});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(250, 613);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlHeThong
            // 
            this.accordionControlHeThong.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlDangNhap,
            this.accordionControlSeparator1,
            this.accordionControlElementDK,
            this.accordionControlSeparator2,
            this.accordionControlDoiMatKhau,
            this.accordionControlSeparator3,
            this.accordionControlElementDangXuat});
            this.accordionControlHeThong.Expanded = true;
            this.accordionControlHeThong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlHeThong.ImageOptions.SvgImage")));
            this.accordionControlHeThong.Name = "accordionControlHeThong";
            this.accordionControlHeThong.Text = "Hệ Thống";
            // 
            // accordionControlDangNhap
            // 
            this.accordionControlDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlDangNhap.ImageOptions.Image")));
            this.accordionControlDangNhap.Name = "accordionControlDangNhap";
            this.accordionControlDangNhap.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlDangNhap.Text = "Đăng Nhập";
            this.accordionControlDangNhap.Click += new System.EventHandler(this.accordionControlDangNhap_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlElementDK
            // 
            this.accordionControlElementDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementDK.ImageOptions.Image")));
            this.accordionControlElementDK.Name = "accordionControlElementDK";
            this.accordionControlElementDK.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementDK.Text = "Đăng Kí Tài Khoản";
            this.accordionControlElementDK.Click += new System.EventHandler(this.accordionControlElementDK_Click);
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // accordionControlDoiMatKhau
            // 
            this.accordionControlDoiMatKhau.Expanded = true;
            this.accordionControlDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlDoiMatKhau.ImageOptions.Image")));
            this.accordionControlDoiMatKhau.Name = "accordionControlDoiMatKhau";
            this.accordionControlDoiMatKhau.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.accordionControlDoiMatKhau.Click += new System.EventHandler(this.accordionControlDoiMatKhau_Click);
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // accordionControlElementDangXuat
            // 
            this.accordionControlElementDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementDangXuat.ImageOptions.Image")));
            this.accordionControlElementDangXuat.Name = "accordionControlElementDangXuat";
            this.accordionControlElementDangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementDangXuat.Text = "Đăng Xuất";
            this.accordionControlElementDangXuat.Click += new System.EventHandler(this.accordionControlElementDangXuat_Click_1);
            // 
            // accordionControlElementThongTin
            // 
            this.accordionControlElementThongTin.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementHocVien,
            this.accordionControlSeparator4,
            this.accordionControlElementGiaoVien,
            this.accordionControlSeparator5,
            this.accordionControlElementLopHoc,
            this.accordionControlSeparator6,
            this.accordionControlElementBienLai});
            this.accordionControlElementThongTin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementThongTin.ImageOptions.SvgImage")));
            this.accordionControlElementThongTin.Name = "accordionControlElementThongTin";
            this.accordionControlElementThongTin.Text = "Quản Lý Thông Tin";
            // 
            // accordionControlElementHocVien
            // 
            this.accordionControlElementHocVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementHocVien.ImageOptions.Image")));
            this.accordionControlElementHocVien.Name = "accordionControlElementHocVien";
            this.accordionControlElementHocVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementHocVien.Text = "Danh Mục Học Viên";
            this.accordionControlElementHocVien.Click += new System.EventHandler(this.accordionControlElementHocVien_Click);
            // 
            // accordionControlSeparator4
            // 
            this.accordionControlSeparator4.Name = "accordionControlSeparator4";
            // 
            // accordionControlElementGiaoVien
            // 
            this.accordionControlElementGiaoVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementGiaoVien.ImageOptions.Image")));
            this.accordionControlElementGiaoVien.Name = "accordionControlElementGiaoVien";
            this.accordionControlElementGiaoVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementGiaoVien.Text = "Danh Mục Giáo Viên";
            this.accordionControlElementGiaoVien.Click += new System.EventHandler(this.accordionControlElementGiaoVien_Click_1);
            // 
            // accordionControlSeparator5
            // 
            this.accordionControlSeparator5.Name = "accordionControlSeparator5";
            // 
            // accordionControlElementLopHoc
            // 
            this.accordionControlElementLopHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementLopHoc.ImageOptions.Image")));
            this.accordionControlElementLopHoc.Name = "accordionControlElementLopHoc";
            this.accordionControlElementLopHoc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementLopHoc.Text = "Danh Mục Lớp Học";
            this.accordionControlElementLopHoc.Click += new System.EventHandler(this.accordionControlElementLopHoc_Click);
            // 
            // accordionControlSeparator6
            // 
            this.accordionControlSeparator6.Name = "accordionControlSeparator6";
            // 
            // accordionControlElementBienLai
            // 
            this.accordionControlElementBienLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementBienLai.ImageOptions.Image")));
            this.accordionControlElementBienLai.Name = "accordionControlElementBienLai";
            this.accordionControlElementBienLai.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementBienLai.Text = "Danh Mục Biên Lai";
            this.accordionControlElementBienLai.Click += new System.EventHandler(this.accordionControlElementBienLai_Click);
            // 
            // accordionControlElementExit
            // 
            this.accordionControlElementExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementExit.ImageOptions.SvgImage")));
            this.accordionControlElementExit.Name = "accordionControlElementExit";
            this.accordionControlElementExit.Text = "Thoát";
            this.accordionControlElementExit.Click += new System.EventHandler(this.accordionControlElementExit_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.barWorkspaceMenuItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1070, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "skinBarSubItem1";
            this.skinBarSubItem1.Id = 0;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.Id = 1;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.WorkspaceManager = this.workspaceManager1;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.barWorkspaceMenuItem1});
            this.fluentFormDefaultManager1.MaxItemId = 2;
            // 
            // frmQuanLyHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 644);
            this.ControlContainer = this.fluentDesignFormContainerMain;
            this.Controls.Add(this.fluentDesignFormContainerMain);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmQuanLyHocVien.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "frmQuanLyHocVien";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Học Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyHocVien_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainerMain;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlHeThong;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlDangNhap;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlDoiMatKhau;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementDK;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementThongTin;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementDangXuat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementHocVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementGiaoVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementLopHoc;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementBienLai;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementExit;
    }
}