using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask1
{
    public class InternetHandler : Handler
    {
        public override void HandleIssue()
        {
            Console.WriteLine("Ви обрали проблему з інтернетом.");
        }
    }
}
