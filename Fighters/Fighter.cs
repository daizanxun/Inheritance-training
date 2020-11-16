using System;
using System.Collections.Generic;
using System.Text;

namespace SwordAndFighter.Fighters
{
    public abstract class Fighter
    {
        abstract public string Name { get; set; }

        abstract public int Hp { get; set; }

        abstract public bool CanUseSkill();
        abstract public void SkillAttack(Fighter foe);
        abstract public void BasicAttack(Fighter foe);
    }
}
