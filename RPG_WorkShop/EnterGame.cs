using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_WorkShop
{
    internal class EnterGame
    {
        public string WelcomeResponse(string UserName)
        {
            var result = "Hi " + UserName + " , please select your class.";
            return result;
        }

        public string WelcomeString()
        {
            var result = "Hi hero , welcome to SHIN INTERN MUSOU , please enter your name.";
            return result;
        }
    }
}