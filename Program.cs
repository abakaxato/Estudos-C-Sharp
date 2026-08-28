using OlaMundo.Classes;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order() {
                Id = 1080,
                Moment = DateTime.Parse("2026-08-28T13:00:00"),
                Status = Classes.Enums.OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
        }
    }
}
