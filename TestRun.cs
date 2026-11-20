namespace C__Preply;

public abstract class TestRun
{
    public string Name { get; private set; }
    public DateTime StartsAt { get; private set; }
    public  DateTime EndsAt { get; private set; }
    public TimeSpan GetDuration => EndsAt - StartsAt;

    public TestRun(string name, DateTime startsAt, DateTime endsAt)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Test name can't be empty!");
        }

        if (endsAt < startsAt)
        {
            throw new ArgumentException("End time cannot be earlier than start time!");
        }

        Name = name;
        StartsAt = startsAt;
        EndsAt = endsAt;
    }
    

    public abstract bool IsPassed();


}