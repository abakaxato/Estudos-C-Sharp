using OlaMundo.Classes.Heranca;
using OlaMundo.Exercicios.Aula120;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new();
            Console.Write("Enter the number os tax payers : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data");
                Console.Write("Individual or company (i/c)? : ");
                char e = char.Parse(Console.ReadLine());
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Years old : ");
                int years = int.Parse(Console.ReadLine());
                Console.Write("Anual income : ");
                double income = double.Parse(Console.ReadLine());

                switch (e){
                    case 'i':
                        Console.Write("health expenditures : ");
                        double health = double.Parse(Console.ReadLine());
                        pessoas.Add(new PessoaFisica(name,years,income,health));
                        break;
                    case 'c':
                        Console.Write("Number of employees : ");
                        int employeesNumber = int.Parse(Console.ReadLine());
                        pessoas.Add(new PessoaJuridica(name,years,income,employeesNumber));
                        break;
                    default:
                        Console.Write("Valor invalido");
                        break;
                }

            }
            Console.WriteLine("\n\nTAXES PAID : ");
            double totalTax= 0;
            foreach (Pessoa pessoa in pessoas) 
            {
                totalTax += pessoa.CalcularImposto();
                pessoa.PagarImposto();
                Console.Write($"\n{pessoa}\n");
            }
            Console.WriteLine($"TOTAL TAXES :\nR${totalTax}");
        }
    }
}
