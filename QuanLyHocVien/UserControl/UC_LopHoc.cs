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
    public partial class UC_LopHoc : XtraUserControl
    {
        private readonly LopHocBLL lhBLL = new LopHocBLL();
        private string malhOld = null;

        public UC_LopHoc()
        {
            InitializeComponent();
        }
        private void UC_LopHoc_Load_1(object sender, EventArgs e)
        {
            dataLoading();
            status(true);
        }

        private void dataLoading()
        {
            GCLopHoc.DataSource = lhBLL.GetListStaff();
            GVLopHoc.RefreshData();
        }

        private void Xoa_het()
        {
            textEditMALH.Text = "";
            textEditTenLop.Text = "";
            textEditMAMH.Text = "";
            textEditMAGV.Text = "";
            spinEditLTRG.EditValue = 0;
            spinEditSISODK.EditValue = null;
            textEditPHHOC.Text = "";
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
            malhOld = null;

            Xoa_het();
            status(false);
            textEditMALH.Focus();
        }
        private void GVLopHoc_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (btnSave.Enabled && btnCancel.Enabled)
                status(true);

            malhOld = GVLopHoc.GetFocusedRowCellValue("MALH")?.ToString()?.Trim();

            textEditMALH.Text = malhOld;
            textEditTenLop.Text = GVLopHoc.GetFocusedRowCellValue("TENLOP")?.ToString();
            textEditMAMH.Text = GVLopHoc.GetFocusedRowCellValue("MAMH")?.ToString();
            textEditMAGV.Text = GVLopHoc.GetFocusedRowCellValue("MAGV")?.ToString();

            var ltrg = GVLopHoc.GetFocusedRowCellValue("LTRG");
            spinEditLTRG.EditValue = (ltrg == null || ltrg == DBNull.Value) ? 0 : Convert.ToInt32(ltrg);

            var siso = GVLopHoc.GetFocusedRowCellValue("SISODK");
            spinEditSISODK.EditValue = (siso == null || siso == DBNull.Value) ? 0 : Convert.ToInt32(siso);

            textEditPHHOC.Text = GVLopHoc.GetFocusedRowCellValue("PHHOC")?.ToString();

            textEditMALH.Properties.ReadOnly = true;
        }
       
        private void btnCancel_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xoa_het();
            status(true);
        }

        // SAVE chỉ để THÊM MỚI
        private void btnSave_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string malh = (textEditMALH.Text ?? "").Trim();
                string tenlop = (textEditTenLop.Text ?? "").Trim();
                string mamh = (textEditMAMH.Text ?? "").Trim();
                string magv = (textEditMAGV.Text ?? "").Trim();
                string phhoc = (textEditPHHOC.Text ?? "").Trim();

                int ltrg = Convert.ToInt32(spinEditLTRG.EditValue ?? 0);
                int sisodk = Convert.ToInt32(spinEditSISODK.EditValue ?? 0);

                // check trùng MALH (giống Học viên)
                if (lhBLL.ExistsMALH(malh, out string errExists))
                {
                    XtraMessageBox.Show(errExists, "Save",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool ok = lhBLL.InsertLopHoc(malh, tenlop, mamh, magv, ltrg, sisodk, phhoc, out string err);
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
                if (string.IsNullOrWhiteSpace(malhOld))
                {
                    XtraMessageBox.Show("Bạn hãy chọn 1 lớp học để cập nhật.", "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string malh = malhOld;
                string tenlop = (textEditTenLop.Text ?? "").Trim();
                string mamh = (textEditMAMH.Text ?? "").Trim();
                string magv = (textEditMAGV.Text ?? "").Trim();
                string phhoc = (textEditPHHOC.Text ?? "").Trim();

                int ltrg = Convert.ToInt32(spinEditLTRG.EditValue ?? 0);
                int sisodk = Convert.ToInt32(spinEditSISODK.EditValue ?? 0);

                bool ok = lhBLL.UpdateLopHoc(malh, tenlop, mamh, magv, ltrg, sisodk, phhoc, out string err);
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
                string tenlop = (textEditTenLop.Text ?? "").Trim();

                if (string.IsNullOrWhiteSpace(malh))
                {
                    XtraMessageBox.Show("Vui lòng chọn 1 lớp học để xóa.", "Xóa",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var ans = XtraMessageBox.Show(
                    $"Bạn có chắc muốn xóa lớp: {tenlop} (MALH: {malh}) ?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (ans != DialogResult.Yes) return;

                int cntBL = lhBLL.CountBienLaiByLopHoc(malh);

                bool cascade = false;
                if (cntBL > 0)
                {
                    var ans2 = XtraMessageBox.Show(
                        $"Lớp này đang có {cntBL} biên lai.\n" +
                        $"Bạn có muốn xóa luôn các biên lai rồi xóa lớp không?",
                        "Có biên lai liên quan",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (ans2 != DialogResult.Yes) return;
                    cascade = true;
                }

                bool ok = lhBLL.DeleteLopHoc(malh, cascade, out string err);
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
    }
}

