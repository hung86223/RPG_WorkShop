namespace RPG_WorkShop
{
    public interface ICharacter
    {
        int blood { get; set; }
        string Name { get; set; }

        int AttackPoint { get; set; }

        int SkillPoint { get; set; }
    }
}