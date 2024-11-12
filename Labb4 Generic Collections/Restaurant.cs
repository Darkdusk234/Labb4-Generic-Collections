namespace Labb4_Generic_Collections
{
    internal class Restaurant
    {
        List<MenuItem> menu = new List<MenuItem>();
        Queue<Order> orders = new Queue<Order>();

        public void AddToMenu(MenuItem menuItem)
        {
            menu.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} har lagts till i menyn.");
        }

        public void ShowMenu()
        {
            int count = 1;
            Console.WriteLine("Meny:");
            foreach (var item in menu)
            {
                Console.WriteLine($"{count}. {item.ToString()}");
                count++;
            }
        }

        public void CreateOrder(Order order)
        {
            orders.Enqueue(order);
            Console.WriteLine($"Beställning nr {order.GetOrderID()} har lagts till.");
        }

        public void HandleOrder()
        {
            Console.WriteLine($"Order {orders.Dequeue().GetOrderID()} är färdig.");
            Console.WriteLine();
        }

        public void ShowOrders()
        {
            Console.WriteLine("Aktuella beställningar:");

            foreach (var order in orders)
            {
                order.PrintOrder();
                Console.WriteLine();
            }
        }

        public void ShowNextOrder()
        {
            Console.WriteLine("Nästa order i kön:");
            orders.Peek().PrintOrder();
            Console.WriteLine();
        }

        public void ShowOrderCount()
        {
            if(orders.Count() == 0)
            {
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu.");
                Console.WriteLine();
            }
            Console.WriteLine($"Det är {orders.Count()} ordrar i kön.");
            Console.WriteLine();
        }
    }
}
