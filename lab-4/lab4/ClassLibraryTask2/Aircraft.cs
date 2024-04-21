namespace ClassLibraryTask2
{
    public class Aircraft
    {
        public readonly string Name;
        private CommandCentre CommandCentre;

        public Aircraft(string name)
        {
            Name = name;
        }

        public void RegisterCommandCentre(CommandCentre commandCentre)
        {
            CommandCentre = commandCentre;
        }
        public void RequestTakeOff()
        {
            CommandCentre.RequestTakeOff(this);
        }

        public void RequestLand(Runway runway)
        {
            CommandCentre.RequestLand(this, runway);
        }
        public void ConfirmTakeOff()
        {
            Console.WriteLine($"Літак {Name} пішов на взліт.");
        }

        public void ConfirmLand()
        {
            Console.WriteLine($"Літак {Name} пішов на посадку.");
        }
    }
}
