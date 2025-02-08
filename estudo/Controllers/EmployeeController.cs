using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estudo.Dto;
using estudo.Mappers;
using estudo.Models;
using estudo.Repositories;

namespace estudo.Controllers
{
    public class EmployeeController
    {
        private readonly EmployeeRepository _employeeRepository;
        public EmployeeController(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public List<EmployeeDto>SearchAllEmployees()
        {
            List<Employee> employees = _employeeRepository.GetAllEmployees().ToList();
            return EmployeeMapper.GetDtoByModel(employees);
        }

    }
}
