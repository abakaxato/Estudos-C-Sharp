using OlaMundo.Classes;
using static System.Net.Mime.MediaTypeNames;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de linhas que a matriz vai conter : ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero de colunas que a matriz vai conter : ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            Console.WriteLine("Vamos preencher a matriz");

            for (int i = 0; i < linhas; i++)
            {
                Console.WriteLine($"Digite os valores que irão ficar na linha {i + 1} separados por ' ' espaço: ");
                string[] valor = Console.ReadLine().Split(" ");
                for (int j = 0; j < colunas; j++)
                    matriz[i, j] = int.Parse(valor[j]);
            }

            Console.WriteLine("a sua matriz tem esses valores : ");
            foreach (var item in matriz)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nEscolha um desses valores para ver qual é a localização dele na matriz : ");
            int valorEscolhido = int.Parse(Console.ReadLine());
            int[] busca = new int[3];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (valorEscolhido == matriz[i, j])
                    {
                        busca[0] = matriz[i, j];
                        busca[1] = i;
                        busca[2] = j;
                        try { Console.WriteLine($"Position {busca[1]},{busca[2]}"); } catch (Exception e) { }
                        try { Console.WriteLine($"Left {matriz[busca[1], busca[2] - 1]}"); } catch (Exception e) { }
                        try { Console.WriteLine($"Right {matriz[busca[1], busca[2] + 1]}"); } catch (Exception e) { }
                        try { Console.WriteLine($"Down {matriz[busca[1] + 1, busca[2]]}"); } catch (Exception e) { }
                        try { Console.WriteLine($"up {matriz[busca[1] - 1, busca[2]]}"); } catch (Exception e) { }
                    }
                }
            }
        }
    }
}
