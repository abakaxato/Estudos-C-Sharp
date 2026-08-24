using OlaMundo.Classes;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = { "maria","bob","Alex"};

            foreach (string obj in vetor) {
                Console.WriteLine(obj);
            }

        }
    }
}