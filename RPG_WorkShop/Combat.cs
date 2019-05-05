using System;

namespace RPG_WorkShop
{
    internal class Combat
    {
        private readonly ICharacter _character;
        private readonly string _userName;
        private Goblin goblin = new Goblin();
        private int _blood;
        private int _monsterBlood;

        public Combat(string userName, ICharacter character)
        {
            _userName = userName;
            _character = character;
            _blood = character.blood;
            _monsterBlood = goblin.blood;
        }

        public void DisplayStatus()
        {
            Console.WriteLine("The Goblin Blood:" + goblin.blood
                                                  + " Attack:" + goblin.AttackPoint
                                                  + " Skill:" + goblin.SkillPoint);

            Console.WriteLine(_userName
                              + "(" + _character.Name
                              + ") Blood:" + _character.blood
                              + " Attack:" + _character.AttackPoint
                              + " Skill:" + _character.SkillPoint);
        }

        public void CharacterAction()
        {
            Console.WriteLine("Please choose your action(Attack,Skill,Run)");
            var action = Console.ReadLine();
            var result = "";

            var point = 0;
            switch (action)
            {
                case ("Attack"):
                    point = _character.AttackPoint;
                    result = _userName + "(" + _character.Name + ")" + ",使用普通攻擊,造成" + point + "點傷害";
                    break;

                case ("Skill"):
                    point = _character.SkillPoint;
                    result = _userName + "(" + _character.Name + ")" + ",用燒毀魔法攻擊,造成" + point + "點傷害";
                    break;

                case ("Run"):
                    result = _userName + "(" + _character.Name + ")" + ",害怕怪物,快速逃跑!!";
                    break; ;
            }
            _monsterBlood -= point;
            var status = "The Goblin Blood: " + _monsterBlood;
            Console.WriteLine(result);
            Console.WriteLine(status);
        }

        public void MonsterAction()
        {
            var goblin = new Goblin();
            Console.WriteLine(goblin.Name);
        }
    }
}