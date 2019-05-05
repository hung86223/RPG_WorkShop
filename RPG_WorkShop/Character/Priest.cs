using System;

namespace RPG_WorkShop
{
    public class Priest : ICharacter
    {
        public int blood
        {
            get => 12;
            set => throw new NotImplementedException();
        }

        public string Name
        {
            get => "Priest";
            set => throw new NotImplementedException();
        }

        public int AttackPoint
        {
            get => 2;
            set => throw new NotImplementedException();
        }

        public int SkillPoint
        {
            get => 5;
            set => throw new NotImplementedException();
        }
    }
}