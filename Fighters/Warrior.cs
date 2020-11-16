using SwordAndFighter.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwordAndFighter.Fighters
{
    public class Warrior : Fighter
    {
        public Warrior() { }

        public override string Name { get; set; }

        public Skill Skill { get; set; }
        
        public Weapon Weapon { get; set; }
        private int _hp = 100;
        public override int Hp
        {
            get { return _hp; } set { _hp = value; }
        }

        public override void BasicAttack(Fighter foe)
        {
            foe.Hp -= Weapon.GetDamage();
            Skill.SkillCdTicking();
            Console.WriteLine($"{this.GetType().Name} {Name} attacked {foe.GetType().Name} {foe.Name} with basic attack using {Weapon.Type}");
        }

        public override void SkillAttack(Fighter foe)
        {
            if (CanUseSkill())
            {
                foe.Hp -= Skill.GetSkillDamage(Weapon.GetDamage());
                Skill.ResetSkillCd();
                Console.WriteLine($"{this.GetType().Name} {Name} attacked {foe.GetType().Name} {foe.Name} with skill attack using {Weapon.Type}");
                return;
            }

            Console.WriteLine($"Error: Check Skill Cd first before use");
        }

        public override bool CanUseSkill()
        {
            return !Skill.IsInCd();
        }
    }
}
