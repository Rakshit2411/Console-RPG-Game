using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public class Inventory
    {
        public Game game { get; set; }
        public List<Weapon> WeaponsList { get; set; }
        public List<Armor> ArmorsList { get; set; }

        public Inventory()
        {
            this.WeaponsList = new List<Weapon>();
            this.ArmorsList = new List<Armor>();
        }

        public void AddWeapons()
        {
            Weapon CrossBow = new Weapon("Crossbow", 5);
            this.WeaponsList.Add(CrossBow);

            Weapon Sward = new Weapon("Sward", 10);
            this.WeaponsList.Add(Sward);

            Weapon Gun = new Weapon("Gun", 20);
            this.WeaponsList.Add(Gun);

            Weapon Dagger = new Weapon("Dagger", 5);
            this.WeaponsList.Add(Dagger);

            Weapon Bomb = new Weapon("Bomb", 15);
            this.WeaponsList.Add(Bomb);

            Weapon TimeBomb = new Weapon("Time Bomb", 20);
            this.WeaponsList.Add(TimeBomb);

            Weapon TearGas = new Weapon("Tear Gas", 10);
            this.WeaponsList.Add(TearGas);

            Weapon Spear = new Weapon("Spear", 15);
            this.WeaponsList.Add(Spear);

            Weapon MachineGun = new Weapon("Machine Gun", 30);
            this.WeaponsList.Add(MachineGun);

            Weapon Cannon = new Weapon("Cannon", 30);
            this.WeaponsList.Add(Cannon);
        }

        public void AddArmors()
        {
            Armor Bronze = new Armor("Bronze Armor", 10);
            this.ArmorsList.Add(Bronze);

            Armor Silver = new Armor("Silver Armor", 15);
            this.ArmorsList.Add(Silver);

            Armor Gold = new Armor("Gold Armor", 20);
            this.ArmorsList.Add(Gold);

            Armor Platinum = new Armor("Platinum Armor", 30);
            this.ArmorsList.Add(Platinum);
        }

        public void ShowInventory()
        {            
            int num1 = 1;
            int num2 = 1;

            Console.WriteLine("\nWeapons:");
            foreach (var item in this.WeaponsList)
            {
                Console.WriteLine(num1 + "] " + item.ToString());
                num1++;
            }

            Console.WriteLine("\nArmors:");
            foreach (var item in this.ArmorsList)
            {
                Console.WriteLine(num2 + "] " + item.ToString());
                num2++;
            }
        }
    }
}
