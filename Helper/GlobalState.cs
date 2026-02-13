using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentApplication.Helper
{
    public static class GlobalState
    {
        public static bool IsAdminOperationActive { get; set; } = false;
    }

}
