namespace C__Preply;

public class TestData<T>
{
    public T Value { get; private set; }
    public string Name { get; private set; }

    public TestData(T value, string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("The name can't be empty!");
        }
        
        Value = value;
        Name = name;
    }

    public void SetValue(T value)
    {
        Value = value;
    }
}