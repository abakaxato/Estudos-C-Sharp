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
        public AccountSaving(int number, string holder, double balance, double interestRate, double withdrawlLimit)
            : base(number, holder, balance, withdrawlLimit)
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
        // O "sealed" é utilizado para selar os métodos overrides para que eles não sejam sobrepostos por subclasses (só pode ser usado em métodos override)
        public sealed override string ToString()
        {
            return $"Numero da conta polpança: {Number}\nDono da conta : {Holder}\nSaldo : {Balance}R$\nTaxa de juros : {InterestRate}";
        }
    }
}
