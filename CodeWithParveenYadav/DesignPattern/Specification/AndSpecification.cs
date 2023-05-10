using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav.DesignPattern.Specification
{
    internal class AndSpecification<T>:CompositeSpecification<T>
    {
        ISpecification<T> _leftSpecification;
        ISpecification<T> _rightSpecification;

        public AndSpecification(ISpecification<T> leftSpecification,ISpecification<T> rightSpecification)
        {
            _leftSpecification = leftSpecification;
            _rightSpecification = rightSpecification;
        }

        public override bool IsSatisfiedBy(T o)
        {
           return _leftSpecification.IsSatisfiedBy(o) && _rightSpecification.IsSatisfiedBy(o);
        }
    }
}
