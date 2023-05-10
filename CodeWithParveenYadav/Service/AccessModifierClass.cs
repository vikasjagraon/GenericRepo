using System;
using System.Collections.Generic;
using System.Text;
using CodeWithParveenYadav.Enums;
using CodeWithParveenYadav.Interfaces;

namespace CodeWithParveenYadav.Service
{
    public class AccessModifierClass : IAccessModifier
    {
       public AccessModifierClass()
        {

        }


       public string Property { get; set; }
        public string TestProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Variable = string.Empty;
       

        public void FirstMethod()
        {
            //some  logic here
        }

        public void TestMethod()
        {
            throw new NotImplementedException();
        }

        ~ AccessModifierClass()
        {

        }
}

}
