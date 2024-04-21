using System;
using ClassLibraryTask3_4;
namespace task3
{
    public class Program
    {
        public static void Main()
        {
            var converter = new BookToHTMLConverter();
            var html = converter.ConvertToHTML("Sample text\n\nLorem ipsum dolor sit amet, consectetur adipiscing elit.");

            html.TriggerEvent("click");
        }
    }
}