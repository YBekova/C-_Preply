namespace C__Preply;

public class Tester : Employee
{
    public string TestingType { get; set; }
    
    public Tester(string name, int salary,int hours, string testingType) : base(name, salary, hours)
    {
        TestingType = testingType;
    }

    public void TestProgramm()
    {
        Console.WriteLine($"{Name} does {TestingType} testing");
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is on vacation, do not disturb!");
    }
}