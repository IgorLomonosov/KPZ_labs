using System;
using ClassLibraryTask3_4;
namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new BookToHTMLConverter();
            var bookText = "Sample text\n\n[img]https://miro.medium.com/v2/resize:fit:720/format:webp/0*IzwQaNQtpDkqqscl.jpg alt text\n\nLorem ipsum dolor sit amet, consectetur adipiscing elit.";
            var html = converter.ConvertToHTML(bookText);
            Console.WriteLine(html.GetHtml());
        }
    }
}