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
    }
}
