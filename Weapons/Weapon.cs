using System;
using System.Collections.Generic;
using System.Text;

namespace SwordAndFighter.Weapons
{
    public abstract class Weapon
    {
        abstract public string Type { get; }
        abstract public int GetDamage();
    }
}
