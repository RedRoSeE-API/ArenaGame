using System;
namespace ArenaGame
{
	public class Archer : Hero
    {
        private double hitCount;

        public Archer(string name, double armor, double strenght, IWeapon weapon) :
            base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            Weapon.SpecialAbility(0, this);

            double damage = base.Attack();

            double probability = random.NextDouble();
            if (probability < 0.30)
            {
                damage += base.Attack() * 0.50; // Additional hit dealing 50% of the base damage
            }
            return damage;
        }

        public override double Defend(double damage)
        {
            hitCount++;
            if (hitCount == 4)
            {
                hitCount = 0;
                return base.Defend(damage * 0.5);
            }
            return base.Defend(damage);
        }
    }
}

