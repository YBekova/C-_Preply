namespace C__Preply;

public class NotEnoughManaException : Exception
{
    public NotEnoughManaException(string message) : base(message) { }
}