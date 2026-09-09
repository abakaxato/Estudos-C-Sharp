using System;
using System.Collections.Generic;
using System.Text;

namespace OlaMundo.Classes.EqualsHashCode
{
    internal class Materia
    {
        public double Peso { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cor { get; set; }

        //Usando o equals e o hashCode personalizado
            //Fazendo o equals considerar apenas o nome e a cor da materia
        public override bool Equals(object? obj)
        {
            if(obj is not Materia)
            {
                return false;
            }

            Materia materia = (Materia)obj;
            
            if (materia.Nome == Nome && materia.Peso == Peso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            //Fazendo com que ao puxar o hashCode da materia
                //seja retornado o valor considerando apenas a cor
        public override int GetHashCode()
        {
            return Cor.GetHashCode();
        }

        public override string ToString()
        {
            return $"\nNome : {Nome}\nPeso : {Peso}\nCor : {Cor}";
        }

    }
}
