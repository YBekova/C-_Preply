namespace C__Preply;

public class Weapon
{
    public string Name;
    private int damage;

    public Weapon(string name, int damage)
    {
        Name = name;
        this.damage = damage;
    }

    public int GetDamage()
    {
        return damage;
    }
}