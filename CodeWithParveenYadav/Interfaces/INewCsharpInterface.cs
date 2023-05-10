using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav
{
    interface IMyParent
    {
       public string Property(string amount)
        {
            return $"My Parent { amount }";
        }

        string MoreProperty();
    }

    interface IMyUncle
    {
        string Property()
        {
            return "My Uncle $100000";
        }
    }

    //public class MySelf : IMyParent, IMyUncle
    //{

    //}

}
