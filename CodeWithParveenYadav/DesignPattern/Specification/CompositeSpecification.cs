using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav.DesignPattern.Specification
{
    internal abstract class CompositeSpecification<T>:ISpecification<T>
    {
        public ISpecification<T> And(ISpecification<T> specification)
        {
            return new AndSpecification<T>(this,specification);
        }

        public ISpecification<T> Not(ISpecification<T> specification)
        {
            return new NotSpecification<T>(specification);
        }

        public ISpecification<T> Or(ISpecification<T> specification)
        {
            return new OrSpecification<T>(this,specification);
        }

        public abstract bool IsSatisfiedBy(T o);
    }
}
