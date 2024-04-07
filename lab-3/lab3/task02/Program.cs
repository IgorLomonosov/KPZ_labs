using ClassLibraryTask02;
using System.Text;
namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            IInventory inventory = new Inventory();
            inventory = new WeaponDecorator(inventory);
            inventory = new ArmorDecorator(inventory);
            inventory = new ArtifactDecorator(inventory);

            Hero warrior = new Warrior();
            warrior.SetInventory(inventory);

            Hero mage = new Mage();
            mage.SetInventory(inventory);

            Hero palladin = new Paladin();
            palladin.SetInventory(inventory);

            warrior.Attack();
            warrior.inventory.Equip();

            mage.Attack();
            mage.inventory.Equip();

            palladin.Attack();
            palladin.inventory.Equip();

            Console.ReadLine();
        }
    }
}