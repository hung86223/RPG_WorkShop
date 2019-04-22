using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_WorkShop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var SignIn = new SignIn();
            var EnterGame = new EnterGame();
            
            string UserName = "";

            do
            {
                Console.WriteLine(EnterGame.WelcomeString());
                UserName = Console.ReadLine();
            } while (UserName == "");

            Console.WriteLine(EnterGame.WelcomeResponse(UserName));
            SignIn.ChooseCharacter(UserName);
            Console.ReadLine();
        }
    }
}