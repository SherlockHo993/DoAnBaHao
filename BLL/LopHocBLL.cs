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
    public class LopHocBLL
    {
        private readonly LopHocDAL lhDAL = new LopHocDAL();

        public IEnumerable GetListStaff()
        {
            return lhDAL.GetListStaff();
        }

        public bool ExistsMALH(string malh, out string err)
        {
            err = null;
            malh = (malh ?? "").Trim();

            if (string.IsNullOrWhiteSpace(malh))
            {
                err = "MALH không không được để trống.";
                return true;
            }

            if (lhDAL.Exists(malh))
            {
                err = "MALH đã tồn tại (trùng với lớp học khác).";
                return true;
            }
            return false;
        }

        public bool InsertLopHoc(string malh, string tenlop, string mamh, string magv,
                                int ltrg, int sisodk, string phhoc, out string err)
        {
            err = null;
            try
            {
                malh = (malh ?? "").Trim();
                tenlop = (tenlop ?? "").Trim();
                mamh = (mamh ?? "").Trim();
                magv = (magv ?? "").Trim();
                phhoc = (phhoc ?? "").Trim();

                if (string.IsNullOrWhiteSpace(malh)) { err = "Vui lòng nhập MALH."; return false; }
                if (string.IsNullOrWhiteSpace(tenlop)) { err = "Vui lòng nhập Tên lớp."; return false; }
                if (string.IsNullOrWhiteSpace(mamh)) { err = "Vui lòng nhập MAMH."; return false; }
                if (string.IsNullOrWhiteSpace(phhoc)) { err = "Vui lòng nhập Phòng học."; return false; }

                if (lhDAL.Exists(malh)) { err = "MALH đã tồn tại."; return false; }

                if (!string.IsNullOrWhiteSpace(magv) && !lhDAL.ExistsGiaoVien(magv))
                {
                    err = "MAGV không tồn tại trong bảng GIAOVIEN.";
                    return false;
                }

                var lh = new LOPHOC
                {
                    MALH = malh,
                    TENLOP = tenlop,
                    MAMH = mamh,
                    MAGV = string.IsNullOrWhiteSpace(magv) ? null : magv,
                    LTRG = ltrg,
                    SISODK = sisodk,
                    PHHOC = phhoc
                };

                lhDAL.Insert(lh);
                return true;
            }
            catch (Exception ex)
            {
                err = "Lỗi thêm lớp học: " + ex.Message;
                return false;
            }
        }

        public bool UpdateLopHoc(string malh, string tenlop, string mamh, string magv,
                                int ltrg, int sisodk, string phhoc, out string err)
        {
            err = null;
            try
            {
                malh = (malh ?? "").Trim();
                tenlop = (tenlop ?? "").Trim();
                mamh = (mamh ?? "").Trim();
                magv = (magv ?? "").Trim();
                phhoc = (phhoc ?? "").Trim();

                if (string.IsNullOrWhiteSpace(malh)) { err = "Thiếu MALH để cập nhật."; return false; }
                if (string.IsNullOrWhiteSpace(tenlop)) { err = "Vui lòng nhập Tên lớp."; return false; }
                if (string.IsNullOrWhiteSpace(mamh)) { err = "Vui lòng nhập MAMH."; return false; }
                if (string.IsNullOrWhiteSpace(phhoc)) { err = "Vui lòng nhập Phòng học."; return false; }

                if (!string.IsNullOrWhiteSpace(magv) && !lhDAL.ExistsGiaoVien(magv))
                {
                    err = "MAGV không tồn tại trong bảng GIAOVIEN.";
                    return false;
                }

                var lh = new LOPHOC
                {
                    MALH = malh,
                    TENLOP = tenlop,
                    MAMH = mamh,
                    MAGV = string.IsNullOrWhiteSpace(magv) ? null : magv,
                    LTRG = ltrg,
                    SISODK = sisodk,
                    PHHOC = phhoc
                };

                lhDAL.Update(lh);
                return true;
            }
            catch (Exception ex)
            {
                err = "Lỗi cập nhật lớp học: " + ex.Message;
                return false;
            }
        }

        public int CountBienLaiByLopHoc(string malh)
        {
            return lhDAL.CountBienLaiByLopHoc(malh);
        }

        public bool DeleteLopHoc(string malh, bool cascadeBienLai, out string err)
        {
            return lhDAL.DeleteLopHoc(malh, cascadeBienLai, out err);
        }
    }
}

