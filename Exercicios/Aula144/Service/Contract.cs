using OlaMundo.Exercicios.Aula144.Interfaces;
using System.Globalization;
namespace OlaMundo.Exercicios.Aula144.Service
{
    internal class Contract : IContract
    {
        public string Name { get; set; } = string.Empty;
        public DateTime InitialDate { get; set; }
        public double ContratcValue { get; set; }
        public List<string> InstallmentsList { get; set; } = [];

        public Contract(string name, DateTime date, double contractValue)
        {
            Name = name;
            InitialDate = date;
            ContratcValue = contractValue;
        }
        public List<string> CalcInstallments(Contract contract, int numberOfInstallments)
        {
            double monthlylValue = contract.ContratcValue / numberOfInstallments;
            
            for (int i = 0; i < numberOfInstallments; i++)
            {
                InstallmentsList.Add($"{InitialDate.AddMonths(i).ToString("dd/MM/yyyy")} - {monthlylValue * (i * 100)}");
            }
            return InstallmentsList;
        }
        public override string ToString()
        {
            string concat = string.Empty;

            foreach(string installment in InstallmentsList)
            {
                concat += $"\n {installment}";
            }
            return $"Contract Name :{Name}\nContract Total Value : {ContratcValue.ToString("F2",CultureInfo.InvariantCulture)}\nInitial Date : {InitialDate.ToString("dd/MM/yyyy")}\nInstallments : {concat}";
        }

    }
}
