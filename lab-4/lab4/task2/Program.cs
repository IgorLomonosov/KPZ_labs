using System;
using System.Text;
using ClassLibraryTask2;
namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Runway[] runways = { new Runway(), new Runway() };
            Aircraft[] aircrafts = { new Aircraft("Boeing 747"), new Aircraft("Airbus A320") };

            CommandCentre commandCentre = new CommandCentre(runways, aircrafts);

            commandCentre.Aircrafts[1].RequestTakeOff();
            commandCentre.Aircrafts[1].RequestLand(commandCentre.Runways[1]);
            commandCentre.Aircrafts[0].RequestLand(commandCentre.Runways[0]);
        }
    }
}