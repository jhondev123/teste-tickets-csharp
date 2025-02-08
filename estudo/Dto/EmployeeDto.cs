using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Situation { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public EmployeeDto(
            int id,
            string name,
            string cpf,
            string situation,
            DateTime? createdAt,
            DateTime? updatedAt
        )
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Situation = situation;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;

        }
    }
}
