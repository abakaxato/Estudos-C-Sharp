using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OlaMundo.Classes.Testes
{
    internal static class ConversorDeMoedas
    {
        public static void Converter(double cotacao , double moeda) {
            double valor = moeda * cotacao;
            valor += (valor * 0.06);
            Console.WriteLine("Valor a ser pago em reais = "+ valor.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
