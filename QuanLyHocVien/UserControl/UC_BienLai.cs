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
using System.IO;
using System.Diagnostics;
using DevExpress.XtraBars;

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
            textEditKQUA.Properties.ReadOnly = true;
            textEditXEPLOAI.Properties.ReadOnly = true;
            textEditKQUA.TabStop = false;
            textEditXEPLOAI.TabStop = false;
            spinEditDIEM.Properties.MinValue = 0;
            spinEditDIEM.Properties.MaxValue = 10;
            spinEditDIEM.Properties.Increment = 0.1m;

            spinEditDIEM.EditValueChanged += spinEditDIEM_EditValueChanged;

            dataLoading();
            status(true);
        }

        private void spinEditDIEM_EditValueChanged(object sender, EventArgs e)
        {
            ApplyKQXLFromDiem();
        }

        private void ApplyKQXLFromDiem()
        {
            decimal? diem = null;
            if (spinEditDIEM.EditValue != null)
                diem = Convert.ToDecimal(spinEditDIEM.EditValue);

            if (!diem.HasValue)
            {
                textEditKQUA.Text = "";
                textEditXEPLOAI.Text = "";
                return;
            }

            // KQ: ĐẬU nếu >= 7
            textEditKQUA.Text = (diem.Value >= 7m) ? "ĐẬU" : "RỚT";

            // XL: A/B/C/D
            char xl;
            if (diem.Value >= 8.5m) xl = 'A';
            else if (diem.Value >= 7.0m) xl = 'B';
            else if (diem.Value >= 5.0m) xl = 'C';
            else xl = 'D';

            textEditXEPLOAI.Text = xl.ToString();
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



        private void barButtonItemKQDat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new frmThongKeTheoKQUA("ĐẬU"))
                f.ShowDialog();
        }

        private void barButtonItemKQRot_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new frmThongKeTheoKQUA("RỚT"))
                f.ShowDialog();
        }

        private void barBtnMoPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "Help", "HuongDan.pdf");

            if (!File.Exists(pdfPath))
            {
                XtraMessageBox.Show("Không tìm thấy file hướng dẫn:\n" + pdfPath,
                    "Help", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Process.Start(new ProcessStartInfo(pdfPath) { UseShellExecute = true });
        }

        private void barBtnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show(
                "PHẦN MỀM QUẢN LÝ HỌC VIÊN\n" +
                "Version: 1.0\n" +
                "DevExpress WinForms\n" +
                "© 2026",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void barBtnContact_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string url = "https://zalo.me/g/pwdmce007"; // đổi link của bạn
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void barBtnHuongDan_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new frmHelp())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new frmTongTienTheoLop())
            {
                f.ShowDialog();
            }
        }
    }
}
