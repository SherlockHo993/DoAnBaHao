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

        private static void CalcFromDiem(decimal? diem, out string kqua, out string xeploai)
        {
            if (!diem.HasValue)
            {
                kqua = null;
                xeploai = null;
                return;
            }


            kqua = (diem.Value >= 7m) ? "ĐẬU" : "RỚT";

            char xl;
            if (diem.Value >= 8.5m) xl = 'A';
            else if (diem.Value >= 7.0m) xl = 'B';
            else if (diem.Value >= 5.0m) xl = 'C';
            else xl = 'D';

            xeploai = xl.ToString(); 
        }

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

                if (tiennop.HasValue) tiennop = Math.Round(tiennop.Value, 0);

                if (string.IsNullOrWhiteSpace(malh)) { err = "Vui lòng nhập MALH."; return false; }
                if (string.IsNullOrWhiteSpace(mahv)) { err = "Vui lòng nhập MAHV."; return false; }

                if (!blDAL.ExistsLopHoc(malh)) { err = "MALH không tồn tại trong bảng LOPHOC."; return false; }
                if (!blDAL.ExistsHocVien(mahv)) { err = "MAHV không tồn tại trong bảng HOCVIEN."; return false; }

                if (blDAL.Exists(malh, mahv)) { err = "Biên lai đã tồn tại (trùng MALH + MAHV)."; return false; }

                if (diem.HasValue && (diem.Value < 0 || diem.Value > 10)) { err = "Điểm phải từ 0 đến 10."; return false; }
                if (tiennop.HasValue && tiennop.Value < 0) { err = "Tiền nộp không hợp lệ."; return false; }

                CalcFromDiem(diem, out kqua, out xeploai);

                var bl = new BIENLAI
                {
                    MALH = malh,
                    MAHV = mahv,
                    DIEM = diem,
                    KQUA = kqua,           
                    XEPLOAI = xeploai,     
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

        public bool UpdateBienLai(string malh, string mahv, decimal? diem, string kqua, string xeploai, decimal? tiennop, out string err)
        {
            err = null;
            try
            {
                malh = (malh ?? "").Trim();
                mahv = (mahv ?? "").Trim();

                if (tiennop.HasValue) tiennop = Math.Round(tiennop.Value, 0);

                if (string.IsNullOrWhiteSpace(malh) || string.IsNullOrWhiteSpace(mahv))
                {
                    err = "Thiếu MALH/MAHV để cập nhật.";
                    return false;
                }

                if (diem.HasValue && (diem.Value < 0 || diem.Value > 10)) { err = "Điểm phải từ 0 đến 10."; return false; }
                if (tiennop.HasValue && tiennop.Value < 0) { err = "Tiền nộp không hợp lệ."; return false; }

                CalcFromDiem(diem, out kqua, out xeploai);

                var bl = new BIENLAI
                {
                    MALH = malh,
                    MAHV = mahv,
                    DIEM = diem,
                    KQUA = kqua,
                    XEPLOAI = xeploai,
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
                    err = "Thiếu MALH hoặc MAHV để xóa.";
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


