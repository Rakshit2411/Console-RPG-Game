using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public class Hero
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHealth { get; set; }
        public int CurrentHealth { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }
        public List<Weapon> WeaponsBag { get; set; }
        public List<Armor> ArmorsBag { get; set; }
        public int Win { get; set; }
        public int Loss { get; set; }

        public Game game = new Game();

        public Inventory inventory = new Inventory();

        public Hero()
        {
            this.WeaponsBag = new List<Weapon>();
            this.ArmorsBag = new List<Armor>();
        }

        public Hero(Hero h)
        {
        }
        public Hero(string name)
        {
            this.Name = name;
            this.Strength = 50;
            this.Defense = 20;
            this.OriginalHealth = 200;
            this.CurrentHealth = 200;
            inventory.AddWeapons();
            inventory.AddArmors();
            this.WeaponsBag = inventory.WeaponsList;
            this.ArmorsBag = inventory.ArmorsList;
            this.Win = 0;
            this.Loss = 0;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\nStrength: " + this.Strength + "\nDefense: " + this.Defense + "\nHealth: " + this.OriginalHealth;
        }

        public void EquipWeapon()
        {
            Console.WriteLine("\nPlease enter a number to equip a weapon for your fight..!!");

            int input = this.game.CheckInput(0, WeaponsBag.Count + 1);
            this.EquippedWeapon = this.WeaponsBag[input - 1];

            Console.WriteLine("\n Congratulations you have selected the following weapon.");
            Console.WriteLine(this.EquippedWeapon.ToString());
        }

        public void EquipArmor()
        {
            Console.WriteLine("\nPlease enter a number to equip a armor to protect your self..!!");

            int input = this.game.CheckInput(0, this.ArmorsBag.Count + 1);
            this.EquippedArmor = this.ArmorsBag[input - 1];

            Console.WriteLine("\n Congratulations you have selected the following armor.");
            Console.WriteLine(this.EquippedArmor.ToString());
        }

        public void ShowStats()
        {
            Console.WriteLine("\n Your statistics:");
            Console.WriteLine("You have played total {0} games so far.", (this.Win + this.Loss));
            Console.WriteLine("You have won {0} games.", this.Win);
            Console.WriteLine("You have loss {0} games.", this.Loss);
        }
    }
}
