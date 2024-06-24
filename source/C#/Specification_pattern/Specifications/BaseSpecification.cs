using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Specifications
{
    public abstract class BaseSpecification<T>: ISpecification<T>
    {
        public abstract Expression<Func<T, bool>> Criteria { get; }

        protected virtual void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            // To be implemented if needed
        }
    }
}
