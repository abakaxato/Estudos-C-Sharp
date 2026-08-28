
namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2016,08,27,14,12,09);
            Console.WriteLine("ToLongDateString : " + dateTime.ToLongDateString());
            DateTime dateTime2 = new DateTime(2016,08,27,14,12,09);
            Console.WriteLine("ToLongTimeString : " + dateTime2.ToLongTimeString());
            DateTime dateTime3 = new DateTime(2016, 08, 27, 14, 12, 09);
            Console.WriteLine("ToShortDateString : " + dateTime3.ToShortDateString());
            DateTime dateTime4 = new DateTime(2016, 08, 27, 14, 12, 09);
            Console.WriteLine("ToString : " + dateTime4.ToString("yyyy-texto-MM-dd"));
            Console.WriteLine("--------------------------------------------");
            DateTime dateTime5 = dateTime.AddHours(5);
            Console.WriteLine("AddHours : " + dateTime5);
            DateTime dateTime6 = dateTime.AddTicks(900000000);
            Console.WriteLine("AddTicks : " + dateTime6);
            Console.WriteLine("--------------------------------------------");
            TimeSpan diferenca = dateTime5.Subtract(dateTime6);
            Console.WriteLine("Subtract " + diferenca);
            TimeSpan divisao = diferenca.Divide(2);
            Console.WriteLine("Divide " + divisao);
            TimeSpan timeSpan = new TimeSpan(13,22,14);
            TimeSpan soma = diferenca.Add(timeSpan);
            Console.WriteLine("Add " + soma);
            Console.WriteLine("timeSpan.Ticks " + timeSpan.Ticks);
            Console.WriteLine("timeSpan.Hours " + timeSpan.Hours);
            Console.WriteLine("timeSpan " + timeSpan);
            Console.WriteLine("--------------------------------------------");
            TimeSpan timeSpan1 = TimeSpan.FromDays(2,23);
            Console.WriteLine("timeSpan " + timeSpan1);
            Console.WriteLine("timeSpan.FromDays " + timeSpan1.Days);
            TimeSpan timeSpan2 = TimeSpan.FromHours(2,23);
            Console.WriteLine("timeSpan " + timeSpan2);
            Console.WriteLine("timeSpan.Fromhours " + timeSpan2.Days);
        }
    }
}
