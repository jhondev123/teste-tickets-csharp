using estudo.Dto;
using estudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo.Mappers
{
    public class EmployeeMapper
    {
        public static EmployeeDto GetDtoByModel(Employee employee)
        {
            return new EmployeeDto(
                employee.Id,
                employee.Name,
                employee.Cpf.GetCpfFormated(),
                employee.Situation.ToString(),
                employee.CreatedAt,
                employee.UpdatedAt
            );
        }
        public static List<EmployeeDto> GetDtoByModel(List<Employee> employees)
        {
            List<EmployeeDto> employeesDto = new List<EmployeeDto>();
            foreach (Employee employee in employees)
            {
                employeesDto.Add(GetDtoByModel(employee));
            }
            return employeesDto;
        }
    }

}
