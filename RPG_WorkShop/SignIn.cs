using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_WorkShop
{
    internal class SignIn
    {
        public string Sign(string UserName)
        {
            return UserName;
        }

        public void ChooseCharacter(string UserName)
        {
            Console.WriteLine("type [Novice],[Warrior],or[Priest] to create your character.");
            var charactor = Console.ReadLine();
            Charactor profession;
            switch (charactor)
            {
                case "Novice":
                    profession = new Novice();
                    Console.WriteLine("Hi Novice " + UserName + ", there is a goblin"); break;
                case "Warrior":
                    profession = new Warrior();
                    Console.WriteLine("Hi Warrior " + UserName + ", there is a goblin"); break;
                case "Priest":
                    profession = new Priest();
                    Console.WriteLine("Hi Priest " + UserName + ", there is a goblin"); break;
            }
        }
    }
}