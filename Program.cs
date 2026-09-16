//Exercicio da aula 178


#region Enunciado da questao
/*
Fazer um programa para ler os dados (nome, email e salário) de funcionários a partir de um arquivo em formato .csv.  
Em seguida mostrar, em ordem alfabética, o email dos funcionários cujo salário seja superior a um dado valor fornecido pelo usuário.  
Mostrar também a soma dos salários dos funcionários cujo nome começa com a letra 'M'.

Começo da lista no arquivo.csv :

Maria,maria@gmail.com,3200.00
Alex,alex@gmail.com,1900.00
Marco,marco@gmail.com,1700.00
Bob,bob@gmail.com,3500.00
Anna,anna@gmail.com,2800.00

path padrão :
C:\temp\in.csv
 */
#endregion Enunciado da questao

using OlaMundo.Exercicios.Aula178.Models;
using System.Globalization;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o path do arquivo.csv : ");
            string prePath = Console.ReadLine();
            string path = Path.GetFullPath(prePath);

            List<Worker> workers = new();

            using (StreamReader reader = new(path))
            {
                while (!reader.EndOfStream)
                { 
                   string[] split = reader.ReadLine().Split(",");
                   workers.Add(new Worker(split[0], split[1], double.Parse(split[2])));
                }
            }
            
            Console.WriteLine("\nEsses são os funcionarios que estão cadastrados : \n");
            workers.ForEach(Console.WriteLine);

            Console.Write("\n Qual é o valor minimo que você quer usar para filtrar os funcionarios ? ");
            double minimumWage = double.Parse(Console.ReadLine());

            Console.Write("\n Quer adicionar um filtro aos e-mails ? digite o texto ou para filtrar ou clique em enter para ver todos : ");
            string input = Console.ReadLine();
            string filterEmail = string.IsNullOrWhiteSpace(input) ? "@" : input;

            var filtredWorkers = workers
                .Where(worker => worker.Wage > minimumWage && (worker.Email.Split("@")[0].Contains(filterEmail)))
                .OrderBy(worker => worker.Email).ToList();

            Console.WriteLine($"\nEsse são os funcionarios que recebem acima de R${minimumWage.ToString("F2",CultureInfo.InvariantCulture)} e estão dentro do seu filtro '{filterEmail}': \n");
            filtredWorkers.ForEach(Console.WriteLine);

            var sumOfFilteredWages = filtredWorkers.Sum(worker => worker.Wage);
            Console.WriteLine($"\n Esse é o valor total somando os salarios de todos os funcionarios acima : {sumOfFilteredWages.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
