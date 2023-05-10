using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav.DesignPattern.Specification
{
    internal class NotSpecification<T>:CompositeSpecification<T>
    {
        ISpecification<T> _otherSpecification;
        public NotSpecification(ISpecification<T> otherSpecification)
        {
            _otherSpecification = otherSpecification;
        }

        public override bool IsSatisfiedBy(T o)
        {
            return !_otherSpecification.IsSatisfiedBy(o);
        }
    }
}
