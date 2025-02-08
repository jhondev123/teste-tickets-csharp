using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estudo.Enums;
using estudo.Models.Vo;

namespace estudo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Cpf Cpf { get; set; }
        public EmployeeSituationEnum Situation { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}
