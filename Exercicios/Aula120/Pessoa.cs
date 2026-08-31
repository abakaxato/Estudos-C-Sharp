using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OlaMundo.Exercicios.Aula120
{
    internal abstract class Pessoa(string nome, int idade,double renda)
    {
        protected string Nome { get; set; } = nome;
        protected int Idade { get; set; } = idade;
        protected double Renda { get; set; } = renda;
        protected double Imposto { get; set; }
        public abstract double CalcularImposto();
        public abstract void PagarImposto();
        public override string ToString()
        {
            return $"\nName : {Nome}\nTax : R${Imposto.ToString("F2",CultureInfo.InvariantCulture)}";
        }
        
    }
}
