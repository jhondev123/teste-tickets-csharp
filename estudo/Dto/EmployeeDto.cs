using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo.Dto
{
    public class EmployeeDto
    {
        public int id;
        public string name;
        public string cpf;
        public string situation;
        public DateTime createdAt;
        public DateTime updatedAt;
        public DateTime deletedAt;
        public EmployeeDto(
            int id,
            string name,
            string cpf,
            string situation,
            DateTime createdAt,
            DateTime updatedAt,
            DateTime deletedAt
        ) 
        {
            this.id = id;
            this.name = name;
            this.cpf = cpf;
            this.situation = situation;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
            this.deletedAt = deletedAt;

        }
    }
}
