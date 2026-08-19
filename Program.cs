using OlaMundo.Classes;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            conta = conta.AbrirContaBancaria();

            conta = conta.AlterarNomeTitular(conta);

            conta = conta.Depositar(conta);

            conta = conta.Sacar(conta);

        }

    }
}