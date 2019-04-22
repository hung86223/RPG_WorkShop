using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_WorkShop
{
    public interface Character
    {
        int blood { get; set; }
        string Name { get; set; }

        string Attack();

        string Skill();
    }

    internal class Goblin : Character
    {
        public int blood { get; set; }
        public string Name { get; set; }

        public string Attack()
        {
            return "Use his Normal Attack for three points";
        }

        public string Skill()
        {
            return "";
        }
    }

    internal class Novice : Character
    {
        public int blood { get; set; }
        public string Name { get; set; }

        public string Attack()
        {
            return "";
        }

        public string Skill()
        {
            return "";
        }
    }

    internal class Priest : Character
    {
        public int blood { get; set; }
        public string Name { get; set; }

        public string Attack()
        {
            return "";
        }

        public string Skill()
        {
            return "";
        }
    }

    internal class Warrior : Character
    {
        public int blood { get; set; }
        public string Name { get; set; }

        public string Attack()
        {
            return "";
        }

        public string Skill()
        {
            return "";
        }
    }
}