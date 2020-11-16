using System;
using System.Collections.Generic;
using System.Text;

namespace SwordAndFighter.Weapons
{
    public class Stick : Weapon
    {
        public override string Type => "Stick";

        public override int GetDamage()
        {
            return new Random().Next(MinDamage, MaxDamage);
        }

        public int MinDamage => 1;
        public int MaxDamage => 9;
    }
}
