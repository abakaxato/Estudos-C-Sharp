using System;
using System.Collections.Generic;
using System.Text;

namespace OlaMundo.Classes.Testes
{
    internal class Produto
    {
        public string Nome { get; set; } = string.Empty;

        public double Preco { get; set; }

        public override string ToString()
        {
            return ($"O produto: {this.Nome}\n Custa :{this.Preco}R$");
        }
    }
}
