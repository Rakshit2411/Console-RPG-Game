using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public class Game
    {
        public int UserInput { get; set; }
        public Hero Hero { get; set; }
        public Monster Monster { get; set; }

        Inventory inventory = new Inventory();

        public void Start()
        {
            this.CreateHeroAndMonster();
            this.Menu();
        }
        public void AskOption()
        {
            Console.WriteLine("\nPlease select your option by entering a number.");
            Console.Write("Options: \n1] Statistics \n2] Inventory \n3] Equip Weapon and armor \n4] Fight!! \n5] Quit\n");
        }
        public int CheckInput(int num1, int num2)
        {
            string input = Console.ReadLine();
            int num = 0;
            if (int.TryParse(input, out num))
            {
                if (num > num1 && num < num2)
                {
                    this.UserInput = num;
                    return num;
                }
                else
                {
                    Console.WriteLine("Please select a valid option from provided options.");
                    return this.CheckInput(num1, num2);
                }
            }
            else
            {
                Console.WriteLine("Please select a valid option from provided option.");
                return this.CheckInput(num1, num2);
            }
        }

        public void CreateHeroAndMonster()
        {
            Console.WriteLine("\nWelcome to 'FIGHT MASTER'(^_^)");
            Console.WriteLine("\nPlease enter your name to create a hero.");
            string name = Console.ReadLine();

            Hero hero = new Hero(name);
            this.Hero = hero;

            Console.WriteLine("\nOur hero has the following properties:");
            Console.WriteLine("\n" + hero.ToString());

            Monster monster = new Monster("Fire King");
            this.Monster = monster;

            Console.WriteLine("\nThe monster has the following properties:");
            Console.WriteLine("\n" + monster.ToString());
        }

        public void Menu()
        {
            this.AskOption();
            int entry = this.CheckInput(0, 6);

            switch (entry)
            {
                case 1:
                    Console.Clear();
                    this.Hero.ShowStats();
                    this.Menu();
                    break;
                case 2:
                    Console.Clear();
                    inventory.AddWeapons();
                    inventory.AddArmors();
                    inventory.ShowInventory();
                    this.Menu();
                    break;
                case 3:
                    Console.Clear();
                    if (inventory.WeaponsList.Count == 0 && inventory.ArmorsList.Count == 0)
                    {
                        inventory.AddWeapons();
                        inventory.AddArmors();
                    }
                    inventory.ShowInventory();
                    Hero.EquipWeapon();
                    Hero.EquipArmor();
                    this.Menu();
                    break;
                case 4:
                    Console.Clear();
                    var fight = new Fight(this.Monster, this.Hero);
                    if (this.Monster.CurrentHealth == 0 || this.Hero.CurrentHealth == 0)
                    {
                        Monster m = new Monster(this.Monster);
                        m.CurrentHealth = 200;

                        Hero h = new Hero(this.Hero);
                        h.CurrentHealth = 200;

                        fight = new Fight(m, h);
                    }
                    fight.MakeFight();
                    this.Menu();
                    break;
                case 5:
                    break;
            }
        }
    }
}
