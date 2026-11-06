namespace C__Preply;

class Warrior : Character, IDefender
{
    public Warrior(string name)
        : base(name)
    { }
    
    public override void Attack()
    {
        Console.WriteLine(
            Name + " атакует мечом");
    }

    public void Defend()
    {
        Console.WriteLine("Warrior is defended with shield!");
    }
}
