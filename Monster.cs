using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public class Monster
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHealth { get; set; }
        public int CurrentHealth { get; set; }

        public Monster(Monster m)
        {
        }
        public Monster(string name)
        {
            this.Name = name;
            this.Strength = 80;
            this.Defense = 50;
            this.OriginalHealth = 200;
            this.CurrentHealth = 200;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\nStrength: " + this.Strength + "\nDefense: " + this.Defense + "\nHealth: " + this.OriginalHealth;
        }
    }
}
