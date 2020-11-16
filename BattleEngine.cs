using SwordAndFighter.Fighters;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwordAndFighter
{
    public class BattleEngine
    {
        public Fighter Battle(Fighter f1, Fighter f2)
        {
            while(true)
            {
                SingleAttach(f1, f2);
                if (f2.Hp <= 0)
                {
                    return f1;
                }

                SingleAttach(f2, f1);
                if (f1.Hp <= 0)
                {
                    return f2;
                }
            }
        }

        private void SingleAttach(Fighter f1, Fighter f2)
        {
            if (f1.CanUseSkill())
            {
                f1.SkillAttack(f2);
            }
            else
            {
                f1.BasicAttack(f2);
            }
        }
    }
}
