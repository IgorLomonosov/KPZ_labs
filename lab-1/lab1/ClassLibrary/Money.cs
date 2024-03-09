namespace task1
{
    public class Money
    {
        private int wholePart;
        private int fractionalPart;

        public Money(int wholePart, int fractionalPart)
        {
            SetMoneyParts(wholePart, fractionalPart);
        }

        public void DisplayAmount()
        {
            Console.Write($"{wholePart}.{fractionalPart:00}");
        }

        public int WholePart()
        {
            return wholePart;
        }

        public int FractionalPart()
        {
            return fractionalPart;
        }

        public void SetMoneyParts(int newWholePart, int newFractionalPart)
        {
            if (newWholePart < 0 || newFractionalPart < 0 || newFractionalPart >= 100)
            {
                throw new ArgumentException("Invalid money values.");
            }

            wholePart = newWholePart;
            fractionalPart = newFractionalPart;
        }
    }
}
