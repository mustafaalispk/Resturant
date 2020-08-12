using System.Threading;
using static System.Console;

namespace Resturant.Domain.Models
{
    class EnterpriseReplicator : IChef
    {
        public void Cook(Order order)
        {
            order.StartOrder();

            WriteLine($"Cooking {order.Dish}...");

            Thread.Sleep(100);

            order.OrderCompleted();
        }
    }
}
