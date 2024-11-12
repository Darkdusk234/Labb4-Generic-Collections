namespace Labb4_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant diner = new Restaurant();
            MenuItem vesuvio = new MenuItem(1, "Vesuvio", 99);
            diner.AddToMenu(vesuvio);
            MenuItem hamburger = new MenuItem(2, "Hamburgare", 85);
            diner.AddToMenu(hamburger);
            MenuItem carbonara = new MenuItem(3, "Carbonara", 90);
            diner.AddToMenu(carbonara);
            MenuItem taco = new MenuItem(4, "Taco", 75);
            diner.AddToMenu(taco);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            diner.ShowMenu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            diner.CreateOrder(new Order(new List<MenuItem> { vesuvio, taco, carbonara }, 23));
            diner.CreateOrder(new Order(new List<MenuItem> { hamburger, hamburger, carbonara }, 15));
            diner.CreateOrder(new Order(new List<MenuItem> { carbonara, taco }, 38));
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            diner.ShowOrders();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }
    }
}
