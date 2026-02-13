using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentApplication.Helper
{
    public static class UserInfo
    {
        public static string LoggedInUserName { get; set; }
        public static int LoggedInUserID { get; set; }
        public static CartManager UserCart { get; set; } = new CartManager();
    }
}
