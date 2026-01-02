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
    public class GiaoVienBLL
    {
        private readonly GiaoVienDAL gvDAL = new GiaoVienDAL();

        public IEnumerable GetListStaff()
        {
            return gvDAL.GetListStaff();
        }

        public bool InsertGiaoVien(string magv, string hoten, DateTime? ntns, string diachi, out string err)
        {
            err = null;
            try
            {
                magv = (magv ?? "").Trim();
                hoten = (hoten ?? "").Trim();
                diachi = (diachi ?? "").Trim();

                if (string.IsNullOrWhiteSpace(magv)) { err = "Vui lòng nhập MAGV."; return false; }
                if (string.IsNullOrWhiteSpace(hoten)) { err = "Vui lòng nhập Họ tên."; return false; }

                if (gvDAL.Exists(magv))
                {
                    err = "MAGV đã tồn tại.";
                    return false;
                }

                var gv = new GIAOVIEN
                {
                    MAGV = magv,
                    HOTEN = hoten,
                    NTNS = ntns,
                    DIACHI = diachi
                };

                gvDAL.Insert(gv);
                return true;
            }
            catch (Exception ex)
            {
                err = "Lỗi thêm giáo viên: " + ex.Message;
                return false;
            }
        }

        public bool UpdateGiaoVien(string magv, string hoten, DateTime? ntns, string diachi, out string err)
        {
            err = null;
            try
            {
                magv = (magv ?? "").Trim();
                hoten = (hoten ?? "").Trim();
                diachi = (diachi ?? "").Trim();

                if (string.IsNullOrWhiteSpace(magv)) { err = "Thiếu MAGV để cập nhật."; return false; }
                if (string.IsNullOrWhiteSpace(hoten)) { err = "Vui lòng nhập Họ tên."; return false; }

                var gv = new GIAOVIEN
                {
                    MAGV = magv,
                    HOTEN = hoten,
                    NTNS = ntns,
                    DIACHI = diachi
                };

                gvDAL.Update(gv);
                return true;
            }
            catch (Exception ex)
            {
                err = "Lỗi cập nhật giáo viên: " + ex.Message;
                return false;
            }
        }
        public bool ExistsMAGV(string magv, out string err)
        {
            err = null;
            magv = (magv ?? "").Trim();

            if (string.IsNullOrWhiteSpace(magv))
            {
                err = "MAGV không hợp lệ.";
                return true;
            }

            if (gvDAL.Exists(magv))
            {
                err = "MAGV đã tồn tại (trùng với giáo viên khác).";
                return true;
            }
            return false;
        }


        public int CountLopHocByGiaoVien(string magv)
        {
            return gvDAL.CountLopHocByGiaoVien(magv);
        }

        public bool DeleteGiaoVien(string magv, bool cascadeLopHoc, out string err)
        {
            return gvDAL.DeleteGiaoVien(magv, cascadeLopHoc, out err);
        }
    }
}

