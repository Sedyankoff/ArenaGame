using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class EnchantedBlade : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }
        public double AttackBoost { get; private set; }

        public EnchantedBlade(string name)
        {
            Name = name;
            AttackDamage = 25;
            BlockingPower = 5;
            AttackBoost = 10;
        }

        public double FuryOn()
        {
            return AttackDamage + AttackBoost;
        }
    }
}
