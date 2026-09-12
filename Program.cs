//Exercicio da aula 159


#region Enunciado da questao
/*
Na contagem de votos de uma eleição, são gerados vários registros de votação contendo o nome do 
candidato e a quantidade de votos (formato .csv) que ele obteve em uma urna de votação.
Você deve fazer um programa para ler os registros de votação a partir de um arquivo, 
e daí gerar um relatório consolidado com os totais de cada candidato.

Dados que eu usei :

Alex Green,21
Maria Brown,30
Bob Blue,15
Alex Green,15
Maria Brown,25
Alex Green,22
Bob Blue,10
Maria Brown,35
Alex Green,31
Bob Blue,8


Caminho : C:\temp\in.csv

*/
#endregion Enunciado da questao



using OlaMundo.Classes.EqualsHashCode;
using System.Globalization;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path : ");
            string path = Path.GetFullPath(Console.ReadLine() ?? "");
            string[] lines = File.ReadAllLines(path);
            Dictionary<string, int> candidatedXVote = new();
            int totalLines = lines.Length;
            List<string> splitLine = new();
            for (int i = 0; i < totalLines; i++)
            {
                string[] candidate = lines[i].Split(",");
                if (candidatedXVote.ContainsKey(candidate[0]))
                {
                    candidatedXVote[candidate[0]] += int.Parse(candidate[1]);
                }
                else
                {
                    candidatedXVote[candidate[0]] = int.Parse(candidate[1]);
                } 
            }
            foreach (KeyValuePair<string, int> keyValuePair in candidatedXVote)
            {
                Console.WriteLine($"Candidated : {keyValuePair.Key} Total Votes : {keyValuePair.Value}");
            }
        }
    }
}
