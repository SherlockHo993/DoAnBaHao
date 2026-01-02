using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Model;

namespace BLL
{
    public class HocVienBLL
    {
        private readonly HocVienDAL hvDAL = new HocVienDAL();
        public IEnumerable GetListStaff()
        {
            return hvDAL.GetListStaff();
        }

        public bool InsertHocVien(string mahv, string ho, string ten, DateTime ntns, string nnghiep, out string err)
        {
            err = null;
            try
            {
                mahv = (mahv ?? "").Trim();
                ho = (ho ?? "").Trim();
                ten = (ten ?? "").Trim();
                nnghiep = (nnghiep ?? "").Trim();

                if (string.IsNullOrWhiteSpace(mahv)) { err = "Vui lòng nhập MAHV."; return false; }
                if (string.IsNullOrWhiteSpace(ho)) { err = "Vui lòng nhập Họ."; return false; }
                if (string.IsNullOrWhiteSpace(ten)) { err = "Vui lòng nhập Tên."; return false; }

                if (hvDAL.Exists(mahv))
                {
                    err = "MAHV đã tồn tại.";
                    return false;
                }

                var hv = new HOCVIEN
                {
                    MAHV = mahv,
                    HO = ho,
                    TEN = ten,
                    NTNS = ntns,
                    NNGHIEP = nnghiep
                };

                hvDAL.Insert(hv);
                return true;
            }
            catch (Exception ex)
            {
                err = "Lỗi thêm học viên: " + ex.Message;
                return false;
            }
        }

        public bool UpdateHocVien(string mahv, string ho, string ten, DateTime ntns, string nnghiep, out string err)
        {
            err = null;
            try
            {
                mahv = (mahv ?? "").Trim();
                ho = (ho ?? "").Trim();
                ten = (ten ?? "").Trim();
                nnghiep = (nnghiep ?? "").Trim();

                if (string.IsNullOrWhiteSpace(mahv)) { err = "Thiếu MAHV để cập nhật."; return false; }
                if (string.IsNullOrWhiteSpace(ho)) { err = "Vui lòng nhập Họ."; return false; }
                if (string.IsNullOrWhiteSpace(ten)) { err = "Vui lòng nhập Tên."; return false; }

                var hv = new HOCVIEN
                {
                    MAHV = mahv,
                    HO = ho,
                    TEN = ten,
                    NTNS = ntns,
                    NNGHIEP = nnghiep
                };

                hvDAL.Update(hv);
                return true;
            }
            catch (Exception ex)
            {
                err = "Lỗi cập nhật học viên: " + ex.Message;
                return false;
            }
        }

        public bool ExistsMAHV(string mahv, out string err)
        {
            err = null;
            mahv = (mahv ?? "").Trim();

            if (string.IsNullOrWhiteSpace(mahv))
            {
                err = "MAHV không hợp lệ.";
                return true;
            }

            if (hvDAL.Exists(mahv))
            {
                err = "MAHV đã tồn tại (trùng với học viên khác).";
                return true;
            }
            return false;
        }
        public int CountBienLaiByHocVien(string mahv)
        {
            return hvDAL.CountBienLaiByHocVien(mahv);
        }

        public bool DeleteHocVien(string mahv, bool cascadeBienLai, out string err)
        {
            return hvDAL.DeleteHocVien(mahv, cascadeBienLai, out err);
        }

    }
}
