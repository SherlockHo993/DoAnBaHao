using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL
{
    public class GiaoVienDAL
    {
        private readonly QLHVContextDB db = new QLHVContextDB();

        // Load grid
        public IEnumerable GetListStaff()
        {
            var list = (from gv in db.GIAOVIENs
                        select new
                        {
                            gv.MAGV,
                            gv.HOTEN,
                            gv.NTNS,
                            gv.DIACHI
                        }).ToList();
            return list;
        }

        public bool Exists(string magv)
        {
            magv = (magv ?? "").Trim();
            using (var db = new QLHVContextDB())
            {
                return db.GIAOVIENs.Any(x => x.MAGV == magv);
            }
        }

        public void Insert(GIAOVIEN gv)
        {
            using (var db = new QLHVContextDB())
            {
                db.GIAOVIENs.Add(gv);
                db.SaveChanges();
            }
        }

        public void Update(GIAOVIEN gv)
        {
            using (var db = new QLHVContextDB())
            {
                var old = db.GIAOVIENs.FirstOrDefault(x => x.MAGV == gv.MAGV);
                if (old == null) throw new Exception("Không tìm thấy giáo viên để cập nhật.");

                old.HOTEN = gv.HOTEN;
                old.NTNS = gv.NTNS;
                old.DIACHI = gv.DIACHI;

                db.SaveChanges();
            }
        }

        public int CountLopHocByGiaoVien(string magv)
        {
            magv = (magv ?? "").Trim();
            using (var db = new QLHVContextDB())
            {
                return db.LOPHOCs.Count(x => x.MAGV == magv);
            }
        }

        // cascadeLopHoc = true: gỡ MAGV khỏi LOPHOC (set null) rồi mới xóa GIAOVIEN
        public bool DeleteGiaoVien(string magv, bool cascadeLopHoc, out string err)
        {
            err = null;
            magv = (magv ?? "").Trim();

            try
            {
                using (var db = new QLHVContextDB())
                using (var tran = db.Database.BeginTransaction())
                {
                    var gv = db.GIAOVIENs.FirstOrDefault(x => x.MAGV == magv);
                    if (gv == null)
                    {
                        err = "Không tìm thấy giáo viên.";
                        return false;
                    }

                    int cnt = db.LOPHOCs.Count(x => x.MAGV == magv);
                    if (cnt > 0)
                    {
                        if (!cascadeLopHoc)
                        {
                            err = $"Không thể xóa vì giáo viên đang được phân công {cnt} lớp học.";
                            return false;
                        }

                        // gỡ giáo viên khỏi các lớp (MAGV trong LOPHOC cho phép null)
                        var dsLop = db.LOPHOCs.Where(x => x.MAGV == magv).ToList();
                        foreach (var lh in dsLop)
                            lh.MAGV = null;
                    }

                    db.GIAOVIENs.Remove(gv);
                    db.SaveChanges();

                    tran.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                err = "Lỗi xóa giáo viên: " + ex.Message;
                return false;
            }
        }
    }
}

