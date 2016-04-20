using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Leap
{
    public class Year
    {
        public static bool IsLeap(int yearID)
        {
            int modulo4 = yearID % 4;
            if (modulo4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
