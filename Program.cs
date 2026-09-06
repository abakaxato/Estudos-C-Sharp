//Exercicio da aula 144


#region Enunciado da questao
/*
Uma empresa deseja automatizar o processamento de seus contratos.  
O processamento de um contrato consiste em gerar as parcelas a serem pagas para aquele contrato, com base no número de meses desejado.  
A empresa utiliza um serviço de pagamento online para realizar o pagamento das parcelas.  
Os serviços de pagamento online tipicamente cobram um juro mensal, bem como uma taxa por pagamento.  
Por enquanto, o serviço contratado pela empresa é o do Paypal, que aplica juros simples de 1% a cada parcela, mais uma taxa de pagamento de 2%.  
Fazer um programa para ler os dados de um contrato:  

número do contrato  

data do contrato  

valor total do contrato

Em seguida, o programa deve ler o número de meses para parcelamento do contrato, e daí gerar os registros de parcelas a serem pagas (data e valor).
A primeira parcela deve ser paga um mês após a data do contrato, a segunda parcela dois meses após o contrato e assim por diante.
Mostrar os dados das parcelas na tela.
*/
#endregion Enunciado da questao


using OlaMundo.Exercicios.Aula144.Interfaces;
using OlaMundo.Exercicios.Aula144.Service;
using System.Globalization;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many contracts do you want register ? ");

            int numberOfContracts = int.Parse(Console.ReadLine());

            List<IContractService> contracts = new();

            for (int i = 1; i <= numberOfContracts; i++)
            {
                try
                {
                    if (i != 1) Console.WriteLine("\nNext Contract\n");
                    Console.Write("Enter contract data\nNumber :");
                    int number = int.Parse(Console.ReadLine());
                    Console.Write("Enter contract initial Date (dd/MM/yyyy):");
                    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Console.Write("Enter contract total value :");
                    double contractValue = double.Parse(Console.ReadLine());

                    ContractService contract = new ContractService(number, date, contractValue);
                    Console.Write("Enter number of installments : ");
                    int numberOfintallments = int.Parse(Console.ReadLine());
                    contract.CalcInstallments(numberOfintallments);
                    contracts.Add(contract);

                }
                catch (FormatException formatError)
                {
                    Console.WriteLine($"you entered the date in the wrong format : {formatError.Message}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"something was error : {e.Message}");
                }
            }

            foreach (IContractService contract in contracts)
            {
                Console.WriteLine("\n" + contract.ToString());
            }
        }
    }
}
