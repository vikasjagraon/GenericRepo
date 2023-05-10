using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav.DesignPattern.Specification
{
    internal interface ISpecification<T>
    {
        ISpecification<T> And(ISpecification<T> specification);
        ISpecification<T> Or(ISpecification<T> specification);
        ISpecification<T> Not(ISpecification<T> specification);

        bool IsSatisfiedBy(T o);
    }
}
