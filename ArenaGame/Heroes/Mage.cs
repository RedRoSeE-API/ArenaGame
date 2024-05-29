using System;
namespace ArenaGame.Heroes
{
	public class Mage : Hero
    {

        private int mana;
        public Mage(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            Weapon.SpecialAbility(mana, this);
            double damage = base.Attack();

            if (mana == 100)
            {
                DrainMana();
                base.Armor += 5;  // Bonus Arrmor 
                return damage += base.Attack() * 0.50; // Additional burst of magic damage (50% of base damage)                
            }

            damage += base.Attack();
            RestoreMana(40);
            return damage;
        }

        public override double Defend(double damage)
        {
            return base.Defend(damage);
        }

        private void RestoreMana(int amount)
        {
            // Logic to restore mana
            mana += amount;
        }
        
        private void DrainMana()
        {
            // Logic to drain mana
            mana = 0;
        }
    }
}

