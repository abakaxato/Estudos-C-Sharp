using OlaMundo.Classes;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            testes teste = new();
            int a = 10;
            int b;
            teste.Triplicar(ref a);

            Console.WriteLine(a);

            teste.Triplicar(a, out b);

            Console.WriteLine(b);

        }
    }
}