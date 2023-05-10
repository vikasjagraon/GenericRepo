using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassLib.Fixture
{
    public class ValidatePassword_TestCases_Fixture
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool ExpectedResult { get; set; }


        public static object[][] TestData = new object[][]
        {
            //new object[]
            //{
            //    new ValidatePassword_TestCases_Fixture
            //    {
            //        Name = "When Input Password is Valid - Positive",
            //        Password = "Th1sIsapassword!",
            //        ExpectedResult = true
            //    }
            //},
            // new object[]
            //{
            //    new ValidatePassword_TestCases_Fixture
            //    {
            //        Name = "When Input Password is Not Valid - Negative",
            //        Password = "Th1s!",
            //        ExpectedResult = false
            //    }
            //},
              new object[]
            {
                new ValidatePassword_TestCases_Fixture
                {
                    Name = "When Input Password is Empty - Negative",
                    Password = "",
                    ExpectedResult = true
                }
            }

        };
    }
}
