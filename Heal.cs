namespace C__Preply;

public class Heal : IAbility
{
    public void Use(Character character)
    {
        character.Heal(25,20);
    }
}