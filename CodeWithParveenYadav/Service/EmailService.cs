using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav
{
    class EmailService
    {
        public string Send(string expression)
        {

            //switch (expression)
            //{
            //    case "x":
            //        // code block
            //        break;
            //    case "y":
            //        // code block
            //        break;
            //    default:
            //        // code block
            //        break;
            //}


           return expression switch
            {
                "x" => "",
                "y" => "",
                _ => ""
            };



        }
    }
}
