using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorWars.Tools
{
    static class Tools
    {
        public static void color( string txt , ConsoleColor color )
        {
            Console.ForegroundColor = color;
            Console.WriteLine(txt);
            Console.ResetColor();

        }
    }
}
