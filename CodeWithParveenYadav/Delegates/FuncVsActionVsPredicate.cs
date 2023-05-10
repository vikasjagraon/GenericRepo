using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav
{
    public class FuncVsActionVsPredicate
    {
        public static int GetAge(string firstName, string lastName, DateTime dob)
        {
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                return dob.AddYears(18).Year;
            }

            return 0;
        }

        public static void GetAgeAction(string firstName, string lastName, DateTime dob)
        {
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                var age = dob.AddYears(18).Year;
            }

        }

        public static bool IsEvenNumber(int value)
        {
            if(value % 2 == 0)
            {
                return true;
            }

            return false;
        }

        public static Func<string, string, DateTime, int> FuncAge = GetAge;


        public static Action<string, string, DateTime> ActionAge = GetAgeAction;

        public static Predicate<int> IsEvenPredicate = IsEvenNumber;


    }
}
