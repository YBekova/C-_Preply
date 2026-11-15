using C__Preply;

Character hero = new Character("Vinland", 50, 100,100);

List<IAbility> abilities = new List<IAbility>()
{
   new Heal(),
   new Heal(),
   new Heal(),
   new Fireball(),
   new Fireball()
    
};

AbilityService service = new AbilityService();

var successCount = 0;
var errorCount= 0;

foreach (IAbility ability in abilities)
{
   try
   {
      service.UseAbility(ability, hero);
      successCount++;
   }
   catch (NotEnoughManaException ex)
   {
      Console.WriteLine(ex.Message);
      errorCount++;
   }
   catch (FullHealthException ex)
   {
      Console.WriteLine(ex.Message);
      errorCount++;
   }
   catch (Exception ex)
   {
      Console.WriteLine(ex.Message);
   }
   
   Console.WriteLine($"\n{hero.Name} has health = {hero.HP} and magic mana = {hero.MP}");
}

Console.WriteLine($"\nSuccessful uses: {successCount}");
Console.WriteLine($"Failed uses: {errorCount}");