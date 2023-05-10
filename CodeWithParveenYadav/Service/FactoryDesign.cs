using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav.Service
{
    internal class FactoryDesign
    {
        public static EmployeeService GetEmployeeServiceObject()
        {
            return new EmployeeService();
        }
    }
}
