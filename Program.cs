using SwordAndFighter.Fighters;
using SwordAndFighter.Weapons;
using System;

namespace SwordAndFighter
{
    class Program
    {
        static void Main(string[] args)
        {
            var w1 = new Stick();
            var s1 = new Skill(5, 1.5f);
            var f1 = new Warrior();
            f1.Skill = s1;
            f1.Name = "DragonSlayer";
            f1.Weapon = w1;

            var w2 = new Staff();
            var s2 = new Skill(6, 2.0f);
            var f2 = new Mage();
            f2.Skill = s2;
            f2.Name = "ILikeFire";
            f2.Weapon = w2;

            var engine = new BattleEngine();
            var winner = engine.Battle(f1, f2);

            var origColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The Winner is ..... {winner.Name}");
            Console.ForegroundColor = origColor;
            Console.ReadLine();
        }
    }
}
