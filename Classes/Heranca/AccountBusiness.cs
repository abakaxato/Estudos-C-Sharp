using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OlaMundo.Classes.Heranca
{
    internal class AccountBusiness : Account
    {
        public double LoadLimit { get; set; }
        public AccountBusiness()
        {
        }
        public AccountBusiness(int number, string holder, double balance, double loadLimit)
            : base(number, holder, balance)
        {
            LoadLimit = loadLimit;
        }
        public void Loan(double amount)
        {
            if (amount < LoadLimit) 
            {
                Balance += amount;
            }
        }
        public override string ToString()
        {
            return $"Numero da conta empresarial : {Number}\nDono da conta : {Holder}\nSaldo : {Balance}R$\nLimite da conta : {LoadLimit}";
        }
    }
}
