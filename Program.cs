//Exercicio da aula 150


#region Enunciado da questao
/*

*/
#endregion Enunciado da questao


using OlaMundo.Classes.Generics;
using OlaMundo.Exercicios.Aula144.Interfaces;
using OlaMundo.Exercicios.Aula144.Service;
using System.Globalization;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando uma nova instancia da classe SimpleCalculator
            //Setando o tipo generico "U" com o tipo "int" e setando o valor "10" na sua instancia criada
            SimpleCalculator<int> calculator = new(10);

            //Chamando o método que vai apenas me retornar que tipo de dado foi settado-
            //-Na instanciação da classe
            calculator.GenericTypeOfClass();

            Console.WriteLine("---------------------------------");

            //Chamando o método que faz um CompareTo entre o primeiro e o segundo valor
            //Especifiquei no método que o tipo generico "T" vai ser o tipo "int"
            //todos esses tipos implementam o Icomparable, por isso poderam ser selecionados

            //Passei os valores aceitos por "string" como parametros do método
            //como 'M' vem antes de 'P' na ordem Unicode/ASCII,  "Maria".CompareTo("Pele") retorna negativo — ou seja, "Maria" é menor que "Pele".
            calculator.Calc<string>("Maria", "Pele");

            Console.WriteLine("---------------------------------");

            //Passei os valores aceitos por "int" como parametros do método
            calculator.Calc<int>(1, 1);

            Console.WriteLine("---------------------------------");

            //Passei os valores aceitos por "double" como parametros do método
            calculator.Calc<double>(2.02, 2.01);

        }
    }
}
