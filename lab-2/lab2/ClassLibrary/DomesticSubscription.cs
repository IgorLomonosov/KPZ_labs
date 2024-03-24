using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01Library
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription(int subscriptionPeriod) : base(subscriptionPeriod)
        {
            MonthlyFee = 15.99;
            Channels.Add("Domestic News");
            Channels.Add("Entertainment");
        }

        public override void DisplaySubscriptionInfo()
        {
            Console.WriteLine("Domestic Subscription:");
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
