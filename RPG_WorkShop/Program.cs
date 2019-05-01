using System;

namespace RPG_WorkShop
{
    internal class Program
    {
        private static void Main()
        {
            var enterGame = new EnterGame();

            var userName = "";

            do
            {
                Console.WriteLine(enterGame.WelcomeString());
                userName = Console.ReadLine();
            } while (userName == "");
            var signIn = new SignIn(userName);
            Console.WriteLine(enterGame.WelcomeResponse(userName));
            signIn.ChooseCharacter();
            signIn.Combat();
            Console.ReadLine();
        }
    }
}