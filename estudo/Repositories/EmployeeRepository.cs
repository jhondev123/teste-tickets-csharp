using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estudo.Contexts;
using estudo.Models;
using estudo.Models.Vo;

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
        public Employee? GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }
        public Employee? GetEmployeeByCpf(Cpf cpf)
        {
            return _context.Employees.Where(e => e.Cpf.Value == cpf.Value).FirstOrDefault();
        }
        public bool StoreEmployee(Employee employee)
        {
            employee.CreatedAt = DateTime.UtcNow;
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateEmployee(Employee employee)
        {
            employee.UpdatedAt = DateTime.UtcNow;
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return true;
        }
        public bool DeleteEmployee(int id)
        {
            Employee employee = _context.Employees.Find(id);
            employee.DeletedAt = DateTime.UtcNow;
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return true;
        }
    }
}
