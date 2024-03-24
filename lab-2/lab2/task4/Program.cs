using task04Library;
namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Virus parentVirus = new Virus(1.5, 2, "Parent Virus", "COVID-19");
            parentVirus.Children.Add(new Virus(0.8, 1, "Child Virus 1", "Delta Variant"));
            parentVirus.Children.Add(new Virus(1.0, 1, "Child Virus 2", "Alpha Variant"));

            Virus clonedParentVirus = (Virus)parentVirus.Clone();

            Console.WriteLine("Original Virus:");
            parentVirus.DisplayInfo();

            Console.WriteLine("Cloned Virus:");
            clonedParentVirus.DisplayInfo();
        }
    }
}