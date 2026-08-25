using OlaMundo.Classes;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int resultado = program.teste();
            Console.WriteLine(resultado);
        }
        public int teste()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = 0;
            return (x > y) ? 1 : 2;
        }
    }
}
