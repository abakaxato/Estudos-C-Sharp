using OlaMundo.Classes;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int y = 5;
            int? a = x ?? 1;
            Console.WriteLine(a);

        }

    }
}