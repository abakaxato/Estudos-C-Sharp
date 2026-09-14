using System;
using System.Collections.Generic;
using System.Text;

namespace OlaMundo.Exercicios.Aula116
{
    internal class Product
    {
        

        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string PriceTag() 
        {
            return $"Name : {Name}\nPrice : {Price}";
        }
        public override string ToString()
        {
            return $"Nome : {Name}, Preço {Price}";
        }
    }
}
