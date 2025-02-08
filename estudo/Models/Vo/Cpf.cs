using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace estudo.Models.Vo
{
    public class Cpf
    {
        private Cpf()
        {
            
        }
        public string Value { get; private set; }
        public Cpf(string cpf)
        {
            cpf = RemoveSpecialCharts(cpf);
            if (!Validate(cpf)) 
            {
                throw new ArgumentException("Cpf Inválido");
            }
            Value = cpf;       
        }
        public bool Validate(string cpf)
        {
            return true;
        }

        public string GetCpfFormated()
        {
            return string.Format("{0}.{1}.{2}-{3}",
                Value.Substring(0, 3),
                Value.Substring(3, 3),
                Value.Substring(6, 3),
                Value.Substring(9, 2));
        }
        private string RemoveSpecialCharts(string Text)
        {
            return Regex.Replace(Text, "[^0-9]", "");
        }

    }
}
