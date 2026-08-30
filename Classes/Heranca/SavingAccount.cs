using System;
using System.Collections.Generic;
using System.Text;

namespace OlaMundo.Classes.Heranca
{
    internal class SavingAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingAccount()
        {

        }
        public SavingAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance() 
        {
            Balance += Balance * InterestRate;
        }
        public override string ToString()
        {
            return $"Numero da conta : {Number}\nDono da conta : {Holder}\nSaldo : {Balance}R$\nTaxa de juros : {InterestRate}";
        }
    }
}
