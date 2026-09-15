using System;
using System.Collections.Generic;
using System.Text;

namespace OlaMundo.Exercicios.Aula178.Models
{
    internal class Worker(string name = "", string email = "",double wage = 0)
    {
        public string Name { get; set; } = name;
        public string Email { get; set; } = email;
        public double Wage { get; set; } = wage;
        public override string ToString()
        {
            return $"Nome : {Name} | Email : | {Email} Salario : {Wage}";
        }
    }
}
