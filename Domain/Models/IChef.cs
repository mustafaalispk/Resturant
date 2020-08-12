using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant.Domain.Models
{
    interface IChef
    {
       public void Cook(Order order);
    }
}
