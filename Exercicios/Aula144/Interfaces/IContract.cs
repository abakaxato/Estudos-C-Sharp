using System;
using System.Collections.Generic;
using System.Text;

namespace OlaMundo.Exercicios.Aula144.Interfaces
{
    internal interface IContract
    {
        public string Name{ get; set; }
        public DateTime InitialDate { get; set; }
        public double ContratcValue { get; set; }
        public List<string> InstallmentsList { get; set; }
    }
}
