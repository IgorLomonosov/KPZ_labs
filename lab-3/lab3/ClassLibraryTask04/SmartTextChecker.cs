using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask04
{
    public class SmartTextChecker : ITextReader
    {
        private SmartTextReader textReader;
        public SmartTextChecker()
        {
            textReader = new SmartTextReader();
        }
        public string[][] ReadText(string filePath)
        {
            Console.WriteLine("Відкриваємо файл...Завантаження...");
            string[][] result = textReader.ReadText(filePath);
            Console.WriteLine("Файл зчитано успішно!");
            Console.WriteLine($"Загальна кількість рядків :{result.Length}");
            int totalChars = 0;
            foreach(var line in result)
            {
                totalChars += line.Length;
            }
            Console.WriteLine($"Загальна кількість літер: {totalChars}");
            Console.WriteLine("Закриваємо файл...Завантаження...");
            return result;
        }
    }
}
