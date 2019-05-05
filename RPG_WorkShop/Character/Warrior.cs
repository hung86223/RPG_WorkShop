using System;

namespace RPG_WorkShop
{
    public class Warrior : ICharacter
    {
        public int blood
        {
            get => 15;
            set => throw new NotImplementedException();
        }

        public string Name
        {
            get => "Warrior";
            set => throw new NotImplementedException();
        }

        public int AttackPoint
        {
            get => 8;
            set => throw new NotImplementedException();
        }

        public int SkillPoint
        {
            get => 3;
            set => throw new NotImplementedException();
        }
    }
}