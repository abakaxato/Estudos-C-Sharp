using System;
using System.Collections.Generic;
using System.Text;

namespace OlaMundo.Exercicios.Aula116
{
    internal class ProductUsed : Product
    {
        private DateTime Date { get; set; }
        public ProductUsed(string name, double price, DateTime date) 
            : base(name, price)
        {
            Date = date;
        }
        public override string PriceTag()
        {
            return $"Name : {Name}\nPrice : {Price}\nManufacture Date : {Date.ToString("dd/MM/yyyy")}";
        }
    }
}
