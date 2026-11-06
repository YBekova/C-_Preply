namespace C__Preply;

class Mage : Character
{
    public Mage(string name)
        : base(name)
    { }
    
    public override void Attack()
    {
        Console.WriteLine(Name + " применяет заклинание");
    }
}
