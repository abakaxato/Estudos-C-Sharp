using OlaMundo.Classes;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digita o numero de produtos: ");

            int n = int.Parse(Console.ReadLine());
            
            Produto[] vetor = new Produto[n];
            
            Console.WriteLine($"{n} Produtos serão salvos, digite os valores de cada produto :");
            
            for (int i = 0; i < n; i++)
            {
                vetor[i] = new Produto();
                Console.WriteLine($"\nProduto {i}:");
                Console.Write("Digite o nome do produto: ");
                vetor[i].Nome = Console.ReadLine();
                Console.Write("Digite o Preco do produto: ");
                vetor[i].Preco = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vetor[i].ToString());
            }

            double soma = 0;
            double resultado = 0;

            for (int i = 0; i < n; i++)
            {
                soma += vetor[i].Preco;
            }
            resultado = soma / n;
            Console.WriteLine($"A média de preço dos produtos é {resultado.ToString("F2")}R$");
        }
    }
}