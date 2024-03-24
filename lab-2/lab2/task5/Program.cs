using task05Library;
namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroBuilder heroBuilder = new HeroBuilder();
            HeroBuilder enemyBuilder = new HeroBuilder();

            CharacterDirector heroDirector = new CharacterDirector(heroBuilder);
            CharacterDirector enemyDirector = new CharacterDirector(enemyBuilder);

            heroDirector.CreateCharacter("Osymanthis", "Male", 195, "Athletic", "Blonde", "Blue", "Armor", new List<string> { "Sword", "Shield", "Healing Potion" }, new List<string> { "Rescuing puppy", "Killing evil wizards", "Rescuing kingdom from usurper" });
            Hero hero = heroBuilder.Build();

            Console.WriteLine("Hero:");
            hero.DisplayInfo();
            Console.WriteLine();

            enemyDirector.CreateCharacter("Manhattan", "Male", 199, "Slender", "Black", "Red", "Robe", new List<string> { "Dark Magic Book", "Cursed Amulet" }, new List<string> { "Summoning Demons", "Casting Curses", "Usurping kingdom from dumb king" });
            Hero enemy = enemyBuilder.Build();

            Console.WriteLine("Enemy:");
            enemy.DisplayInfo();
        }
    }
}