using OlaMundo.Classes.Heranca;
using OlaMundo.Exercicios.Aula120;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não pode dividir por zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine("não pode colocar letras : " + e.Message);
            }
            finally 
            {
                Console.WriteLine("cabou");
            }


        }
    }
}
