namespace task1
{
    public class Warehouse
    {
        private string itemName;
        private string unitOfMeasure;
        private Money unitPrice;
        private int quantity;
        private DateTime lastUpdateDate;

        public Warehouse(string itemName, string unitOfMeasure, Money unitPrice, int quantity, DateTime lastUpdateDate)
        {
            SetItemDetails(itemName, unitOfMeasure, unitPrice, quantity, lastUpdateDate);
        }

        public int GetQuantity() { return quantity; }

        public void DisplayItemDetails()
        {
            Console.Write($"\nItem: {itemName}, Unit of Measure: {unitOfMeasure}, Unit Price: ");
            unitPrice.DisplayAmount();
            Console.Write($", Quantity: {quantity}, Last Arrival Date: {lastUpdateDate.ToShortDateString()}\n");
        }

        public void UpdateQuantity(int newQuantity)
        {
            if (newQuantity < 0)
            {
                throw new ArgumentException("Quantity should be a non-negative number.");
            }

            quantity = newQuantity;
            lastUpdateDate = DateTime.Now;
        }

        public void SetItemDetails(string newName, string newUnitOfMeasure, Money newUnitPrice, int newQuantity, DateTime newLastUpdateDate)
        {
            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newUnitOfMeasure) || newQuantity < 0)
            {
                throw new ArgumentException("Invalid item details.");
            }

            itemName = newName;
            unitOfMeasure = newUnitOfMeasure;
            unitPrice = newUnitPrice;
            quantity = newQuantity;
            lastUpdateDate = newLastUpdateDate;
        }
    }
}
