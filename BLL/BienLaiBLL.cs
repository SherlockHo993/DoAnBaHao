using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DAL;
using DAL.Model;

namespace BLL
{
    public class BienLaiBLL
    {
        private readonly BienLaiDAL blDAL = new BienLaiDAL();

        public IEnumerable GetListStaff()
        {
            return blDAL.GetListStaff();
        }

        // Check trùng PK kép (MALH, MAHV) - giống ExistsMAHV bên học viên
        public bool ExistsBienLai(string malh, string mahv, out string err)
        {
            err = null;
            malh = (malh ?? "").Trim();
            mahv = (mahv ?? "").Trim();

            if (string.IsNullOrWhiteSpace(malh) || string.IsNullOrWhiteSpace(mahv))
            {
                err = "MALH/MAHV không hợp lệ.";
                return true;
            }

            if (blDAL.Exists(malh, mahv))
            {
                err = "Biên lai đã tồn tại (trùng MALH + MAHV).";
                return true;
            }
            return false;
        }

        public bool InsertBienLai(string malh, string mahv, decimal? diem, string kqua, string xeploai, decimal? tiennop, out string err)
        {
            err = null;
            try
            {
                malh = (malh ?? "").Trim();
                mahv = (mahv ?? "").Trim();
                kqua = (kqua ?? "").Trim();
                xeploai = (xeploai ?? "").Trim();
                // TIENNOP thường không có lẻ
                if (tiennop.HasValue) tiennop = Math.Round(tiennop.Value, 0);

                if (string.IsNullOrWhiteSpace(malh)) { err = "Vui lòng nhập MALH."; return false; }
                if (string.IsNullOrWhiteSpace(mahv)) { err = "Vui lòng nhập MAHV."; return false; }

                if (!blDAL.ExistsLopHoc(malh)) { err = "MALH không tồn tại trong bảng LOPHOC."; return false; }
                if (!blDAL.ExistsHocVien(mahv)) { err = "MAHV không tồn tại trong bảng HOCVIEN."; return false; }

                if (blDAL.Exists(malh, mahv)) { err = "Biên lai đã tồn tại (trùng MALH + MAHV)."; return false; }

                if (diem.HasValue && (diem.Value < 0 || diem.Value > 10)) { err = "Điểm phải từ 0 đến 10."; return false; }
                if (tiennop.HasValue && tiennop.Value < 0) { err = "Tiền nộp không hợp lệ."; return false; }
                if (!string.IsNullOrEmpty(kqua) && kqua.Length > 10) { err = "KQUA tối đa 10 ký tự."; return false; }
                if (!string.IsNullOrEmpty(xeploai) && xeploai.Length > 1) { err = "XEPLOAI chỉ 1 ký tự."; return false; }

                var bl = new BIENLAI
                {
                    MALH = malh,
                    MAHV = mahv,
                    DIEM = diem,
                    KQUA = string.IsNullOrWhiteSpace(kqua) ? null : kqua,
                    XEPLOAI = string.IsNullOrWhiteSpace(xeploai) ? null : xeploai,
                    TIENNOP = tiennop
                };

                blDAL.Insert(bl);
                return true;
            }
            catch (Exception ex)
            {
                err = "Lỗi thêm biên lai: " + ex.Message;
                return false;
            }
        }

        // Update KHÔNG đổi khóa (MALH, MAHV)
        public bool UpdateBienLai(string malh, string mahv, decimal? diem, string kqua, string xeploai, decimal? tiennop, out string err)
        {
            err = null;
            try
            {
                malh = (malh ?? "").Trim();
                mahv = (mahv ?? "").Trim();
                kqua = (kqua ?? "").Trim();
                xeploai = (xeploai ?? "").Trim();
                if (tiennop.HasValue) tiennop = Math.Round(tiennop.Value, 0);

                if (string.IsNullOrWhiteSpace(malh) || string.IsNullOrWhiteSpace(mahv))
                {
                    err = "Thiếu MALH/MAHV để cập nhật.";
                    return false;
                }

                if (diem.HasValue && (diem.Value < 0 || diem.Value > 10)) { err = "Điểm phải từ 0 đến 10."; return false; }
                if (tiennop.HasValue && tiennop.Value < 0) { err = "Tiền nộp không hợp lệ."; return false; }
                if (!string.IsNullOrEmpty(kqua) && kqua.Length > 10) { err = "KQUA tối đa 10 ký tự."; return false; }
                if (!string.IsNullOrEmpty(xeploai) && xeploai.Length > 1) { err = "XEPLOAI chỉ 1 ký tự."; return false; }

                var bl = new BIENLAI
                {
                    MALH = malh,
                    MAHV = mahv,
                    DIEM = diem,
                    KQUA = string.IsNullOrWhiteSpace(kqua) ? null : kqua,
                    XEPLOAI = string.IsNullOrWhiteSpace(xeploai) ? null : xeploai,
                    TIENNOP = tiennop
                };

                blDAL.Update(bl);
                return true;
            }
            catch (Exception ex)
            {
                err = "Lỗi cập nhật biên lai: " + ex.Message;
                return false;
            }
        }

        public bool DeleteBienLai(string malh, string mahv, out string err)
        {
            err = null;
            try
            {
                malh = (malh ?? "").Trim();
                mahv = (mahv ?? "").Trim();

                if (string.IsNullOrWhiteSpace(malh) || string.IsNullOrWhiteSpace(mahv))
                {
                    err = "Thiếu MALH/MAHV để xóa.";
                    return false;
                }

                blDAL.Delete(malh, mahv);
                return true;
            }
            catch (Exception ex)
            {
                err = "Lỗi xóa biên lai: " + ex.Message;
                return false;
            }
        }
    }
}

