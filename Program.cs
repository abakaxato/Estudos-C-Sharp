using OlaMundo.Classes;
using static System.Net.Mime.MediaTypeNames;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            switch (x) { 
                case 1:
                    Console.WriteLine("Foi digitado 1");
                    break;
                case 2:
                    Console.WriteLine("foi digitado 2");
                    break;
                default:
                    Console.WriteLine("foi digitado um valor diferente de 1 ou 2");
                    break;
            }

        }
    }
}
