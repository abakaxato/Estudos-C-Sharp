using OlaMundo.Exercicios.Aula144.Interfaces;
using OlaMundo.Exercicios.Aula144.Models;
using System.Globalization;
namespace OlaMundo.Exercicios.Aula144.Service
{
    internal class ContractService : IContractService
    {
        public int Number { get; set; }
        public DateTime InitialDate { get; set; }
        public double ContratcValue { get; set; }
        public List<InstallmentModel> InstallmentsList { get; set; } = [];

        public ContractService(int number, DateTime date, double contractValue)
        {
            Number = number;
            InitialDate = date;
            ContratcValue = contractValue;
        }

        public List<InstallmentModel> CalcInstallments(int numberOfInstallments)
        {
            double monthlylValue = ContratcValue / numberOfInstallments;
            double tax = 0.00;
            
            for (int i = 1; i <= numberOfInstallments; i++)
            {
                tax += ((monthlylValue * 0.01) * i);
                tax = (tax + monthlylValue) + ((tax + monthlylValue) * 0.02);
                InstallmentModel installment = new(InitialDate.AddMonths(i),tax);
                InstallmentsList.Add(installment);
                tax = 0.00;
            }
            return InstallmentsList;
        }
        public override string ToString()
        {
            string concat = string.Empty;

            foreach(InstallmentModel installment in InstallmentsList)
            {
                concat += $"\n{installment.ToString()}";
            }
            return $"Contract Name :{Number}\nContract Total Value : {ContratcValue.ToString("F2",CultureInfo.InvariantCulture)}\nInitial Date : {InitialDate.ToString("dd/MM/yyyy")}\nInstallments : {concat}";
        }

    }
}
