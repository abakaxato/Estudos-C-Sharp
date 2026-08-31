using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace OlaMundo.Exercicios.Aula120
{
    internal class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }
        public PessoaFisica(string nome, int idade,double renda, double gastosSaude) : base(nome, idade,renda)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalcularImposto() 
        {
            if (Renda < 20000)
            {
                Imposto = Renda * 0.15;
            } else if (Renda > 20000) 
            {
                Imposto = Renda * 0.25;
            }
            if(GastosSaude > 0)
            {
                Imposto -= (GastosSaude / 2);
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
