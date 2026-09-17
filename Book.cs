namespace C__Preply;

public class Book
{
    public string Title;
    public string Author;
    private bool isBorowed;
    public static int BookCount;

    public Book(string bookTitle, string bookAuthor)
    {
        Title = bookTitle;
        Author = bookAuthor;
        BookCount++;
    }

    public bool Borrow()
    {
        if (!isBorowed)
        {
            
            Console.WriteLine("You can borrow the book.");
            isBorowed = true;
            return true;
            
        }
        else
        {
            
            Console.WriteLine("Book is already borrowed.");
            return false;
        }
    }

    public void ReturnBook()
    {
        isBorowed = false;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Is it borrowed {isBorowed}");
    }
    
    public static void ShowStats()
    {
        Console.WriteLine($"Book Count: {BookCount}");
    }
}