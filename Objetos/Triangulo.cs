using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OlaMundo.Objetos
{
    internal class Triangulo
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public double P() { 
            double p = ((Lado1 + Lado2 + Lado3) / 2.0);
            return p;
        }

        public double Area() {
            double p = P();
            double result = Math.Sqrt(p * (p - Lado1) * (p - Lado2) * (p - Lado3));
            Console.WriteLine($"A area do triagulo é {result}");
            return result;
        }


        public void MostrarLados() {
            Console.WriteLine($"Lado 1 tem o valor {Lado1.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Lado 2 tem o valor {Lado2.ToString("F4", CultureInfo.InvariantCulture)}"); 
            Console.WriteLine($"Lado 3 tem o valor {Lado3.ToString("F4", CultureInfo.InvariantCulture)}");

        } 
    }
}
