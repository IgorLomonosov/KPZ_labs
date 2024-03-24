using task02Library;
namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int check = 0;
            while (check == 0)
            {
                Console.WriteLine("Hello, input device you would like to create:\n" +
                    "Laptop.\n" +
                    "Netbook.\n" +
                    "EBook.\n" +
                    "Smartphone.");
                string deviceType = Console.ReadLine();
                Console.WriteLine("Choose which brand`s device you want:\n" +
                    "IProne.\n" +
                    "Balaxy.\n" +
                    "Kiaomi.\n" +
                    "Other(Input it yourself).");
                string brand = Console.ReadLine();
                DeviceFactory factory = new DeviceFactory();
                IDevice device = factory.CreateDevice(deviceType, brand);
                if(device == null)
                {
                    Console.Clear();
                    Console.WriteLine("Error in input data, try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("Your device:");
                    device.DisplayInfo();
                    check = 1;
                }
            }
        }
    }
}