using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Mage : Hero
    {
        private double mana;

        public Mage(string name, double armor, double strenght, IWeapon weapon, double mana) : base(name, armor, strenght, weapon)
        {
            this.mana = mana;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            if (mana >= 10)
            {
                mana -= 10;
                damage *= 2;
            }
            return damage;
        }

        public override double Defend(double damage)
        {
            mana += 5;
            return base.Defend(damage);
        }
    }
}
