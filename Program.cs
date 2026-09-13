//Exercicio da aula 159


#region Enunciado da questao
/*

*/
#endregion Enunciado da questao



using OlaMundo.Classes.EqualsHashCode;
using System.Globalization;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Criando";
            Console.WriteLine(text.ThirdToLastWord());
            string text2 = "Criando.e.usando.métodos.extendidos.comstring.e.utilizando.pontos.para.divisao";
            Console.WriteLine(text2.ThirdToLastWord("."));
            string text3 = "Criando e usando métodos extendidos com string";
            Console.WriteLine(text3.ThirdToLastWord());
        }
    }
}
