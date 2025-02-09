using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo.Exceptions.Models.Employee
{
    internal class AlreadyExistsCpf : Exception
    {
        public AlreadyExistsCpf(string message = "Este Cpf Já está cadastrado") : base(message)
        {
        }
    }
}
