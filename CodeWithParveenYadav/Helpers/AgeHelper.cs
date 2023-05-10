using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav.Helpers
{
    static class AgeHelper
    {
        public static bool IsAdult(this int age)
        {
            if (age > 18)
            {
                return true;
            }

            return false;
        }

        public static int GetAge(DateTime dob)
        {
            //perform some logic

            return 20;
        }
    }
}
