using System.Runtime.CompilerServices;

namespace C__Preply;

public class Character
{
    public string Name { get; private set; }
    public int HP{get; private set;}
    public int MaxHP{get; private set;}
    public int MP{get; private set;}

    public Character(string name, int hp, int maxHP, int mp)
    {
        if (maxHP <= 0)
        {
            throw new ArgumentException("Your maximum HP must be greater than 0!");
        }

        if (hp < 0 || hp > maxHP)
        {
            throw new ArgumentException("Your hp must be between 0 and maximum HP!");
        }

        if (mp < 0)
        {
            throw new ArgumentException("Mana must be greater than 0!");
        }
        
        Name = name;
        HP = hp;
        MaxHP = maxHP;
        MP = mp;
    }
    
    public void SpendMana(int amount)
    {
        if (MP < amount)
        {
            throw new NotEnoughManaException("You don't have enough mana!");
        }
        MP -= amount;
    }

    public void Heal(int amount, int manaCost)
    {
        if (HP == MaxHP)
        {
            throw new FullHealthException("Your health is already full!");
        }
        
        SpendMana(manaCost);
        
        HP = Math.Min(HP + amount, MaxHP);
    }
}