using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWithParveenYadav.Validators
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            if (!string.IsNullOrWhiteSpace(MakeDBCall("test")))
            {
                Regex passwordPolicyExpression = new Regex(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#!$%]).{8,20})");
                return passwordPolicyExpression.IsMatch(password);
            }
            return false;
        }

        public string MakeDBCall(string input)
        {
            return input + "result";
        }
    }
}