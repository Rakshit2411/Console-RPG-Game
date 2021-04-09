using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public Weapon(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

        public override string ToString()
        {
            return "\tName: " + this.Name + "\t    Power: " + this.Power;
        }
    }
}
