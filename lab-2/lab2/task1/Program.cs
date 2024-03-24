using task01Library;
namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int check = 0;
            while (check == 0)
            {
                Console.WriteLine("Hello, choose your payment method:\n" +
                    "1.WebSite.\n" +
                    "2.MobileApp.\n" +
                    "3.ManagerCall");
                int paymentMethod;
                SubscriptionBuy payment;
                if (int.TryParse(Console.ReadLine(), out paymentMethod) && paymentMethod == 1)
                {
                    payment = new WebSite();
                }
                else if (int.TryParse(Console.ReadLine(), out paymentMethod) && paymentMethod == 2)
                {
                    payment = new MobileApp();
                }
                else if(int.TryParse(Console.ReadLine(), out paymentMethod) && paymentMethod == 3) 
                {
                    payment = new ManagerCall();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error, try again inputting your desired payment method.");
                    continue;
                }
                Console.WriteLine("Choose your subscription plan:\n" +
                    "1.Domestic subscription.\n" +
                    "2.Educational subscription.\n" +
                    "3.Premium subscription");
                if (!int.TryParse(Console.ReadLine(), out int subscriptionPlan) && (subscriptionPlan != 1 && subscriptionPlan != 2 && subscriptionPlan != 3))
                {
                    Console.Clear();
                    Console.WriteLine("Error, try again inputting your desired subscription plan and payment method.");
                    continue;
                }
                Console.WriteLine("Input your desired subscription period:");
                if (!int.TryParse(Console.ReadLine(), out int subscriptionPeriod))
                {
                    Console.Clear();
                    Console.WriteLine("Error, try again inputting your desired subscription period, subscription plan and payment method.");
                    continue;
                }
                Subscription subscription = payment.BuySubscription(subscriptionPlan, subscriptionPeriod);
                if (subscription == null)
                {
                    Console.Clear();
                    Console.WriteLine("Error, try again inputting your desired subscription period, subscription plan and payment method.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Info about your subscription:");
                    subscription.DisplaySubscriptionInfo();
                    check = 1;
                }
            }
        }
    }
}