using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public class Armor
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public Armor(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }
        public override string ToString()
        {
            return "\tName: " + this.Name+ "\tPower: " + this.Power;
        }
    }
}
