using System;
namespace ArenaGame.Weapons
{
	public class Bow : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        private int hitCount;

        protected Random random;

        public Bow(string name)
        {
            Name = name;
            AttackDamage = 35;
            BlockingPower = 5;
        }


        public void SpecialAbility(int value, Hero hero)
        {
            hitCount++;
            if(hitCount > 1)
            {
                AttackDamage += 5;
                hitCount = 0;
            }
            else if ( hitCount == 3)
            {
                hitCount = 0;
            }
            else if (hitCount == 0)
            {
                AttackDamage -= 10;
            }

            hitCount++;

        }

    }
}

