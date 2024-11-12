namespace Labb4_Generic_Collections
{
    internal class Order
    {
        // I denna klass använder vi i stället private fields
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        public int GetOrderID()
        {
            return _orderId;
        }

        public void PrintOrder()
        {
            decimal sum = 0;
            Console.WriteLine($"Order {_orderId}:");

            foreach (var item in _orderItems)
            {
                Console.WriteLine($"1 st {item.Name}");
                sum += item.Price;
            }

            Console.WriteLine($"Summa: {sum:C}");

            Console.WriteLine($"Till bord nummer {_tableNumber}");
        }
    }
}
