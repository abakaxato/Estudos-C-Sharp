using OlaMundo.Classes;
using OlaMundo.Classes.Enums;

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

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
