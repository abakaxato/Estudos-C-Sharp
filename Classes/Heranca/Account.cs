namespace OlaMundo.Classes.Heranca
{
    internal class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; } = string.Empty;
        public double Balance { get; protected set; }
        public Account()
        {
        }
        public Account(int number,string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        // O "virtual" é usado para identificar métodos que podem ser sobrescritos pelas subclasses
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }
        public override string ToString()
        {
            return $"Numero da conta comum : {Number}\nDono da conta : {Holder}\nSaldo : {Balance}";
        }
    }
}
