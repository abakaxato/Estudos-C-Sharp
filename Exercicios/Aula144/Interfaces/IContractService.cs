using OlaMundo.Exercicios.Aula144.Models;

namespace OlaMundo.Exercicios.Aula144.Interfaces
{
    internal interface IContractService
    {
        public int Number{ get; set; }
        public DateTime InitialDate { get; set; }
        public double ContratcValue { get; set; }
        public List<InstallmentModel> InstallmentsList { get; set; }
        public List<InstallmentModel> CalcInstallments(int numberOfInstallments);
        public string ToString();
    }
}
