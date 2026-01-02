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

namespace QuanLyHocVien.UserControl
{
    public partial class UC_HocVien : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly HocVienBLL hvBLL = new HocVienBLL();
        private string mahvOld = null;
        public UC_HocVien()
        {
            InitializeComponent();
        }

        private void UC_HocVien_Load(object sender, EventArgs e)
        {
            dataLoading();
            status(true);
        }

        private void dataLoading()
        {
            GCHocVien.DataSource = hvBLL.GetListStaff();
            GVHocVien.RefreshData();
        }

        private void Xoa_het()
        {
            textEditMAHV.Text = "";
            textEditHo.Text = "";
            textEditTen.Text = "";
            dateEditNTNS.EditValue = null;
            textEditNNGHIEP.Text = "";
        }

        private void status(bool y)
        {
            btnNewAdd.Enabled = y;
            btnUpdate.Enabled = y;
            btnDelete.Enabled = y;
            btnSave.Enabled = !y;
            btnCancel.Enabled = !y;
        }

        private void btnNewAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textEditMAHV.Properties.ReadOnly = false;
            mahvOld = null;
            Xoa_het();
            status(false);
            textEditMAHV.Focus();
        }

        private void GVHocVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (btnSave.Enabled == true && btnCancel.Enabled == true)
            {
                status(true);
            }
            mahvOld = GVHocVien.GetFocusedRowCellValue("MAHV")?.ToString()?.Trim();
            textEditMAHV.Text = mahvOld;
            textEditHo.Text = GVHocVien.GetFocusedRowCellValue("HO")?.ToString().Trim();
            textEditTen.Text = GVHocVien.GetFocusedRowCellValue("TEN")?.ToString().Trim();
            textEditNNGHIEP.Text = GVHocVien.GetFocusedRowCellValue("NNGHIEP")?.ToString().Trim();

            var ngaySinh = GVHocVien.GetFocusedRowCellValue("NTNS");
            dateEditNTNS.EditValue = (ngaySinh == null || ngaySinh == DBNull.Value) ? null : ngaySinh;
            textEditMAHV.Properties.ReadOnly = true;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xoa_het();
            status(true);
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string mahv = (textEditMAHV.Text ?? "").Trim();
                string ho = (textEditHo.Text ?? "").Trim();
                string ten = (textEditTen.Text ?? "").Trim();
                string nnghiep = (textEditNNGHIEP.Text ?? "").Trim();

                if (dateEditNTNS.EditValue == null)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn ngày sinh.", "Lưu",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateEditNTNS.Focus();
                    return;
                }

                DateTime ntns = Convert.ToDateTime(dateEditNTNS.EditValue).Date;
                string err;
                bool ok = hvBLL.InsertHocVien(mahv, ho, ten, ntns, nnghiep, out err);
                if (!ok)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(err, "Lưu Thông Tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataLoading();
                status(true);
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Có lỗi khi lưu:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mahvOld))
                {
                    XtraMessageBox.Show("Bạn hãy chọn 1 học viên để cập nhật.", "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mahv = mahvOld;
                string ho = (textEditHo.Text ?? "").Trim();
                string ten = (textEditTen.Text ?? "").Trim();
                string nnghiep = (textEditNNGHIEP.Text ?? "").Trim();

                if (dateEditNTNS.EditValue == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn ngày sinh.", "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime ntns = Convert.ToDateTime(dateEditNTNS.EditValue).Date;

                bool ok = hvBLL.UpdateHocVien(mahv, ho, ten, ntns, nnghiep, out string err);
                if (!ok)
                {
                    XtraMessageBox.Show(err, "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                XtraMessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                GCHocVien.DataSource = hvBLL.GetListStaff();
                GVHocVien.RefreshData();
                status(true);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi Update:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                string mahv = (textEditMAHV.Text ?? "").Trim();
                string ho = (textEditHo.Text ?? "").Trim();
                string ten = (textEditTen.Text ?? "").Trim();

                if (string.IsNullOrWhiteSpace(mahv))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(
                        "Vui lòng chọn 1 học viên để xóa.",
                        "Xóa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var ans = DevExpress.XtraEditors.XtraMessageBox.Show(
                    $"Bạn có chắc muốn xóa học viên: {ho} {ten} (MAHV: {mahv}) ?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (ans != DialogResult.Yes) return;

                int cntBL = hvBLL.CountBienLaiByHocVien(mahv);

                bool cascade = false;
                if (cntBL > 0)
                {
                    var ans2 = DevExpress.XtraEditors.XtraMessageBox.Show(
                        $"Học viên này đang có {cntBL} biên lai.\n" +
                        $"Bạn có muốn xóa luôn các biên lai rồi xóa học viên không?",
                        "Có biên lai liên quan",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (ans2 != DialogResult.Yes) return;

                    cascade = true;
                }

                bool ok = hvBLL.DeleteHocVien(mahv, cascade, out string err);
                if (!ok)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(err, "Xóa",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DevExpress.XtraEditors.XtraMessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataLoading();
                status(true);

            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Có lỗi khi xóa:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
