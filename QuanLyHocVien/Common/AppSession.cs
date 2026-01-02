using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocVien.Common
{
    public static class AppSession
    {
        public static int MADN { get; private set; }
        public static string UserName { get; private set; }

        public static bool IsLoggedIn => MADN > 0;

        public static void Set(int madn, string userName)
        {
            MADN = madn;
            UserName = userName;
        }

        public static void Clear()
        {
            MADN = 0;
            UserName = null;
        }
    }
}
