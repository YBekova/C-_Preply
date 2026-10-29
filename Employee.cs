namespace C__Preply;

public class Employee
{
    public string Name { get; set; } 
    public int Salary { get; set; }
    
    public int Hours { get; set; }

    public Employee(string name, int salary, int hours)
    {
        Name = name;
        Salary = salary;
        Hours = hours;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Name} has salary - {Salary}");
    }

    public virtual void Work()
    {
        Console.WriteLine($"{Name} works {Hours} today");
    }
}