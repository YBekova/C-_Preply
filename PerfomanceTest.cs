namespace C__Preply;

public class PerformanceTest : TestRun
{
    public int LimitSeconds { get; private set; }
    
    public PerformanceTest(string name, DateTime startsAt, DateTime endsAt, int limitSeconds) : base(name, startsAt, endsAt)
    {
        if (limitSeconds <= 0)
        {
            throw new ArgumentException("Limit must be positive number!");
        }

        LimitSeconds = limitSeconds;
    }

    public override bool IsPassed()
    {
        return GetDuration.TotalSeconds <= LimitSeconds;
    }
}