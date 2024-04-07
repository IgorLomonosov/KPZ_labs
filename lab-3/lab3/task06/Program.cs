using ClassLibraryTask05_06;
namespace task06
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit...\n" +
                              "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\n" +
                              "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi...";

            BookToHTMLConverter converter = new BookToHTMLConverter();
            LightHTML html = converter.ConvertToHTML(bookText);

            Console.WriteLine(html.GetHtml());
        }
    }
}