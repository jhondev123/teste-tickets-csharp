using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo.Exceptions.Models.Employee
{
    internal class InvalidCpfException : Exception
    {
        public InvalidCpfException(string message = "Cpf Inválido") : base(message) { }
    }
}
