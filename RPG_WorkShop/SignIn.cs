using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_WorkShop
{
    internal class SignIn
    {
        private readonly string _userName;

        public SignIn(string userName)
        {
            _userName = userName;
        }

        public void ChooseCharacter()
        {
            Console.WriteLine("type [Novice],[Warrior],or[Priest] to create your character.");
            var character = Console.ReadLine();
            ICharacter profession;
            switch (character)
            {
                case "Novice":
                    profession = new Novice();

                    Console.WriteLine("Hi " + profession.Name + " " + _userName + ", there is a goblin");

                    break;

                case "Warrior":
                    profession = new Warrior();
                    Console.WriteLine("Hi" + profession.Name + " " + _userName + ", there is a goblin");
                    break;

                case "Priest":
                    profession = new Priest();
                    Console.WriteLine("Hi " + profession.Name + " " + _userName + ", there is a goblin");
                    break;
            }
        }

        public void Combat()
        {
            var combat = new Combat(_userName);
        }
    }
}