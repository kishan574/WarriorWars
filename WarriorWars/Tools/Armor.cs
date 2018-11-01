using WarriorWars.Enum;

namespace WarriorWars.Tools
{
     class Armor
    {
        private const int goodArmor = 5; 
        private const int badArmor = 5;

        private int armorpoints;

        public int Armorpoints
        {
            get
            {
                return armorpoints;
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.goodGuy:
                    armorpoints = goodArmor;
                    break;

                case Faction.badGuy:
                    armorpoints = badArmor;
                    break;

                default:
                    break;
            }
        }

        
}
}