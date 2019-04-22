using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_WorkShop
{
    public interface Charactor
    {
        string Name { get; set; }
        int blood { get; set; }

        string Attack();

        string Skill();
    }

    internal class Warrior : Charactor
    {
        public string Name { get; set; }
        public int blood { get; set; }

        public string Attack()
        {
            return "";
        }

        public string Skill()
        {
            return "";
        }
    }

    internal class Priest : Charactor
    {
        public string Name { get; set; }
        public int blood { get; set; }

        public string Attack()
        {
            return "";
        }

        public string Skill()
        {
            return "";
        }
    }

    internal class Novice : Charactor
    {
        public string Name { get; set; }
        public int blood { get; set; }

        public string Attack()
        {
            return "";
        }

        public string Skill()
        {
            return "";
        }
    }

    internal class Goblin : Charactor
    {
        public string Name { get; set; }
        public int blood { get; set; }

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