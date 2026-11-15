using System.Reflection.Metadata;

namespace C__Preply;

public class Fireball : IAbility
{
    public virtual void Use(Character character)
    {
        character.SpendMana(30);
        Console.WriteLine($"{character.Name} uses fireball!!! Mana minus 30!");
    }
}