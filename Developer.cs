namespace C__Preply;

public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }
    public Developer(string name, int salary, int hours,string programmingLanguage) : base(name, salary, hours)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public void WriteCode()
    {
        Console.WriteLine($"{Name} is writing code in {ProgrammingLanguage}");
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} does not work today their hours is 0 - day off");
    }
}