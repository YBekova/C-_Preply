namespace C__Preply;

public class Player
{
    public string Name;
    private int _health;
    private Weapon _weapon;
    public static int PlayerCount;

    public Player(string name, int health, Weapon weapon)
    {
        Name = name;
        _health = health;
        _weapon = weapon;
        
        PlayerCount++;
    }

    public void TakeDamage(int damage)
    {
        if (_health - damage < 0) _health = 0;
        else _health -= damage;
    }

    public void Attack(Player target)
    {
        if (target == this)
        {
            Console.WriteLine("Dont shoot yourself!!!");
            return;
        }
        
        if (_health == 0)
        {
            Console.WriteLine($"{Name} is dead, cant attack!!!");
        }
        else
        {
            target.TakeDamage(_weapon.GetDamage());
        }
    }
    
    public void ShowInfo()
    {
        Console.WriteLine($"In {Name} left {_health} health");
    }
}