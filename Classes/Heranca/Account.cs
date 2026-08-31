using OlaMundo.Classes.Exceptions;

namespace OlaMundo.Classes.Heranca
{
    internal class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; } = string.Empty;
        public double Balance { get; protected set; }
        public double WithdrawLimit { get; set; }
        public Account()
        {
        }
        public Account(int number,string holder, double balance, double withdrawlLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawlLimit;
        }
        public void Deposit(double amount) 
        {
            Balance += amount;
        }
        // O "virtual" é usado para identificar métodos que podem ser sobrescritos pelas subclasses
        public virtual void Withdraw(double amount)
        {
            try
            {
                if (amount > WithdrawLimit)
                {
                    throw new AccountException($"Valor de saque é maior que o limite de saque: \nSaque:{amount}\nLimite da conta {WithdrawLimit}\n");
                }
                else if (Balance == 0)
                {
                    throw new AccountException($"Não existe valor em conta para ser sacado : \nSaque: {amount}\nValor em conta : {Balance}\n");
                }
                else if (amount > (Balance - 5))
                {
                    throw new AccountException($"Valor de saque é maior que o valor em conta mais a taxa: \nSaque : {amount}\nValor em conta : {Balance}\nTaxa : 5\n");
                }
                Balance -= amount + 5.0;
            }
            catch (AccountException e) 
            {
                Console.WriteLine($"Ocorreu uma exceção ao sacar o dinheiro da conta :\n{e.Message}");            
            }
        }
        public override string ToString()
        {
            return $"Numero da conta comum : {Number}\nDono da conta : {Holder}\nSaldo : {Balance}";
        }
    }
}
