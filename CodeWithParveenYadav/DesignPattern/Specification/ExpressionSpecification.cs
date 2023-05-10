using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav.DesignPattern.Specification
{
    internal class ExpressionSpecification<T>:CompositeSpecification<T>
    {
        Func<T, bool> _expression;

        public ExpressionSpecification(Func<T,bool> expression)
        {
            _expression = expression;
        }

        public override bool IsSatisfiedBy(T o)
        {
            return _expression(o);
        }
    }
}
