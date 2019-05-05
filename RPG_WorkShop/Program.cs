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
            var choose = new ChooseCareer(userName);
            Console.WriteLine(enterGame.WelcomeResponse(userName));
            choose.ChooseCharacter();
            var combat = new Combat(userName, choose.GetCharacter());
            combat.CharacterAction();
            Console.ReadLine();
        }
    }
}