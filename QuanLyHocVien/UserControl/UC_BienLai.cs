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
    public partial class UC_BienLai : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly BienLaiBLL blBLL = new BienLaiBLL();

        private string malhOld = null;
        private string mahvOld = null;

        public UC_BienLai()
        {
            InitializeComponent();
        }

        private void UC_BienLai_Load_1(object sender, EventArgs e)
        {
            dataLoading();
            status(true);
        }

        private void dataLoading()
        {
            GCBienLai.DataSource = blBLL.GetListStaff();
            GVBienLai.RefreshData();
        }

        private void Xoa_het()
        {
            textEditMALH.Text = "";
            textEditMAHV.Text = "";
            spinEditDIEM.EditValue = null;
            textEditKQUA.Text = "";
            textEditXEPLOAI.Text = "";
            spinEditTIENNOP.EditValue = null;
        }

        private void status(bool y)
        {
            btnNewAdd.Enabled = y;
            btnUpdate.Enabled = y;
            btnDelete.Enabled = y;
            btnSave.Enabled = !y;
            btnCancel.Enabled = !y;
        }
        private void btnNewAdd_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textEditMALH.Properties.ReadOnly = false;
            textEditMAHV.Properties.ReadOnly = false;

            malhOld = null;
            mahvOld = null;

            Xoa_het();
            status(false);
            textEditMALH.Focus();
        }
        private void GVBienLai_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (btnSave.Enabled && btnCancel.Enabled)
                status(true);

            malhOld = GVBienLai.GetFocusedRowCellValue("MALH")?.ToString()?.Trim();
            mahvOld = GVBienLai.GetFocusedRowCellValue("MAHV")?.ToString()?.Trim();

            textEditMALH.Text = malhOld;
            textEditMAHV.Text = mahvOld;

            var diem = GVBienLai.GetFocusedRowCellValue("DIEM");
            spinEditDIEM.EditValue = (diem == null || diem == DBNull.Value) ? null : diem;

            textEditKQUA.Text = GVBienLai.GetFocusedRowCellValue("KQUA")?.ToString();
            textEditXEPLOAI.Text = GVBienLai.GetFocusedRowCellValue("XEPLOAI")?.ToString();

            var tien = GVBienLai.GetFocusedRowCellValue("TIENNOP");
            spinEditTIENNOP.EditValue = (tien == null || tien == DBNull.Value) ? null : tien;

            textEditMALH.Properties.ReadOnly = true;
            textEditMAHV.Properties.ReadOnly = true;
        }

        private void btnCancel_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xoa_het();
            status(true);
        }

        private void btnSave_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string malh = (textEditMALH.Text ?? "").Trim();
                string mahv = (textEditMAHV.Text ?? "").Trim();

                decimal? diem = null;
                if (spinEditDIEM.EditValue != null)
                    diem = Convert.ToDecimal(spinEditDIEM.EditValue);

                string kqua = (textEditKQUA.Text ?? "").Trim();
                string xeploai = (textEditXEPLOAI.Text ?? "").Trim();

                decimal? tiennop = null;
                if (spinEditTIENNOP.EditValue != null)
                    tiennop = Convert.ToDecimal(spinEditTIENNOP.EditValue);

                if (blBLL.ExistsBienLai(malh, mahv, out string errExists))
                {
                    XtraMessageBox.Show(errExists, "Save",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool ok = blBLL.InsertBienLai(malh, mahv, diem, kqua, xeploai, tiennop, out string err);
                if (!ok)
                {
                    XtraMessageBox.Show(err, "Lưu Thông Tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                XtraMessageBox.Show("Lưu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataLoading();
                status(true);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Có lỗi khi lưu:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(malhOld) || string.IsNullOrWhiteSpace(mahvOld))
                {
                    XtraMessageBox.Show("Bạn hãy chọn 1 biên lai để cập nhật.", "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string malh = malhOld;
                string mahv = mahvOld;

                decimal? diem = null;
                if (spinEditDIEM.EditValue != null)
                    diem = Convert.ToDecimal(spinEditDIEM.EditValue);

                string kqua = (textEditKQUA.Text ?? "").Trim();
                string xeploai = (textEditXEPLOAI.Text ?? "").Trim();

                decimal? tiennop = null;
                if (spinEditTIENNOP.EditValue != null)
                    tiennop = Convert.ToDecimal(spinEditTIENNOP.EditValue);

                bool ok = blBLL.UpdateBienLai(malh, mahv, diem, kqua, xeploai, tiennop, out string err);
                if (!ok)
                {
                    XtraMessageBox.Show(err, "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                XtraMessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataLoading();
                status(true);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi Update:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string malh = (textEditMALH.Text ?? "").Trim();
                string mahv = (textEditMAHV.Text ?? "").Trim();

                if (string.IsNullOrWhiteSpace(malh) || string.IsNullOrWhiteSpace(mahv))
                {
                    XtraMessageBox.Show("Vui lòng chọn 1 biên lai để xóa.", "Xóa",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var ans = XtraMessageBox.Show(
                    $"Bạn có chắc muốn xóa biên lai (MALH: {malh}, MAHV: {mahv}) ?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (ans != DialogResult.Yes) return;

                bool ok = blBLL.DeleteBienLai(malh, mahv, out string err);
                if (!ok)
                {
                    XtraMessageBox.Show(err, "Xóa",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                XtraMessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataLoading();
                status(true);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Có lỗi khi xóa:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThongKeTongTienTheoLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new frmTongTienTheoLop())
            {
                f.ShowDialog();
            }
        }

        private void barCheckItem3_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new frmTongTienTheoLop())
            {
                f.ShowDialog();
            }
        }

        private void barCheckDiem_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var item = e.Item as DevExpress.XtraBars.BarCheckItem;
            if (item == null) return;
            if (!item.Checked) return;

            using (var f = new frmThongKeTheoKQUA("ĐẬU"))
                f.ShowDialog();
        }
    }
}
