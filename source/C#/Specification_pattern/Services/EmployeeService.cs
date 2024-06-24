using Repositories;
using Specification_pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IGenericRepository<Employee> _employeeRepository;

        public EmployeeService(IGenericRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
         public Task<Specification_pattern.Models.Employee> GetItemByIdAsync(int id)
        {
            return _employeeRepository.GetByIdAsync(id);
        }
    }
}
