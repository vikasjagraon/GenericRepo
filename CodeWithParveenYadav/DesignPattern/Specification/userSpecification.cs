using System;
using System.Collections.Generic;
using System.Text;
using static CodeWithParveenYadav.Program;

namespace CodeWithParveenYadav.DesignPattern.Specification
{
    internal class UserSpecification:CompositeSpecification<UserModel>
    {
        public override bool IsSatisfiedBy(UserModel o)
        {
            return !string.IsNullOrWhiteSpace(o.FirstName) && !string.IsNullOrWhiteSpace(o.LastName);
        }
    }
}
