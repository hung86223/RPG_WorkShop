using System;

namespace RPG_WorkShop
{
    public class Novice : ICharacter
    {
        public int blood
        {
            get => 10;
            set => throw new NotImplementedException();
        }

        public string Name
        {
            get => "Novice";
            set => throw new NotImplementedException();
        }

        public int AttackPoint
        {
            get => 3;
            set => throw new NotImplementedException();
        }

        public int SkillPoint
        {
            get => 3;
            set => throw new NotImplementedException();
        }
    }
}