using System.Threading;
using static System.Console;

namespace Resturant.Domain.Models
{
    class CookMaster5000 : IChef
    {
        public void Cook(Order order)
        {
            order.StartOrder();

            WriteLine($"Cooking {order.Dish}...");

            Thread.Sleep(1000);

            order.OrderCompleted();
        }
    }
}
