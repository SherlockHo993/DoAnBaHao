
namespace QuanLyHocVien.UserControl
{
    partial class UC_BienLai
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BienLai));
            this.ribbonControlBienLai = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barListChinhSach = new DevExpress.XtraBars.BarListItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.ribbonCongCu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageCongCu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupGiaoDien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBarThongTin = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControlHocVien = new DevExpress.XtraEditors.PanelControl();
            this.spinEditTIENNOP = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditDIEM = new DevExpress.XtraEditors.SpinEdit();
            this.textEditKQUA = new DevExpress.XtraEditors.TextEdit();
            this.textEditXEPLOAI = new DevExpress.XtraEditors.TextEdit();
            this.textEditMAHV = new DevExpress.XtraEditors.TextEdit();
            this.labelControlTienNop = new DevExpress.XtraEditors.LabelControl();
            this.labelControlKetQua = new DevExpress.XtraEditors.LabelControl();
            this.textEditMALH = new DevExpress.XtraEditors.TextEdit();
            this.labelControlXepLoai = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDiem = new DevExpress.XtraEditors.LabelControl();
            this.labelControlMAHV = new DevExpress.XtraEditors.LabelControl();
            this.labelControlMALH = new DevExpress.XtraEditors.LabelControl();
            this.labelControlBienLai = new DevExpress.XtraEditors.LabelControl();
            this.GCBienLai = new DevExpress.XtraGrid.GridControl();
            this.GVBienLai = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnMALH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMAHV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnKQUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnXEPLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTIENNOP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlBienLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHocVien)).BeginInit();
            this.panelControlHocVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditTIENNOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditDIEM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKQUA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditXEPLOAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMAHV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMALH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCBienLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVBienLai)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlBienLai
            // 
            this.ribbonControlBienLai.ExpandCollapseItem.Id = 0;
            this.ribbonControlBienLai.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlBienLai.ExpandCollapseItem,
            this.btnAddNew,
            this.btnDelete,
            this.btnUpdate,
            this.barButtonItem4,
            this.btnSave,
            this.btnCancel,
            this.btnNewAdd,
            this.barListChinhSach,
            this.skinRibbonGalleryBarItem1,
            this.skinRibbonGalleryBarItem2,
            this.ribbonGalleryBarItem1,
            this.ribbonControlBienLai.SearchEditItem});
            this.ribbonControlBienLai.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlBienLai.MaxItemId = 12;
            this.ribbonControlBienLai.Name = "ribbonControlBienLai";
            this.ribbonControlBienLai.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonCongCu,
            this.ribbonPageThongKe});
            this.ribbonControlBienLai.Size = new System.Drawing.Size(820, 169);
            this.ribbonControlBienLai.StatusBar = this.ribbonStatusBarThongTin;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Caption = "Add New";
            this.btnAddNew.Id = 1;
            this.btnAddNew.Name = "btnAddNew";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Detele";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Update";
            this.btnUpdate.Id = 3;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick_1);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 5;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancel";
            this.btnCancel.Id = 6;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.LargeImage")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick_1);
            // 
            // btnNewAdd
            // 
            this.btnNewAdd.Caption = "New Add";
            this.btnNewAdd.Id = 7;
            this.btnNewAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAdd.ImageOptions.Image")));
            this.btnNewAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNewAdd.ImageOptions.LargeImage")));
            this.btnNewAdd.Name = "btnNewAdd";
            this.btnNewAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewAdd_ItemClick_1);
            // 
            // barListChinhSach
            // 
            this.barListChinhSach.Caption = "Chính Sách";
            this.barListChinhSach.Id = 8;
            this.barListChinhSach.Name = "barListChinhSach";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 9;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // skinRibbonGalleryBarItem2
            // 
            this.skinRibbonGalleryBarItem2.Caption = "skinRibbonGalleryBarItem2";
            this.skinRibbonGalleryBarItem2.Id = 10;
            this.skinRibbonGalleryBarItem2.Name = "skinRibbonGalleryBarItem2";
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 11;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // ribbonCongCu
            // 
            this.ribbonCongCu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageCongCu,
            this.ribbonPageGroupGiaoDien});
            this.ribbonCongCu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonCongCu.ImageOptions.Image")));
            this.ribbonCongCu.Name = "ribbonCongCu";
            this.ribbonCongCu.Text = "Công Cụ";
            // 
            // ribbonPageCongCu
            // 
            this.ribbonPageCongCu.ItemLinks.Add(this.btnNewAdd);
            this.ribbonPageCongCu.ItemLinks.Add(this.btnUpdate);
            this.ribbonPageCongCu.ItemLinks.Add(this.btnDelete);
            this.ribbonPageCongCu.ItemLinks.Add(this.btnSave);
            this.ribbonPageCongCu.ItemLinks.Add(this.btnCancel);
            this.ribbonPageCongCu.Name = "ribbonPageCongCu";
            this.ribbonPageCongCu.Text = "Thêm, xóa, sửa";
            // 
            // ribbonPageGroupGiaoDien
            // 
            this.ribbonPageGroupGiaoDien.ItemLinks.Add(this.skinRibbonGalleryBarItem2);
            this.ribbonPageGroupGiaoDien.Name = "ribbonPageGroupGiaoDien";
            this.ribbonPageGroupGiaoDien.Text = "Giao Diện";
            // 
            // ribbonPageThongKe
            // 
            this.ribbonPageThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageThongKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageThongKe.ImageOptions.Image")));
            this.ribbonPageThongKe.Name = "ribbonPageThongKe";
            this.ribbonPageThongKe.Text = "Thống Kê";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBarThongTin
            // 
            this.ribbonStatusBarThongTin.Location = new System.Drawing.Point(0, 586);
            this.ribbonStatusBarThongTin.Name = "ribbonStatusBarThongTin";
            this.ribbonStatusBarThongTin.Ribbon = this.ribbonControlBienLai;
            this.ribbonStatusBarThongTin.Size = new System.Drawing.Size(820, 27);
            // 
            // panelControlHocVien
            // 
            this.panelControlHocVien.Controls.Add(this.spinEditTIENNOP);
            this.panelControlHocVien.Controls.Add(this.spinEditDIEM);
            this.panelControlHocVien.Controls.Add(this.textEditKQUA);
            this.panelControlHocVien.Controls.Add(this.textEditXEPLOAI);
            this.panelControlHocVien.Controls.Add(this.textEditMAHV);
            this.panelControlHocVien.Controls.Add(this.labelControlTienNop);
            this.panelControlHocVien.Controls.Add(this.labelControlKetQua);
            this.panelControlHocVien.Controls.Add(this.textEditMALH);
            this.panelControlHocVien.Controls.Add(this.labelControlXepLoai);
            this.panelControlHocVien.Controls.Add(this.labelControlDiem);
            this.panelControlHocVien.Controls.Add(this.labelControlMAHV);
            this.panelControlHocVien.Controls.Add(this.labelControlMALH);
            this.panelControlHocVien.Controls.Add(this.labelControlBienLai);
            this.panelControlHocVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlHocVien.Location = new System.Drawing.Point(0, 169);
            this.panelControlHocVien.Name = "panelControlHocVien";
            this.panelControlHocVien.Size = new System.Drawing.Size(820, 204);
            this.panelControlHocVien.TabIndex = 6;
            // 
            // spinEditTIENNOP
            // 
            this.spinEditTIENNOP.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditTIENNOP.Location = new System.Drawing.Point(550, 154);
            this.spinEditTIENNOP.Name = "spinEditTIENNOP";
            this.spinEditTIENNOP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditTIENNOP.Size = new System.Drawing.Size(207, 20);
            this.spinEditTIENNOP.TabIndex = 11;
            // 
            // spinEditDIEM
            // 
            this.spinEditDIEM.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditDIEM.Location = new System.Drawing.Point(168, 154);
            this.spinEditDIEM.MenuManager = this.ribbonControlBienLai;
            this.spinEditDIEM.Name = "spinEditDIEM";
            this.spinEditDIEM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditDIEM.Size = new System.Drawing.Size(207, 20);
            this.spinEditDIEM.TabIndex = 11;
            // 
            // textEditKQUA
            // 
            this.textEditKQUA.Location = new System.Drawing.Point(550, 67);
            this.textEditKQUA.Name = "textEditKQUA";
            this.textEditKQUA.Size = new System.Drawing.Size(207, 20);
            this.textEditKQUA.TabIndex = 10;
            // 
            // textEditXEPLOAI
            // 
            this.textEditXEPLOAI.Location = new System.Drawing.Point(550, 111);
            this.textEditXEPLOAI.MenuManager = this.ribbonControlBienLai;
            this.textEditXEPLOAI.Name = "textEditXEPLOAI";
            this.textEditXEPLOAI.Size = new System.Drawing.Size(207, 20);
            this.textEditXEPLOAI.TabIndex = 10;
            // 
            // textEditMAHV
            // 
            this.textEditMAHV.Location = new System.Drawing.Point(168, 111);
            this.textEditMAHV.MenuManager = this.ribbonControlBienLai;
            this.textEditMAHV.Name = "textEditMAHV";
            this.textEditMAHV.Size = new System.Drawing.Size(207, 20);
            this.textEditMAHV.TabIndex = 7;
            // 
            // labelControlTienNop
            // 
            this.labelControlTienNop.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlTienNop.Appearance.Options.UseFont = true;
            this.labelControlTienNop.Location = new System.Drawing.Point(428, 156);
            this.labelControlTienNop.Name = "labelControlTienNop";
            this.labelControlTienNop.Size = new System.Drawing.Size(61, 14);
            this.labelControlTienNop.TabIndex = 5;
            this.labelControlTienNop.Text = "Tiền Nộp :";
            // 
            // labelControlKetQua
            // 
            this.labelControlKetQua.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlKetQua.Appearance.Options.UseFont = true;
            this.labelControlKetQua.Location = new System.Drawing.Point(428, 70);
            this.labelControlKetQua.Name = "labelControlKetQua";
            this.labelControlKetQua.Size = new System.Drawing.Size(57, 14);
            this.labelControlKetQua.TabIndex = 5;
            this.labelControlKetQua.Text = "Kết Quả :";
            // 
            // textEditMALH
            // 
            this.textEditMALH.Location = new System.Drawing.Point(168, 67);
            this.textEditMALH.MenuManager = this.ribbonControlBienLai;
            this.textEditMALH.Name = "textEditMALH";
            this.textEditMALH.Size = new System.Drawing.Size(207, 20);
            this.textEditMALH.TabIndex = 6;
            // 
            // labelControlXepLoai
            // 
            this.labelControlXepLoai.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlXepLoai.Appearance.Options.UseFont = true;
            this.labelControlXepLoai.Location = new System.Drawing.Point(428, 114);
            this.labelControlXepLoai.Name = "labelControlXepLoai";
            this.labelControlXepLoai.Size = new System.Drawing.Size(60, 14);
            this.labelControlXepLoai.TabIndex = 5;
            this.labelControlXepLoai.Text = "Xếp Loại :";
            // 
            // labelControlDiem
            // 
            this.labelControlDiem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlDiem.Appearance.Options.UseFont = true;
            this.labelControlDiem.Location = new System.Drawing.Point(43, 155);
            this.labelControlDiem.Name = "labelControlDiem";
            this.labelControlDiem.Size = new System.Drawing.Size(38, 14);
            this.labelControlDiem.TabIndex = 3;
            this.labelControlDiem.Text = "Điểm :";
            // 
            // labelControlMAHV
            // 
            this.labelControlMAHV.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlMAHV.Appearance.Options.UseFont = true;
            this.labelControlMAHV.Location = new System.Drawing.Point(43, 111);
            this.labelControlMAHV.Name = "labelControlMAHV";
            this.labelControlMAHV.Size = new System.Drawing.Size(83, 14);
            this.labelControlMAHV.TabIndex = 2;
            this.labelControlMAHV.Text = "Mã Học Viên :";
            // 
            // labelControlMALH
            // 
            this.labelControlMALH.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlMALH.Appearance.Options.UseFont = true;
            this.labelControlMALH.Location = new System.Drawing.Point(43, 67);
            this.labelControlMALH.Name = "labelControlMALH";
            this.labelControlMALH.Size = new System.Drawing.Size(80, 14);
            this.labelControlMALH.TabIndex = 1;
            this.labelControlMALH.Text = "Mã Lớp Học :";
            // 
            // labelControlBienLai
            // 
            this.labelControlBienLai.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlBienLai.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControlBienLai.Appearance.Options.UseFont = true;
            this.labelControlBienLai.Appearance.Options.UseForeColor = true;
            this.labelControlBienLai.Location = new System.Drawing.Point(335, 22);
            this.labelControlBienLai.Name = "labelControlBienLai";
            this.labelControlBienLai.Size = new System.Drawing.Size(177, 19);
            this.labelControlBienLai.TabIndex = 0;
            this.labelControlBienLai.Text = "THÔNG TIN  BIÊN LAI";
            // 
            // GCBienLai
            // 
            this.GCBienLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCBienLai.Location = new System.Drawing.Point(0, 373);
            this.GCBienLai.MainView = this.GVBienLai;
            this.GCBienLai.MenuManager = this.ribbonControlBienLai;
            this.GCBienLai.Name = "GCBienLai";
            this.GCBienLai.Size = new System.Drawing.Size(820, 213);
            this.GCBienLai.TabIndex = 7;
            this.GCBienLai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVBienLai});
            // 
            // GVBienLai
            // 
            this.GVBienLai.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMALH,
            this.gridColumnMAHV,
            this.gridColumnDIEM,
            this.gridColumnKQUA,
            this.gridColumnXEPLOAI,
            this.gridColumnTIENNOP});
            this.GVBienLai.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GVBienLai.GridControl = this.GCBienLai;
            this.GVBienLai.Name = "GVBienLai";
            this.GVBienLai.OptionsBehavior.Editable = false;
            this.GVBienLai.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GVBienLai.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GVBienLai_FocusedRowChanged_1);
            // 
            // gridColumnMALH
            // 
            this.gridColumnMALH.Caption = "Tên Lớp Học";
            this.gridColumnMALH.FieldName = "TENLOP";
            this.gridColumnMALH.Name = "gridColumnMALH";
            this.gridColumnMALH.Visible = true;
            this.gridColumnMALH.VisibleIndex = 0;
            // 
            // gridColumnMAHV
            // 
            this.gridColumnMAHV.Caption = "Họ Tên Học Viên";
            this.gridColumnMAHV.FieldName = "HOTENHV";
            this.gridColumnMAHV.Name = "gridColumnMAHV";
            this.gridColumnMAHV.Visible = true;
            this.gridColumnMAHV.VisibleIndex = 1;
            // 
            // gridColumnDIEM
            // 
            this.gridColumnDIEM.Caption = "Điểm";
            this.gridColumnDIEM.FieldName = "DIEM";
            this.gridColumnDIEM.Name = "gridColumnDIEM";
            this.gridColumnDIEM.Visible = true;
            this.gridColumnDIEM.VisibleIndex = 2;
            // 
            // gridColumnKQUA
            // 
            this.gridColumnKQUA.Caption = "Kết Quả";
            this.gridColumnKQUA.FieldName = "KQUA";
            this.gridColumnKQUA.Name = "gridColumnKQUA";
            this.gridColumnKQUA.Visible = true;
            this.gridColumnKQUA.VisibleIndex = 3;
            // 
            // gridColumnXEPLOAI
            // 
            this.gridColumnXEPLOAI.Caption = "Xếp Loại";
            this.gridColumnXEPLOAI.FieldName = "XEPLOAI";
            this.gridColumnXEPLOAI.Name = "gridColumnXEPLOAI";
            this.gridColumnXEPLOAI.Visible = true;
            this.gridColumnXEPLOAI.VisibleIndex = 4;
            // 
            // gridColumnTIENNOP
            // 
            this.gridColumnTIENNOP.Caption = "Tiền Nộp";
            this.gridColumnTIENNOP.FieldName = "TIENNOP";
            this.gridColumnTIENNOP.Name = "gridColumnTIENNOP";
            this.gridColumnTIENNOP.Visible = true;
            this.gridColumnTIENNOP.VisibleIndex = 5;
            // 
            // UC_BienLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GCBienLai);
            this.Controls.Add(this.panelControlHocVien);
            this.Controls.Add(this.ribbonStatusBarThongTin);
            this.Controls.Add(this.ribbonControlBienLai);
            this.Name = "UC_BienLai";
            this.Size = new System.Drawing.Size(820, 613);
            this.Load += new System.EventHandler(this.UC_BienLai_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlBienLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHocVien)).EndInit();
            this.panelControlHocVien.ResumeLayout(false);
            this.panelControlHocVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditTIENNOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditDIEM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKQUA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditXEPLOAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMAHV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMALH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCBienLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVBienLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlBienLai;
        private DevExpress.XtraBars.BarButtonItem btnAddNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnNewAdd;
        private DevExpress.XtraBars.BarListItem barListChinhSach;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonCongCu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageCongCu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupGiaoDien;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBarThongTin;
        private DevExpress.XtraEditors.PanelControl panelControlHocVien;
        private DevExpress.XtraEditors.TextEdit textEditXEPLOAI;
        private DevExpress.XtraEditors.TextEdit textEditMAHV;
        private DevExpress.XtraEditors.TextEdit textEditMALH;
        private DevExpress.XtraEditors.LabelControl labelControlXepLoai;
        private DevExpress.XtraEditors.LabelControl labelControlDiem;
        private DevExpress.XtraEditors.LabelControl labelControlMAHV;
        private DevExpress.XtraEditors.LabelControl labelControlMALH;
        private DevExpress.XtraEditors.LabelControl labelControlBienLai;
        private DevExpress.XtraGrid.GridControl GCBienLai;
        private DevExpress.XtraGrid.Views.Grid.GridView GVBienLai;
        private DevExpress.XtraEditors.TextEdit textEditKQUA;
        private DevExpress.XtraEditors.LabelControl labelControlTienNop;
        private DevExpress.XtraEditors.LabelControl labelControlKetQua;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMALH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMAHV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDIEM;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnKQUA;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnXEPLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTIENNOP;
        private DevExpress.XtraEditors.SpinEdit spinEditDIEM;
        private DevExpress.XtraEditors.SpinEdit spinEditTIENNOP;
    }
}
