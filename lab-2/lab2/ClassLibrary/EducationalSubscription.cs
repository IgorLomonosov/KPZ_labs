using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01Library
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription(int subscriptionPeriod) : base(subscriptionPeriod)
        {
            MonthlyFee = 12.99;
            Channels.Add("Educational Content");
            Channels.Add("Documentaries");
        }

        public override void DisplaySubscriptionInfo()
        {
            Console.WriteLine("Educational Subscription:");
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
