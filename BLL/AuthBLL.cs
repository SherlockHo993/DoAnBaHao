using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Model;

namespace BLL
{
    public class AuthBLL
    {
        public class UserLogin
        {
            public int MADN { get; set; }
            public string TENDANGNHAP { get; set; }
        }

        private readonly TaiKhoanDAL dal = new TaiKhoanDAL();

        public UserLogin Login(string user, string pass, out string error)
        {
            error = null;
            user = (user ?? "").Trim();
            pass = pass ?? "";

            if (string.IsNullOrWhiteSpace(user))
            {
                error = "Vui lòng nhập tên đăng nhập.";
                return null;
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                error = "Vui lòng nhập mật khẩu.";
                return null;
            }

            var acc = dal.GetByUserPass(user, pass);
            if (acc == null)
            {
                error = "Sai tên đăng nhập hoặc mật khẩu.";
                return null;
            }

            return new UserLogin
            {
                MADN = acc.MADN,
                TENDANGNHAP = acc.TENDANGNHAP
            };
        }

        public bool ChangePassword(int ma, string oldPass, string newPass, string confirm, out string error)
        {
            error = null;
            oldPass = oldPass ?? "";
            newPass = newPass ?? "";
            confirm = confirm ?? "";
            var acc = dal.GetById(ma);
            if (string.IsNullOrWhiteSpace(oldPass))
            {
                error = "Vui lòng nhập mật khẩu cũ.";
                return false;
            }
            if (acc.MATKHAU != oldPass)
            {
                error = "Mật khẩu cũ không đúng.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(newPass))
            {
                error = "Vui lòng nhập mật khẩu mới.";
                return false;
            }
            if (newPass != confirm)
            {
                error = "Mật khẩu xác nhận không khớp.";
                return false;
            }
            if (newPass.Length < 4)
            {
                error = "Mật khẩu mới tối thiểu 4 ký tự.";
                return false;
            }

            return dal.UpdatePassword(ma, newPass, out error);
        }

        public bool Register(string userName, string password, string confirm, out string err)
        {
            err = null;
            userName = (userName ?? "").Trim();
            password = password ?? "";
            confirm = confirm ?? "";

            if (string.IsNullOrWhiteSpace(userName))
            {
                err = "Vui lòng nhập tên đăng nhập.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                err = "Vui lòng nhập mật khẩu.";
                return false;
            }
            if (password != confirm)
            {
                err = "Xác nhận mật khẩu không khớp.";
                return false;
            }
            if (password.Length < 4)
            {
                err = "Mật khẩu tối thiểu 4 ký tự.";
                return false;
            }

            if (dal.UserName_TonTai(userName))
            {
                err = "Tên đăng nhập đã tồn tại.";
                return false;
            }
            dal.Insert(userName, password);
            return true;
        }
    }
}
