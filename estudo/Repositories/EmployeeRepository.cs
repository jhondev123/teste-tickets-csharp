using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estudo.Contexts;
using estudo.Models;

namespace estudo.Repositories
{
    public class EmployeeRepository
    {
        private readonly EstudoContext _context;

        public EmployeeRepository(EstudoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }
        public bool StoreEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return true;
        }
    }
}
