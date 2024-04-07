using ClassLibraryTask03;
namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrawAPI vectorDrawAPI = new VectorDrawAPI();
            IDrawAPI rasterDrawAPI = new RasterDrawAPI();

            Shape circle = new Circle(vectorDrawAPI);
            Shape square = new Square(rasterDrawAPI);
            Shape triangle = new Triangle(vectorDrawAPI);

            circle.Draw();
            square.Draw();
            triangle.Draw();

            Console.ReadLine();
        }
    }
}