using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DAL.Model;

namespace DAL
{
    public class BienLaiDAL
    {
        private readonly QLHVContextDB db = new QLHVContextDB();

        public IEnumerable GetListStaff()
        {
            var list = (from bl in db.BIENLAIs
                        join hv in db.HOCVIENs on bl.MAHV equals hv.MAHV
                        join lh in db.LOPHOCs on bl.MALH equals lh.MALH
                        select new
                        {
                            bl.MALH,
                            TENLOP = lh.TENLOP,
                            bl.MAHV,
                            HOTENHV = (hv.HO + " " + hv.TEN),
                            bl.DIEM,
                            bl.KQUA,
                            bl.XEPLOAI,
                            bl.TIENNOP
                        }).ToList();

            return list;
        }

        public bool Exists(string malh, string mahv)
        {
            malh = (malh ?? "").Trim();
            mahv = (mahv ?? "").Trim();

            using (var db = new QLHVContextDB())
            {
                return db.BIENLAIs.Any(x => x.MALH == malh && x.MAHV == mahv);
            }
        }

        public bool ExistsHocVien(string mahv)
        {
            mahv = (mahv ?? "").Trim();
            using (var db = new QLHVContextDB())
            {
                return db.HOCVIENs.Any(x => x.MAHV == mahv);
            }
        }

        public bool ExistsLopHoc(string malh)
        {
            malh = (malh ?? "").Trim();
            using (var db = new QLHVContextDB())
            {
                return db.LOPHOCs.Any(x => x.MALH == malh);
            }
        }

        public void Insert(BIENLAI bl)
        {
            using (var db = new QLHVContextDB())
            {
                db.BIENLAIs.Add(bl);
                db.SaveChanges();
            }
        }

        public void Update(BIENLAI bl)
        {
            using (var db = new QLHVContextDB())
            {
                var old = db.BIENLAIs.FirstOrDefault(x => x.MALH == bl.MALH && x.MAHV == bl.MAHV);
                if (old == null) throw new Exception("Không tìm thấy biên lai để cập nhật.");

                old.DIEM = bl.DIEM;
                old.KQUA = bl.KQUA;
                old.XEPLOAI = bl.XEPLOAI;
                old.TIENNOP = bl.TIENNOP;

                db.SaveChanges();
            }
        }

        public void Delete(string malh, string mahv)
        {
            malh = (malh ?? "").Trim();
            mahv = (mahv ?? "").Trim();

            using (var db = new QLHVContextDB())
            {
                var bl = db.BIENLAIs.FirstOrDefault(x => x.MALH == malh && x.MAHV == mahv);
                if (bl == null) throw new Exception("Không tìm thấy biên lai để xóa.");

                db.BIENLAIs.Remove(bl);
                db.SaveChanges();
            }
        }
    }
}

