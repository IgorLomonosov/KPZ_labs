using ClassLibraryTask04;
namespace task04
{
    class Program
    {
        static void Main(string[] args)
        {
            ITextReader reader = new SmartTextChecker(); 

            string filePath = "D:\\унік\\Лаби\\2 курс\\КПЗ\\Коди\\KPZ_labs\\lab-3\\lab3\\sample.txt"; 

            string[][] textArray = reader.ReadText(filePath);

            foreach (var line in textArray)
            {
                foreach (var word in line)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}