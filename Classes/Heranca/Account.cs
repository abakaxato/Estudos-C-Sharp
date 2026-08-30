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
        public override string ToString()
        {
            return $"Numero da conta : {Number}\nDono da conta : {Holder}\nSaldo : {Balance}";
        }
    }
}
