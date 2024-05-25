using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Archer : Hero
    {
        private int multiShotFrequency;
        private int attackCounter;

        public Archer(string name, double armor, double strength, IWeapon weapon) : base(name, armor, strength, weapon)
        {
            multiShotFrequency = 3;
            attackCounter = 0;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            attackCounter++;

            if (attackCounter % multiShotFrequency == 0)
            {
                damage *= 2;
            }

            return damage;
        }

        public override double Defend(double damage)
        {
            return base.Defend(damage);
        }
    }
}
