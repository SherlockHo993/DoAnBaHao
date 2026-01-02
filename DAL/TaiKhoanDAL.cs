using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL
{
    public class TaiKhoanDAL
    {
        public TAIKHOAN GetById(int madn)
        {
            using (var db = new QLHVContextDB())
            {
                return db.TAIKHOANs.FirstOrDefault(x => x.MADN == madn);
            }
        }

        public TAIKHOAN GetByUserPass(string user, string pass)
        {
            user = (user ?? "").Trim();
            pass = pass ?? "";

            using (var db = new QLHVContextDB())
            {
                return db.TAIKHOANs
                         .FirstOrDefault(x => x.TENDANGNHAP == user && x.MATKHAU == pass);
            }
        }

        public bool UpdatePassword(int ma, string newPass, out string error)
        {
            error = null;

            using (var db = new QLHVContextDB())
            {
                var acc = db.TAIKHOANs.FirstOrDefault(x => x.MADN == ma);
                acc.MATKHAU = newPass;
                db.SaveChanges();
                return true;
            }
        }

        public bool UserName_TonTai(string userName)
        {
            userName = (userName ?? "").Trim();

            using (var db = new QLHVContextDB())
            {
                return db.TAIKHOANs.Any(x => x.TENDANGNHAP == userName);
            }
        }

        public int Insert(string userName, string password)
        {
            userName = (userName ?? "").Trim();
            password = password ?? "";

            using (var db = new QLHVContextDB())
            {
                var tk = new TAIKHOAN
                {
                    TENDANGNHAP = userName,
                    MATKHAU = password
                };

                db.TAIKHOANs.Add(tk);
                db.SaveChanges();
                return tk.MADN;
            }
        }
    }
}
