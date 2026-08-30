using OlaMundo.Classes.Heranca;
using OlaMundo.Exercicios.Aula105.Models;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new(4002, "Jose", 200);
            Console.WriteLine($"\n\n{account}\n");

            AccountBusiness accountBusines = new(4003, "Maria", 1000, 1500);
            Console.WriteLine($"\n\n{accountBusines}\n");

            AccountSaving savingAccount = new(4004, "Fernando", 7000, 0.1);
            Console.WriteLine($"\n\n{savingAccount}\n");

            account.Withdraw(5);
            Console.WriteLine($"\n\n{account}\n");

            savingAccount.Withdraw(5);
            Console.WriteLine($"\n\n{savingAccount}\n");

        }
    }
}
