using System;

namespace RPG_WorkShop
{
    internal class ChooseCareer
    {
        private readonly string _userName;
        private ICharacter profession = null;

        public ChooseCareer(string userName)
        {
            _userName = userName;
        }

        public void ChooseCharacter()
        {
            Console.WriteLine("type [Novice],[Warrior],or[Priest] to create your character.");
            var character = Console.ReadLine();
            switch (character)
            {
                case "Novice":
                    profession = new Novice();
                    break;

                case "Warrior":
                    profession = new Warrior();

                    break;

                case "Priest":
                    profession = new Priest();
                    break;
            }

            if (profession != null)
            {
                Console.WriteLine("Hi " + profession.Name + " " + _userName + ", there is a Goblin");
            }
        }

        public ICharacter GetCharacter()
        {
            return profession;
        }
    }
}