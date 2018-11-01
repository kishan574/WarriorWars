using System;
using WarriorWars.Enum;

namespace WarriorWars.Tools
{
     class Weapons
    {
        private const int goodDamage = 24;
        private const int badDamage = 24;

        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public Weapons(Faction faction)
        {
            switch (faction)
            {
                case Faction.goodGuy:
                    damage = goodDamage;
                    break;

                case Faction.badGuy:
                    damage = badDamage;
                    break;

                default:
                    break;
            }

        }

    }
}