using System;
using System.Collections.Generic;
using System.Text;

namespace SwordAndFighter
{
    public class Skill
    {
        public int SkillCoolDown { get; }
        public float DamageMultiplier { get; }

        public Skill(int skillCoolDown, float damageMultiplier)
        {
            SkillCoolDown = skillCoolDown;
            DamageMultiplier = damageMultiplier;
        }

        private int _skillCdTick = 0;

        public int GetSkillDamage(int baseAttack)
        {
            if (!IsInCd())
                return 0;
            return (int)(baseAttack * DamageMultiplier);
        }

        public bool IsInCd()
        {
            return _skillCdTick > 0;
        }

        public void ResetSkillCd()
        {
            _skillCdTick = SkillCoolDown;
        }

        public void SkillCdTicking()
        {
            if (_skillCdTick > 0)
                _skillCdTick--;
        }
    }
}
