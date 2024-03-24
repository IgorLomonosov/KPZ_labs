using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01Library
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription( int subscriptionPeriod) : base(subscriptionPeriod)
        {
            MonthlyFee = 20.99;
            Channels.Add("All Channels");
            Channels.Add("Exclusive Content");
        }

        public override void DisplaySubscriptionInfo()
        {
            Console.WriteLine("Premium Subscription:");
            Console.WriteLine($"Monthly Fee: {MonthlyFee}$");
            Console.WriteLine($"Minimum Subscription Period: {MinimumSubscriptionPeriod} month");
            Console.WriteLine($"Ordered Subscription Period: {SubscriptionPeriod} months");
            Console.WriteLine("Channels:");
            foreach (var channel in Channels)
            {
                Console.WriteLine(channel);
            }
        }
    }
}
