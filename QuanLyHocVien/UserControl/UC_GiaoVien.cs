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
using DAL;
using System.IO;
using System.Diagnostics;

namespace QuanLyHocVien.UserControl
{
    public partial class UC_GiaoVien : XtraUserControl
    {
        private readonly GiaoVienBLL gvBLL = new GiaoVienBLL();
        private string magvOld = null;

        public UC_GiaoVien()
        {
            InitializeComponent();
        }

        private void UC_GiaoVien_Load(object sender, EventArgs e)
        {
            dataLoading();
            status(true);
        }

        private void dataLoading()
        {
            GCGiaoVien.DataSource = gvBLL.GetListStaff();
            GVGiaoVien.RefreshData(); // chú ý: RefreshData() là của GridView
        }

        private void Xoa_het()
        {
            textEditMAGV.Text = "";
            textEditHoTen.Text = "";
            dateEditNTNS.EditValue = null;
            textEditDiaChi.Text = "";
        }

        // y=true: bình thường (New/Update/Delete bật) | y=false: thêm mới (Save/Cancel bật)
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
            magvOld = null;
            textEditMAGV.Properties.ReadOnly = false;
            Xoa_het();
            status(false);
            textEditMAGV.Focus();
        }

        private void GVGiaoVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // đang AddNew mà chọn dòng khác => về trạng thái bình thường
            if (btnSave.Enabled && btnCancel.Enabled)
                status(true);
            magvOld = GVGiaoVien.GetFocusedRowCellValue("MAGV")?.ToString()?.Trim();
            textEditMAGV.Text = magvOld;
            textEditHoTen.Text = GVGiaoVien.GetFocusedRowCellValue("HOTEN")?.ToString()?.Trim();
            textEditDiaChi.Text = GVGiaoVien.GetFocusedRowCellValue("DIACHI")?.ToString()?.Trim();

            var ns = GVGiaoVien.GetFocusedRowCellValue("NTNS");
            dateEditNTNS.EditValue = (ns == null || ns == DBNull.Value) ? null : ns;
            textEditMAGV.Properties.ReadOnly = true;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xoa_het();
            status(true);
        }

        // SAVE chỉ để THÊM MỚI
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string magv = (textEditMAGV.Text ?? "").Trim();
                string hoten = (textEditHoTen.Text ?? "").Trim();
                string diachi = (textEditDiaChi.Text ?? "").Trim();

                DateTime? ntns = null;
                if (dateEditNTNS.EditValue != null)
                    ntns = Convert.ToDateTime(dateEditNTNS.EditValue).Date;

                bool ok = gvBLL.InsertGiaoVien(magv, hoten, ntns, diachi, out string err);
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

        // UPDATE chỉ để CẬP NHẬT
        private void btnUpdate_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(magvOld))
                {
                    XtraMessageBox.Show("Bạn hãy chọn 1 giáo viên để cập nhật.", "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string magv = magvOld; 
                string hoten = (textEditHoTen.Text ?? "").Trim();
                string diachi = (textEditDiaChi.Text ?? "").Trim();

                DateTime? ntns = null;
                if (dateEditNTNS.EditValue != null)
                    ntns = Convert.ToDateTime(dateEditNTNS.EditValue).Date;

                bool ok = gvBLL.UpdateGiaoVien(magv, hoten, ntns, diachi, out string err);
                if (!ok)
                {
                    XtraMessageBox.Show(err, "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                XtraMessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                GCGiaoVien.DataSource = gvBLL.GetListStaff();
                GVGiaoVien.RefreshData();
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
                string magv = (textEditMAGV.Text ?? "").Trim();
                string hoten = (textEditHoTen.Text ?? "").Trim();

                if (string.IsNullOrWhiteSpace(magv))
                {
                    XtraMessageBox.Show("Vui lòng chọn 1 giáo viên để xóa.", "Xóa",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var ans = XtraMessageBox.Show(
                    $"Bạn có chắc muốn xóa giáo viên: {hoten} (MAGV: {magv}) ?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (ans != DialogResult.Yes) return;

                int cntLH = gvBLL.CountLopHocByGiaoVien(magv);

                bool cascade = false;
                if (cntLH > 0)
                {
                    var ans2 = XtraMessageBox.Show(
                        $"Giáo viên này đang được phân công {cntLH} lớp.\n" +
                        $"Bạn có muốn gỡ giáo viên khỏi các lớp (MAGV = NULL) rồi mới xóa không?",
                        "Có lớp học liên quan",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (ans2 != DialogResult.Yes) return;

                    cascade = true;
                }

                bool ok = gvBLL.DeleteGiaoVien(magv, cascade, out string err);
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

        private void barButtonItemBaoCaoGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new frmThongKeGiaoVien())
            {
                f.ShowDialog();
            }
        }

        private void barButtonItemPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void barButtonItemAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show(
           "PHẦN MỀM QUẢN LÝ HỌC VIÊN\n" +
           "Version: 1.0\n" +
           "Designer: Đắc Việt Sherlock\n" +
           "© Copy Right Shelock 2026\n",
           "About",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information
           );
        }

        private void barButtonItemLienHe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string url = "https://zalo.me/g/pwdmce007";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void barButtonItemHuongDan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new frmHelp())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }
    }
}

