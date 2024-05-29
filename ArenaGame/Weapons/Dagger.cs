using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public int hitCount { get; private set; }

        public Dagger(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 1;
        }

        public void SpecialAbility(int value, Hero hero)
        {

            if (hitCount < 3)
            {
                BlockingPower += 1;
                hitCount++;
            }
            else
            {
                BlockingPower -= 2;
                hitCount = 0;
            }


            
        }
    }
}
