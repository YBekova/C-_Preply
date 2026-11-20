namespace C__Preply;

class Box<T>
{
    public T Value { get; private set; }
 
    public Box(T value)
    {
        Value = value;
    }
    
    public void Replace(T value)
    {
        Value = value;
    }
}
