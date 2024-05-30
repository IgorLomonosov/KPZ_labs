using ClassLibrary;
namespace task05
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var paragraph = new LightElementNode("p", "block", "normal", new List<string> { "paragraph" },
                new List<LightNode> { new LightTextNode("Hello, World!") });

            Console.WriteLine(paragraph.OuterHtml);
        }
    }

}