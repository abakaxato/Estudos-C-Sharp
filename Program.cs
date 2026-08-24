using OlaMundo.Classes;
using static System.Net.Mime.MediaTypeNames;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho N da matriz : ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n,n];
            int linhas = matriz.Rank + 1;
            for (int i = 0; i < linhas; i++)
            {
                Console.WriteLine($"Digite os valores para a linha {i+1} divididos por ' ' espaço : ");
                string [] respostaDividida = Console.ReadLine().Split();
                for (int j = 0; j < linhas; j++)
                {
                    matriz[i, j] = int.Parse(respostaDividida[j]);
                }
            }

            Console.WriteLine("Main Diagonal : ");
            string[] diagonal = new string[linhas];
            for (int i = 0; i < linhas; i++)
            {
                diagonal[i] = matriz[i, i].ToString();
            }
            Console.WriteLine(diagonal[0] + " " + diagonal[1] + " " + diagonal[2]);

            int negativeNumbers = 0;
            foreach (var item in matriz){
                if (item < 0) {
                    negativeNumbers++;
                }
            }
            Console.WriteLine("Negative numbers = " + negativeNumbers);
        }
    }
}