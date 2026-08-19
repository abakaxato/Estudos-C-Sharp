using OlaMundo.Classes;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita o numero de posições do vetor: ");
            int n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n];
            Console.WriteLine($"Vetor salvo com {n} posições, digite os valores de cada posição :");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nPosição {i}:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"valor na posição {i} do vetor : " + vetor[i]);

            }
            int soma = 0;
            double resultado = 0;
            
            for (int i = 0; i < n; i++)
            {
                soma += vetor[i];
            }
            resultado = soma / n;
            Console.WriteLine($"A média desses vetores é {resultado.ToString("F2")}");
        }

    }
}