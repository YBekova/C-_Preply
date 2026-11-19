namespace C__Preply;

public class FunctionalTest : TestRun
{
    public string ExpectedText { get; private set; }
    public string ActualText { get; private set; }
    
    public FunctionalTest(string name, DateTime startsAt, DateTime endsAt, string expectedText, string actualText) : base(name, startsAt, endsAt)
    {
        ExpectedText = expectedText;
        ActualText = actualText;
    }
    

    public override bool IsPassed()
    {
        return ExpectedText == ActualText;
    }
}