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
            int moduloFour = yearID % 4;
            int moduloOneHundred = yearID % 100;
            int moduloFourHundred = yearID % 400;

            if (moduloFourHundred == 0)
            {
                return true;
            }
            else
            {
                if (moduloOneHundred == 0 && moduloFour == 0)
                {
                    return false;
                }
                else if (moduloFour == 0)
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
}
