using OlaMundo.Classes;
using System.Globalization;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2026,12,12,12,12,12,12);
            dateTime = DateTime.ParseExact("2018-12-12 13:43:56", "yyyy-MM-dd HH:mm:s", CultureInfo.InvariantCulture);
            Console.WriteLine(dateTime);
        }
    }
}
