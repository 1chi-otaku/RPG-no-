using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_no_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Human("Hel");
            hero = new Warrior(hero);
            hero = new SwordMan(hero);
            hero = new Rider(hero);
            Console.WriteLine(hero.ToString());
        }
    }
}
