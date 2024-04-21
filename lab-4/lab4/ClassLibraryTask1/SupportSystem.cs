using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask1
{
    public class SupportSystem
    {
        public void ShowMenu()
        {
            Console.WriteLine("Будь ласка, оберіть з чим пов'язана ваша проблема:");
            Console.WriteLine("1. Інтернет");
            Console.WriteLine("2. Програмне забезпечення");
            Console.WriteLine("3. \"Залізо\"");
            Console.WriteLine("4. Інше");
        }

        public bool HandleUserInput()
        {
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                Handler handler;
                switch (choice)
                {
                    case 1:
                        handler = new InternetHandler();
                        break;
                    case 2:
                        handler = new SoftwareHandler();
                        break;
                    case 3:
                        handler = new HardwareHandler();
                        break;
                    case 4:
                        handler = new OtherHandler();
                        break;
                    default:
                        Console.WriteLine("Неправильні вхідні дані. Спробуйте ще раз.");
                        return false;
                }
                handler.HandleIssue();
                return true;
            }
            else
            {
                Console.WriteLine("Неправильні вхідні дані. Спробуйте ввести цифру.");
                return false;
            }
        }
    }
}
