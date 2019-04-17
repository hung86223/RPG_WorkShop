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
            var EnterGame = new EnterGame();
            Console.WriteLine(EnterGame.WelcomeString());
            string UserName = Console.ReadLine();
            Console.WriteLine(EnterGame.WelcomeResponse(UserName));
            Console.ReadLine();
        }
    }
}