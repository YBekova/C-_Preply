namespace C__Preply;

public class Library
{
     public int BookCount => _books.Count;
     
     private List<Book> _books = new();

     public void AddBook()
     {
          Console.Write("Add the book Author: ");
          var bookAuthor = Console.ReadLine();
          
          Console.Write("Add the book Title: ");
          var bookName = Console.ReadLine();

          if (string.IsNullOrWhiteSpace(bookName)) Console.WriteLine("You can't add the book without a title");
          else _books.Add(new Book(bookName, bookAuthor));
          
     }

     public void AllBooks()
     {
          var numeration = 1;
          foreach (var book in _books)
          {
               Console.WriteLine($"{numeration}. {book.BookAuthor} - {book.BookName}");
               numeration++;
          }
     }

     public void BookFindByTitle()
     {
          Console.Write("Enter the book title to find: ");
          var bookTitle = Console.ReadLine();

          var found = false;

          foreach (var book in _books)
          {
               if (book.BookName.Contains(bookTitle, StringComparison.InvariantCultureIgnoreCase))
               {
                    found = true;
                    break;
               }
          }
          
          Console.WriteLine(found
          ? "The book title is found."
          : "There's no such book in the library.");
     }

     public void BookBorrow()
     {
          var book = SearchBookByUserInput();

          if (book != null)
          {
               Console.WriteLine(book.BookCheckOut()
                    ? "Book borrowed successfully!"
                    : "This book is already borrowed!");
          }
     }

     public void BookReturn()
     {
          var book = SearchBookByUserInput();

          if (book != null)
          {
               Console.WriteLine(book.BookCheckIn()
                    ? "Book returned successfully!"
                    : "This book is already available!");

          }
     }

     public void DeleteBook()
     {
          var book = SearchBookByUserInput();

          if (book != null)
          {
               _books.Remove(book);
          }
     }

     private Book? SearchBookByUserInput()
     {
          Console.Write("Enter the book author: ");
          var bookAuthor = Console.ReadLine();
          
          Console.Write("Enter the book title: ");
          var bookTitle = Console.ReadLine();

          foreach (var book in _books)
          {
               if (book.BookAuthor == bookAuthor && book.BookName == bookTitle) return book;
          }
          
          Console.WriteLine("The book is not registered in the library system.");

          return null;
     }
}