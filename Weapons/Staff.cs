using System;
using System.Collections.Generic;
using System.Text;

namespace SwordAndFighter.Weapons
{
    public class Staff : Weapon
    {
        public override string Type => "Staff";

        public override int GetDamage()
        {
            return new Random().Next(MinDamage, MaxDamage);
        }

        public int MinDamage => 3;
        public int MaxDamage => 7;
    }
}
