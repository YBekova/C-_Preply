namespace C__Preply;

public class Book
{
    public string BookName { get; set; }
    public string BookAuthor { get; set; }
    public BookStatus Status { get; private set; }
    

    public Book(string bookName, string bookAuthor)
    {
        BookName = bookName;
        BookAuthor = bookAuthor;
        Status = BookStatus.Available;
    }

    public bool BookCheckOut()
    {
        if (Status == BookStatus.Available)
        {
            Status = BookStatus.Borrowed;
            return true;
        }

        return false;
    }

    public bool BookCheckIn()
    {
        if (Status == BookStatus.Borrowed)
        {
            Status = BookStatus.Available;
            return true;
        }

        return false;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Book - {BookName}, Book Author {BookAuthor}, Status - {Status}");
    }
    
}