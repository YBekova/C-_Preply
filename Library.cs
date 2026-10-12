namespace C__Preply;

public class Library
{
     List<Book> books = new List<Book>();

     public int bookCount => books.Count;

     public void AddBook()
     {
          Console.Write("Add the book Author: ");
          var bookAuthor = Console.ReadLine();
          
          Console.Write("Add the book Title: ");
          var bookName = Console.ReadLine();

          if (String.IsNullOrWhiteSpace(bookName)) Console.WriteLine("You can't add the book without a title");
          else books.Add(new Book(bookName, bookAuthor));
          
     }

     public void AllBooks()
     {
          var numeration = 1;
          foreach (Book book in books)
          {
               Console.WriteLine($"{numeration}. {book.BookAuthor} - {book.BookName}");
               numeration++;
          }
     }

     public void BookFindByTitle()
     {
          Console.Write("Enter the book title to find: ");
          var bookTitle = Console.ReadLine();

          bool found = false;

          foreach (Book book in books)
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
          Console.Write("Enter the book author: ");
          var bookAuthor = Console.ReadLine();
          
          Console.Write("Enter the book title: ");
          var bookTitle = Console.ReadLine();

          foreach (Book book in books)
          {
               if (book.BookAuthor == bookAuthor && book.BookName == bookTitle)
               {
                    Console.WriteLine(book.BookCheckOut()
                         ? "Book borrowed successfully!"
                         : "This book is already borrowed!");
                    return;
               }
               
          }
          Console.WriteLine("The book is n ot found!");
     }

     public void BookReturn()
     {
          Console.Write("Enter the book author: ");
          var bookAuthor = Console.ReadLine();
          
          Console.Write("Enter the book title: ");
          var bookTitle = Console.ReadLine();

          foreach (Book book in books)
          {
               if (book.BookAuthor == bookAuthor && book.BookName == bookTitle)
               {
                    Console.WriteLine(book.BookCheckIn()
                         ? "Book returned successfully!"
                         : "This book is already available!");

                    return;
               }
          }
          Console.WriteLine("The book is not registered in the library system.");
     }

     public void DeleteBook()
     {
          
          Console.Write("Enter the book title: ");
          var bookTitle = Console.ReadLine();

          Console.Write("Enter the book author: ");
          var bookAuthor = Console.ReadLine();

          foreach (Book book in books)
          {
               if (book.BookAuthor == bookAuthor && book.BookName == bookTitle)
               {
                    books.Remove(book);
                    Console.WriteLine("Book is deleted from the library system successfully.");
                    return;
               }
          }
          Console.WriteLine("The book is not registered in the library system.");
     }
     
}