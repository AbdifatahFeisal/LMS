using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentForm
{
    class CalculateReturnDate
    {
        public static DateTime D1;
        public static DateTime D2;
        public static TimeSpan Days;
        public static void DateReturnCal(ref TimeSpan loanduration, ref DateTime dateborrow)
        {
            Days = loanduration;
            D1 = dateborrow;
            D2 = D1 + Days;
        }
    }
}
