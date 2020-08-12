using System.Collections.Generic;
using System.Linq;

namespace Resturant.Domain.Models
{
    class Bistro
    {
        public string Name { get; }
        private Queue<Order> OrderQueue { get; set; } = new Queue<Order>();           

        private IChef chef;
        public Bistro(string name, IChef chef)
        {
            Name = name;
            this.chef = chef;
        }

        public void RegisterOrder(Order order)
        {
            // När man registrerar en order då lägger
            // man i en queue och queue är en samling som
            // en list. Först i komma in i queue och först kommer
            // ut.
            // Enqueue innebär sätt in på queuen.
            // Dqueue plockar bort första i queuen.
            OrderQueue.Enqueue(order);
        }

        public void ProcessOrders()
        {
            while (OrderQueue.Any())
            {
                // Dequeue plockar ut den i kön som kommer först in.
                Order order = OrderQueue.Dequeue();

                chef.Cook(order);
            }
          
        }
    }
}
