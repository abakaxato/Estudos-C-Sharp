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
            DateTime dateTime = new DateTime(2016,08,27,14,12,09);
            Console.WriteLine(dateTime.ToLongDateString());
            DateTime dateTime2 = new DateTime(2016,08,27,14,12,09);
            Console.WriteLine(dateTime2.ToLongTimeString());
            DateTime dateTime3 = new DateTime(2016, 08, 27, 14, 12, 09);
            Console.WriteLine(dateTime3.ToShortDateString());
            DateTime dateTime4 = new DateTime(2016, 08, 27, 14, 12, 09);
            Console.WriteLine(dateTime4.ToString("yyyy-texto-MM-dd"));
            Console.WriteLine("--------------------------------------------");
            DateTime dateTime5 = dateTime.AddHours(5);
            Console.WriteLine(dateTime5);
            DateTime dateTime6 = dateTime.AddTicks(900000000);
            Console.WriteLine(dateTime6);
            Console.WriteLine("--------------------------------------------");
            TimeSpan diferenca = dateTime5.Subtract(dateTime6);
            Console.WriteLine(diferenca);
            TimeSpan timeSpan = new TimeSpan(13,22,14);
            Console.WriteLine(timeSpan.Ticks);
            Console.WriteLine(timeSpan.Hours);
            Console.WriteLine(timeSpan);
            Console.WriteLine("--------------------------------------------");
            TimeSpan timeSpan1 = TimeSpan.FromDays(2,23);
            Console.WriteLine(timeSpan1);
            Console.WriteLine(timeSpan1.Days);
            TimeSpan timeSpan2 = TimeSpan.FromHours(2,23);
            Console.WriteLine(timeSpan2);
            Console.WriteLine(timeSpan2.Days);
        }
    }
}
