using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;


namespace DAL
{
    public class HocVienDAL
    {
        private readonly QLHVContextDB db = new QLHVContextDB();

        public IEnumerable GetListStaff()
        {
            var list = (from hv in db.HOCVIENs
                        select new
                        {
                            hv.MAHV,
                            hv.HO,
                            hv.TEN,
                            hv.NTNS,
                            hv.NNGHIEP
                        }).ToList();
            return list;
        }
        public bool Exists(string mahv)
        {
            mahv = (mahv ?? "").Trim();
            using (var db = new QLHVContextDB())
            {
                return db.HOCVIENs.Any(x => x.MAHV == mahv);
            }
        }

        public void Insert(HOCVIEN hv)
        {
            using (var db = new QLHVContextDB())
            {
                db.HOCVIENs.Add(hv);
                db.SaveChanges();
            }
        }

        public void Update(HOCVIEN hv)
        {
            using (var db = new QLHVContextDB())
            {
                var old = db.HOCVIENs.FirstOrDefault(x => x.MAHV == hv.MAHV);
                if (old == null) throw new Exception("Không tìm thấy học viên để cập nhật.");

                old.HO = hv.HO;
                old.TEN = hv.TEN;
                old.NTNS = hv.NTNS;
                old.NNGHIEP = hv.NNGHIEP;

                db.SaveChanges();
            }
        }

        public int CountBienLaiByHocVien(string mahv)
        {
            mahv = (mahv ?? "").Trim();

            using (var db = new QLHVContextDB())
            {
                return db.BIENLAIs.Count(x => x.MAHV == mahv);
            }
        }

     
        public bool DeleteHocVien(string mahv, bool cascadeBienLai, out string err)
        {
            err = null;
            mahv = (mahv ?? "").Trim();

            try
            {
                using (var db = new QLHVContextDB())
                using (var tran = db.Database.BeginTransaction())
                {
                    var hv = db.HOCVIENs.FirstOrDefault(x => x.MAHV == mahv);
                    if (hv == null)
                    {
                        err = "Không tìm thấy học viên.";
                        return false;
                    }

                    if (cascadeBienLai)
                    {
                        var bl = db.BIENLAIs.Where(x => x.MAHV == mahv).ToList();
                        if (bl.Count > 0)
                            db.BIENLAIs.RemoveRange(bl);
                    }
                    else
                    {
                        // không cascade => nếu còn BIENLAI thì báo lỗi trước, tránh exception FK
                        int cnt = db.BIENLAIs.Count(x => x.MAHV == mahv);
                        if (cnt > 0)
                        {
                            err = $"Không thể xóa vì học viên đang có {cnt} biên lai.";
                            return false;
                        }
                    }

                    db.HOCVIENs.Remove(hv);
                    db.SaveChanges();

                    tran.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                err = "Lỗi xóa học viên: " + ex.Message;
                return false;
            }
        }
    }
}
