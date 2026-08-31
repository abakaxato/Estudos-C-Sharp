using System;
using System.Collections.Generic;
using System.Text;

namespace OlaMundo.Exercicios.Aula116
{
    internal class ProductImported : Product
    {
        private double CustomFee { get; set; }
        public ProductImported(string name, double price,double customfee) 
            : base(name, price)
        {
            CustomFee = customfee;
        }
        public override string PriceTag() {

            return $"Name : {Name}\nPrice : {Price}\nCustoms fee : {CustomFee}";

        }
    }
}
