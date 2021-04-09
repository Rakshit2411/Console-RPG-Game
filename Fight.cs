using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public class Fight
    {
        public Monster monster { get; set; }
        public Hero hero { get; set; }

        public Fight(Monster m, Hero h)
        {
            this.monster = m;
            this.hero = h;
        }

        public void MakeFight()
        {
            Console.WriteLine("\nHero and monster are ready to fight. Are you ready?");
            Console.WriteLine("[Press 'h'/'H' to attack on monster and press 'm'/'M' to attack on hero.]");
            while (this.hero.CurrentHealth >= 0 && this.monster.CurrentHealth >= 0)
            {
                ConsoleKeyInfo info = Console.ReadKey();

                if (info.KeyChar == 'h' || info.KeyChar == 'H')
                {
                    this.HeroTurn();
                }
                else if (info.KeyChar == 'm' || info.KeyChar == 'M')
                {
                    this.MonsterTurn();
                }
                else
                {
                    Console.WriteLine("\nYou are in a fight!! Keep fighting and defeat the monster...!!");
                }
            }

            if (this.hero.CurrentHealth <= 0)
            {
                this.MonsterWin();
            }
            else if (this.monster.CurrentHealth <= 0)
            {
                this.HeroWin();
            }
        }

        public void HeroTurn()
        {
            int heroPower = 0;
            if (this.hero.EquippedWeapon == null)
            {
                heroPower = this.hero.Strength;
            }
            else
            {
                heroPower = this.hero.Strength + this.hero.EquippedWeapon.Power;
            }
            int heroDefense = 0;
            if (this.hero.EquippedArmor == null)
            {
                heroDefense = this.hero.Defense;
            }
            else
            {
                heroDefense = this.hero.Defense + this.hero.EquippedArmor.Power;
            }
            int monsterLostHp = heroPower - this.monster.Defense;

            Console.WriteLine("\n" + this.hero.Name + " atacked on " + this.monster.Name + " with the power of " + heroPower);

            if (monsterLostHp > 0)
            {
                this.monster.CurrentHealth -= monsterLostHp;
                Console.WriteLine(this.monster.Name + " lost " + monsterLostHp + " HP");
                Console.WriteLine(this.monster.Name + " blocked " + (heroPower - monsterLostHp) + " HP");
            }
            else
            {
                Console.WriteLine(this.monster.Name + " did not lose any HP.");
                Console.WriteLine(this.monster.Name + " blocked " + heroPower + " HP");
            }
        }

        public void MonsterTurn()
        {
            int monsterPower = this.monster.Strength;
            int monsterDefense = this.monster.Defense;
            int heroLostHp = 0;
            if (this.hero.EquippedWeapon == null)
            {
                heroLostHp = monsterPower;
            }
            else
            {
                heroLostHp = monsterPower - (this.hero.Defense + this.hero.EquippedArmor.Power);
            }

            Console.WriteLine("\n" + this.monster.Name + " atacked on " + this.hero.Name + " with the power of " + monsterPower);

            if (heroLostHp > 0)
            {
                this.hero.CurrentHealth -= heroLostHp;
                Console.WriteLine(this.hero.Name + " lost " + heroLostHp + " HP");
                Console.WriteLine(this.hero.Name + " blocked " + (monsterPower - heroLostHp) + " HP");
            }
            else
            {
                Console.WriteLine(this.hero.Name + " did not lose any HP.");
                Console.WriteLine(this.hero.Name + " blocked " + monsterPower + " HP");
            }
        }

        public void HeroWin()
        {
            this.hero.Win++;
            Console.WriteLine("\n You won!!! Congratulations....");
            Console.WriteLine("You have defeated the monster.");
        }

        public void MonsterWin()
        {
            this.hero.Loss++;
            Console.WriteLine("\n You loss!!! Better luck next time....");
            Console.WriteLine("You have been defeated by the monster.");
        }
    }
}
