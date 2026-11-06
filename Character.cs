namespace C__Preply;

abstract class Character : IAttacker
{
    public string Name { get; set; }
 
    public Character(string name)
    {
        Name = name;
    }

    public abstract void Attack();
}