using System;
using System.Collections.Generic;
using System.Text;

namespace SwordAndFighter.Weapons
{
    public class Sword : Weapon
    {
        public override string Type => "Sword";

        public override int GetDamage()
        {
            return new Random().Next(MinDamage, MaxDamage);
        }

        public int MinDamage => 4;
        public int MaxDamage => 6;
    }
}
