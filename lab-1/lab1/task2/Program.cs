using task1;

namespace task2
{
    class Program
    {
        static void Main()
        {
            Money someMoney = new Money(10000, 99);
            someMoney.DisplayAmount();

            Product laptop = new Product("Ноутбук", someMoney);
            laptop.DisplayProductInfo();
            laptop.DecreasePrice(100.20);
            laptop.DisplayProductInfo();

            Money pencilsCost = new Money(5, 90);
            Warehouse itemOnWarehouse = new Warehouse("Pencils", "pcs", pencilsCost, 100, DateTime.Now);
            itemOnWarehouse.DisplayItemDetails();
            itemOnWarehouse.UpdateQuantity(150);
            itemOnWarehouse.DisplayItemDetails();

            Money penCost = new Money(4, 85);
            Money rubberCost = new Money(2, 15);
            Reporting reportingInstance = new Reporting();
            Warehouse someItem1 = new Warehouse("Rubbers", "pcs", rubberCost, 70, DateTime.Now);
            reportingInstance.RecordArrival(someItem1);
            reportingInstance.RecordShipment(someItem1, 50);
            Warehouse someItem2 = new Warehouse("Pens", "pcs", penCost, 120, DateTime.Now);
            reportingInstance.RecordArrival(someItem2);
            reportingInstance.RecordShipment(someItem2, 70);
            reportingInstance.GenerateInventoryReport();
        }
    }
}