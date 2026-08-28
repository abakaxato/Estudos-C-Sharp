using OlaMundo.Classes.Enums;

namespace OlaMundo.Classes
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        public OrderStatus Status{ get; set; }

        public override string ToString()
        {
            return $"\nID :{Id}\nMoment:{Moment}\nOrder Status : {Status}\n";
        }
    }
}
