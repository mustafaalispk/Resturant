using Resturant.Domain.Models;
using System;
using static System.Console;

namespace Resturant
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface används för att koppla oss med
            // specifika implimentation, Chef, cookMaster, replicator
            Chef joe = new Chef("Joe");

            CookMaster5000 cookMaster = new CookMaster5000();

            EnterpriseReplicator replicator = new EnterpriseReplicator();

            Bistro bistro = new Bistro("Green Joe's'", replicator);
            
            bool isShouldNotExit = true;

            while (isShouldNotExit)
            {
                Clear();

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
