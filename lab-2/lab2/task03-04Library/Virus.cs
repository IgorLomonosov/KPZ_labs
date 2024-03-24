using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04Library
{
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(double weight, int age, string name, string species)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Species = species;
            Children = new List<Virus>();
        }

        public object Clone()
        {
            return new Virus(Weight, Age, Name, Species)
            {
                Children = new List<Virus>(Children)
            };
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Virus Name: {Name}");
            Console.WriteLine($"Virus Species: {Species}");
            Console.WriteLine($"Virus Weight: {Weight}");
            Console.WriteLine($"Virus Age: {Age}");
            Console.WriteLine($"Number of Children: {Children.Count}");
            foreach(var child in Children )
            {
                Console.WriteLine($"Child name: {child.Name}, " +
                    $"Child species: {child.Species}, " +
                    $"Child weight: {child.Weight}, " +
                    $"Child age: {child.Age}.");
            }
        }
    }
}
