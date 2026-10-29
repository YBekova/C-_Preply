namespace C__Preply;

public class Designer : Employee
{
    public string DesignTool { get; set; }
    
    public Designer(string name, int salary, int hours, string designTool) : base(name, salary, hours)
    {
        DesignTool = designTool;
    }

    public void CreateDesign()
    {
        Console.WriteLine($"{Name} makes designs in {DesignTool}");
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is working only 4 today, working hours - 4");
    }
}