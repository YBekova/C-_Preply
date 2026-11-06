namespace C__Preply;

class Tower : IAttacker, IDefender
{
    public void Attack()
    {
        Console.WriteLine(
            "Башня стреляет снарядом");
    }

    public void Defend()
    {
        Console.WriteLine("Tower is defended using spikes!");
    }
}