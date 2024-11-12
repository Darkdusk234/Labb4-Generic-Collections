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
                Console.WriteLine($"{count}. {item.ToString}");
            }
        }

        public void CreateOrder(Order order)
        {
            orders.Enqueue(order);
            Console.WriteLine($"Beställning nr {order.GetOrderID()} har lagts till.");
        }
    }
}
