namespace RPG_WorkShop
{
    internal class EnterGame
    {
        public string WelcomeResponse(string userName)
        {
            var result = "Hi " + userName + " , please select your class.";
            return result;
        }

        public string WelcomeString()
        {
            var result = "Hi hero , welcome to SHIN INTERN MUSOU , please enter your name.";
            return result;
        }
    }
}