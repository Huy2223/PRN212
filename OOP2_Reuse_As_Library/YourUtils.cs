using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2_Reuse_As_Library
{
    public static class YourUtils
    {
        public static int TinhTuoi(this Employee employee)
        {
            return DateTime.Now.Year - employee.Birthday.Year;
        }
    }
}
