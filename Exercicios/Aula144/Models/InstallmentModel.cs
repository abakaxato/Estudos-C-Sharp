using System.Globalization;

namespace OlaMundo.Exercicios.Aula144.Models
{
    internal class InstallmentModel
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }
        public InstallmentModel(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
        public override string ToString()
        {
            return $"{DueDate.ToString("dd/MM/yyyy")} - {Amount.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
