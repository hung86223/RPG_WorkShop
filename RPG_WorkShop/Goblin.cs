﻿using System;

namespace RPG_WorkShop
{
    public class Goblin : ICharacter
    {
        public int blood
        {
            get => 15;
            set => throw new NotImplementedException();
        }

        public string Name
        {
            get => "Goblin";
            set => throw new NotImplementedException();
        }

        public int AttackPoint
        {
            get => 3;
            set => throw new NotImplementedException();
        }

        public int SkillPoint
        {
            get => 3;
            set => throw new NotImplementedException();
        }
    }
}