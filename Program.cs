using Resturant.Domain.Models;
using System;
using static System.Console;

namespace Resturant
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef joe = new Chef("Joe");

            Bistro bistro = new Bistro("Green Joe's'", joe);
            
            bool isShouldNotExit = true;

            while (isShouldNotExit)
            {
                WriteLine("1. Register order");
                WriteLine("2. Process orders");
                WriteLine("3. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        Write("Dish: ");

                        string dish = ReadLine();

                        Order order = new Order(dish);

                        bistro.RegisterOrder(order);

                        Clear();

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        bistro.ProcessOrders();

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        isShouldNotExit = false;

                        break;
                }
            }
        }
    
    }
}
