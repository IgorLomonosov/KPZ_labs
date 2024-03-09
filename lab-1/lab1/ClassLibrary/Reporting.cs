namespace task1
{
    public class Reporting
    {
        private List<Warehouse> inventory; // Список товарів на складі

        // Конструктор класу
        public Reporting()
        {
            inventory = new List<Warehouse>();
        }

        // Метод для реєстрації надходження товару (прибуткова накладна)
        public void RecordArrival(Warehouse newItem)
        {
            inventory.Add(newItem);
            Console.WriteLine($"Arrival recorded: ");
            newItem.DisplayItemDetails();
        }

        // Метод для реєстрації відвантаження товару (видаткова накладна)
        public void RecordShipment(Warehouse itemToShip, int quantity)
        {
            if (!inventory.Contains(itemToShip))
            {
                throw new ArgumentException("Item not found in inventory.");
            }

            if (itemToShip.GetQuantity() < quantity)
            {
                throw new ArgumentException("Insufficient quantity in inventory.");
            }

            itemToShip.UpdateQuantity(itemToShip.GetQuantity() - quantity);
            Console.Write($"Shipment recorded: ");
            itemToShip.DisplayItemDetails();
            Console.Write($"Quantity: {quantity}\n");
        }

        // Метод для генерації звіту по інвентаризації
        public void GenerateInventoryReport()
        {
            Console.WriteLine("Inventory Report:");
            foreach (var item in inventory)
            {
                item.DisplayItemDetails();
            }
        }
    }
}
