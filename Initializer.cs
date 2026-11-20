namespace C__Preply;

public class Initializer<T> where T : TestRun
{
    public T TestRunInstance { get; set; }
    public Initializer(T testRunInstance)
    {
        TestRunInstance = testRunInstance;
    }
}