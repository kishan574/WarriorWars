using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorWars.Enum;

namespace WarriorWars
{
    class EntryPoint
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("Avengers", Faction.goodGuy);
            Warrior badGuy = new Warrior("Thanos", Faction.badGuy);


            while (badGuy.ISAlive && goodGuy.ISAlive)
            {
                if( rand.Next(0,10) < 5 )
                {
                    goodGuy.Attack(badGuy);
                    
                }

                else
                {
                    badGuy.Attack(goodGuy);
                }
                Console.WriteLine("...............................................");
            }

            Console.ReadKey();

        }
    }
}
