namespace C__Preply;

public class Task
{
    public string TaskName { get; set; }
    public TaskStatus Status { get; private set; }

    public Task(string taskName)
    {
        TaskName = taskName;
        Status = TaskStatus.Created;
        Console.WriteLine($"New task is created: {TaskName}");
    }

    public void Start()
    {
        if (Status == TaskStatus.Created)
        {
            Status = TaskStatus.InProgress;
            Console.WriteLine($"{TaskName} status - {Status}");
        }
        else
        {
            
        }
    }

    public void Complete()
    {
        if (Status == TaskStatus.InProgress)
        {
            Status = TaskStatus.Completed;
            Console.WriteLine($"{TaskName} status - {Status}");
        }
    }

    public void Canceled()
    {
        if (Status == TaskStatus.InProgress)
        {
            Status = TaskStatus.Canceled;
            Console.WriteLine($"{TaskName} status - {Status}");
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($" Task - {TaskName}, current status {Status}");
    }
}