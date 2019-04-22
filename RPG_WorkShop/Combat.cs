using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPG_WorkShop
{
    internal class Combat
    {
        public Combat()
        {
            CharacterAction();
            MonsterAction();
        }

        private void CharacterAction()
        {
            Console.WriteLine("Please choose your action(Attack,Skill,Run)");
            var action = Console.ReadLine();
            var result = "";
            switch (action)
            {
                case ("Attack"):
                    result = "UserName,用笨拙小刀攻擊,造成3點傷害";
                    break;

                case ("Skill"):
                    result = "UserName,用燒毀魔法攻擊,造成8點傷害";
                    break;

                case ("Run"):
                    result = "UserName,害怕怪物,快速逃跑!!";
                    break; ;
            }
            Console.WriteLine(result);
        }

        private void MonsterAction()
        {
            Goblin goblin = new Goblin();
            Console.WriteLine(goblin.Name + goblin.Attack());
        }
    }
}