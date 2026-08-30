using System;
using System.Collections.Generic;
using System.Text;

namespace OlaMundo.Classes.Heranca
{
    internal sealed class AccountSaving : Account
    {
        public double InterestRate { get; set; }
        public AccountSaving()
        {

        }
        public AccountSaving(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance() 
        {
            Balance += Balance * InterestRate;
        }

        // Método sobrescrevendo o método da superclasse
        public override void Withdraw(double amount)
        {
            // O "base" serve para utilizar o método que esta na superclasse
            base.Withdraw(amount);
            Balance -= 5;
        }
        public override string ToString()
        {
            return $"Numero da conta polpança: {Number}\nDono da conta : {Holder}\nSaldo : {Balance}R$\nTaxa de juros : {InterestRate}";
        }
    }
}
