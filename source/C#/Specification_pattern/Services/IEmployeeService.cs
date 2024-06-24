using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IEmployeeService
    {
        Task<Specification_pattern.Models.Employee> GetItemByIdAsync(int id);
    }
}
