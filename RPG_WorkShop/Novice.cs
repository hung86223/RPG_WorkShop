using System;

namespace RPG_WorkShop
{
    public class Novice : ICharacter
    {
        public int blood { get; set; }

        public string Name
        {
            get => "Novice";
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