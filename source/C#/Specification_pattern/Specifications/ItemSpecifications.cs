using Specification_pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Specifications
{
    public class ItemSpecifications: BaseSpecification<Employee>
    {
        private int _employeeId;

        public ItemSpecifications(int employeeId)
        {
            _employeeId = employeeId;
        }
        public override Expression<Func<Employee, bool>> Criteria => item => item.Id == _employeeId;
    }
}
