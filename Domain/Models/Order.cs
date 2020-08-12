using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant.Domain.Models
{
    class Order
    {
        public string Dish { get; }

        public DateTime CreatedAt { get; } = DateTime.Now;
        
        // DateTime är en värdetype för att den ska ragera som
        // reference type då använder vi med ?
        public DateTime? StartedAt { get; private set; }
        public DateTime CompletedAt { get; private set; }

        public Order(string dish)
        {
            Dish = dish;
          
        }

        public void StartOrder()
        {
            if (StartedAt != null)
            
                throw new Exception("Order already started");

                StartedAt = DateTime.Now;            
            
        }
        public void OrderCompleted()
        {
            if(StartedAt == null)

            throw new Exception("Order not started");

            if (CompletedAt == null)

            throw new Exception("Order already completed");

            CompletedAt = DateTime.Now;
            
        }
    }
}
