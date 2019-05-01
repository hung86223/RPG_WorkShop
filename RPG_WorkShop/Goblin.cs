using System;

namespace RPG_WorkShop
{
    public class Goblin : ICharacter
    {
        public int blood { get; set; }

        public string Name
        {
            get => "Goblin";
            set => throw new NotImplementedException();
        }

        public string Attack()
        {
            return "Use his Normal Attack for three points";
        }

        public string Skill()
        {
            return "";
        }
    }
}