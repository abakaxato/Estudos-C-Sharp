using OlaMundo.Classes;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();
            int operacao = 0;

            while (operacao != 1)
            {
                try
                {
                    Console.WriteLine("Vamos Abrir a sua conta, Digite o numero da conta :");
                    int numeroDaConta = int.Parse(Console.ReadLine());
                    Console.WriteLine("Numero salvo, agora digite o seu nome :");
                    string nomeDoTitular = Console.ReadLine();
                    Console.WriteLine("Nome salvo, quer adicionar algum valor a sua nova conta ? digite 's' para Sim e 'n' para não");
                    char opcao = char.Parse(Console.ReadLine());
                    if (opcao == 's')
                    {
                        Console.WriteLine("Digite o valor inicial que vai ser inserido na conta");
                        double depositoInicial = double.Parse(Console.ReadLine());
                        conta.AbrirContaBancaria(numeroDaConta,nomeDoTitular, depositoInicial);
                        operacao = 1;
                    }
                    else if (opcao == 'n')
                    {
                        Console.WriteLine("Ok, vamos tentar criar a sua conta com esses dados...");
                        conta.AbrirContaBancaria(numeroDaConta,nomeDoTitular);
                        operacao = 1;
                    }
                    else
                    {
                        Console.WriteLine("você digitou algo incorreto vamos tentar novamente...\n");
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("você digitou algo incorreto vamos tentar novamente...\n");
                }
            }
        }

    }
}