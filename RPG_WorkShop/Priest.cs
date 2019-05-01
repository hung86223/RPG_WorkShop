using System;

namespace RPG_WorkShop
{
    public class Priest : ICharacter
    {
        public int blood { get; set; }

        public string Name
        {
            get => "Priest";
            set => throw new NotImplementedException();
        }

        public string Attack()
        {
            return "";
        }

        public string Skill()
        {
            return "";
        }
    }
}