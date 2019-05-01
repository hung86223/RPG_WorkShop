namespace RPG_WorkShop
{
    public interface ICharacter
    {
        int blood { get; set; }
        string Name { get; set; }

        string Attack();

        string Skill();
    }
}