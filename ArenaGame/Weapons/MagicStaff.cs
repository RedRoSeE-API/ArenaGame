using System;
namespace ArenaGame
{
	public class MagicStaff : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public MagicStaff(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 5;
        }

        public void SpecialAbility(int mana, Hero hero)
        {
            if(mana < 50)
            {
                if(AttackDamage - (mana / 10) < 25)
                {
                    AttackDamage -= mana / 10;
                }
                else
                {
                    AttackDamage = 25;
                }
            }
            else
            {
                AttackDamage += 10;
            }

        }
    }
}


