using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WarriorWars.Enum;
using WarriorWars.Tools;

namespace WarriorWars
{
    class Warrior
    {
        private const int goodInitiaHealth = 50;
        private const int badInitialHealth = 50;

        private readonly Faction faction; //good guy-bad guy

        private int health;
        private string name;
        private bool isAlive;

        public bool ISAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapons weapons;
        private Armor armor;

        public Warrior(string name , Faction faction)
        {
            this.name = name;
            this.faction = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.goodGuy:
                    weapons = new Weapons(faction);
                    armor = new Armor(faction);
                    health = goodInitiaHealth;

                    break;
                case Faction.badGuy:
                    weapons = new Weapons(faction);
                    armor = new Armor(faction);
                    health = badInitialHealth;

                    break;
                default:
                    break;
            }

        }

        public void Attack(Warrior enemy)
        {
            int damage = weapons.Damage / enemy.armor.Armorpoints;

            enemy.health -= damage;

            AttackResult(enemy, damage);
            Thread.Sleep(600);
        }

        private void AttackResult(Warrior enemy, int damage)
        {
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;

                Tools.Tools.color($"{enemy.name} defeated", ConsoleColor.Red);
                Tools.Tools.color($"{name} wins", ConsoleColor.Green);
            }

            else
            {
                Console.WriteLine($"{name.ToUpper()} attacks {enemy.name.ToLower()}");
                Console.WriteLine($"Causes {damage} damage and enemy {enemy.name} health is {enemy.health}");
            }
        }
    }

}
