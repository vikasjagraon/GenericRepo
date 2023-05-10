using CodeWithParveenYadav.Models;
using System;

namespace CodeWithParveenYadav.Service
{
    class EmployeeService
    {
        public string GetEmpoyeeDetails(PersonDto person)
        {
            try
            {
                return "Employee Details";
            }
            catch(Exception ex)
            {
                throw new NullReferenceException("This is Inner Exception", ex);
            }
        }

    }
}
