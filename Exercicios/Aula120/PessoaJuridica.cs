using System;
using System.Collections.Generic;
using System.Text;

namespace OlaMundo.Exercicios.Aula120
{
    internal class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }
        public PessoaJuridica(string nome, int idade, double renda, int numeroFuncionarios) : base(nome, idade, renda)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalcularImposto()
        {
            if (NumeroFuncionarios < 10)
            {
                Imposto = Renda * 0.16;
            }
            else 
            {
                Imposto = Renda * 0.14;
            }
            return Imposto;
        }

        public override void PagarImposto()
        {
            CalcularImposto();
            Renda -= Imposto;
        }
    }
}
