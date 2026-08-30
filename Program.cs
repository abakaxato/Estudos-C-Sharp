using OlaMundo.Classes;
using OlaMundo.Exercicios.Aula105.Models;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          AccountBussines accountBussines = new AccountBussines(4002,"Jose",20,50);

          Console.WriteLine(accountBussines);
        }
    }
}
