namespace C__Preply;

public class Car
{
    public string Brand;
    public string Color;
    public int Speed;
    
    public void ShowShortInfo()
    {
        Console.WriteLine($"Brand: {Brand}, color: {Color}");
    }

    public void ShowSpeedInfo()
    {
        Console.WriteLine($"Speed: {Speed}");
    }
    
    public void Accelerate(int speed)
    {
        Speed += speed;
    }

    public void Stop()
    {
        Speed = 0;
    }
    
    public bool IsHighSpeed()
    {
        return Speed > 100;
    }
    
    public int GetCurrentSpeed()
    {
        return Speed;
    }
}