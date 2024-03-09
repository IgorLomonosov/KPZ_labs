namespace task1
{
    public class Product
    {
        private string name;
        private Money price;

        public Product(string name, Money price)
        {
            SetProduct(name, price);
        }

        public void DisplayProductInfo()
        {
            Console.Write($"\nProduct: {name}\nPrice: ");
            price.DisplayAmount();
        }

        public void DecreasePrice(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount should be a positive number.");
            }

            int wholePart = (int)amount;
            double fractionalPart = (amount - wholePart)*100;
            int fract = (int)fractionalPart;
            if(fract > price.FractionalPart())
            {
                wholePart++;
                price.SetMoneyParts(price.WholePart() - wholePart, (price.FractionalPart() + 100) - fract);
            }
            else
            {
                price.SetMoneyParts(price.WholePart() - wholePart, price.FractionalPart() - fract);
            }
        }

        public void SetProduct(string newName, Money newPrice)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("Invalid product information.");
            }

            name = newName;
            price = newPrice;
        }
    }
}
