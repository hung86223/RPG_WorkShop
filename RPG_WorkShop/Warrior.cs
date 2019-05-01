using System;

namespace RPG_WorkShop
{
    public class Warrior : ICharacter
    {
        public int blood { get; set; }

        public string Name
        {
            get => "Warrior";
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