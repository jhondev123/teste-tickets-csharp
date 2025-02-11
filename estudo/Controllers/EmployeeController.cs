using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estudo.Dto;
using estudo.Exceptions.Models.Employee;
using estudo.Mappers;
using estudo.Models;
using estudo.Models.Vo;
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
        public Employee getEmployeeById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }
        public Employee? getEmployeeByCpf(Cpf cpf)
        {
            return _employeeRepository.GetEmployeeByCpf(cpf);
        }
        public bool StoreEmployee(Employee employee)
        {
            if (VerifyAlreadyExistsEmployee(employee.Cpf)) 
            {
                throw new AlreadyExistsCpf();
            }

            return _employeeRepository.StoreEmployee(employee);
        }
        public bool UpdateEmployee(Employee employee)
        {
            if (VerifyAlreadyExistsEmployee(employee.Cpf,true,employee.Id))
            {
                throw new AlreadyExistsCpf();
            }

            return _employeeRepository.UpdateEmployee(employee);
        }
        public bool DeleteEmployee(int id)
        {
            return _employeeRepository.DeleteEmployee(id);
        }
        private bool VerifyAlreadyExistsEmployee(Cpf cpf,bool isEdit = false, int? employeeId = null)
        {
            Employee employee = _employeeRepository.GetEmployeeByCpf(cpf);
            
            if(isEdit && employee.Cpf.Value == cpf.Value && employeeId == employee.Id)
            {
                return false;
            }
            return employee != null;
        }
    }
}
