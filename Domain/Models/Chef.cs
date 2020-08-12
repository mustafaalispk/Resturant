using System.Threading;
using static System.Console;

namespace Resturant.Domain.Models
{
    class Chef : IChef
    {
        public string Name { get; }

        public Chef(string name)
        {
            Name = name;
        }

        public void Cook(Order order)
        {
            order.StartOrder();

            WriteLine($"Cooking {order.Dish}...");

            Thread.Sleep(5000);

            order.OrderCompleted();
        }
    }
}
