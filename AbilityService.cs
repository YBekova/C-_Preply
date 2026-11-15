namespace C__Preply;

public class AbilityService 
{
    public void UseAbility(IAbility ability, Character character)
    {
        ability.Use(character);
    }
}