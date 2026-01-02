using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DAL.Model;

namespace DAL
{
    public class LopHocDAL
    {
        private readonly QLHVContextDB db = new QLHVContextDB();

        public IEnumerable GetListStaff()
        {
            var list = (from lh in db.LOPHOCs
                        select new
                        {
                            lh.MALH,
                            lh.TENLOP,
                            lh.MAMH,
                            lh.MAGV,
                            lh.LTRG,
                            lh.SISODK,
                            lh.PHHOC
                        }).ToList();
            return list;
        }

        public bool Exists(string malh)
        {
            malh = (malh ?? "").Trim();
            using (var db = new QLHVContextDB())
            {
                return db.LOPHOCs.Any(x => x.MALH == malh);
            }
        }

        public bool ExistsGiaoVien(string magv)
        {
            magv = (magv ?? "").Trim();
            if (string.IsNullOrWhiteSpace(magv)) return true; // MAGV cho phép null
            using (var db = new QLHVContextDB())
            {
                return db.GIAOVIENs.Any(x => x.MAGV == magv);
            }
        }

        public void Insert(LOPHOC lh)
        {
            using (var db = new QLHVContextDB())
            {
                db.LOPHOCs.Add(lh);
                db.SaveChanges();
            }
        }

        public void Update(LOPHOC lh)
        {
            using (var db = new QLHVContextDB())
            {
                var old = db.LOPHOCs.FirstOrDefault(x => x.MALH == lh.MALH);
                if (old == null) throw new Exception("Không tìm thấy lớp học để cập nhật.");

                old.TENLOP = lh.TENLOP;
                old.MAMH = lh.MAMH;
                old.MAGV = lh.MAGV;     // có thể null
                old.LTRG = lh.LTRG;
                old.SISODK = lh.SISODK;
                old.PHHOC = lh.PHHOC;

                db.SaveChanges();
            }
        }

        public int CountBienLaiByLopHoc(string malh)
        {
            malh = (malh ?? "").Trim();
            using (var db = new QLHVContextDB())
            {
                return db.BIENLAIs.Count(x => x.MALH == malh);
            }
        }

        // cascadeBienLai = true: xóa BIENLAI trước rồi xóa LOPHOC
        public bool DeleteLopHoc(string malh, bool cascadeBienLai, out string err)
        {
            err = null;
            malh = (malh ?? "").Trim();

            try
            {
                using (var db = new QLHVContextDB())
                using (var tran = db.Database.BeginTransaction())
                {
                    var lh = db.LOPHOCs.FirstOrDefault(x => x.MALH == malh);
                    if (lh == null)
                    {
                        err = "Không tìm thấy lớp học.";
                        return false;
                    }

                    if (cascadeBienLai)
                    {
                        var bl = db.BIENLAIs.Where(x => x.MALH == malh).ToList();
                        if (bl.Count > 0)
                            db.BIENLAIs.RemoveRange(bl);
                    }
                    else
                    {
                        int cnt = db.BIENLAIs.Count(x => x.MALH == malh);
                        if (cnt > 0)
                        {
                            err = $"Không thể xóa vì lớp học đang có {cnt} biên lai.";
                            return false;
                        }
                    }

                    db.LOPHOCs.Remove(lh);
                    db.SaveChanges();

                    tran.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                err = "Lỗi xóa lớp học: " + ex.Message;
                return false;
            }
        }
    }
}

