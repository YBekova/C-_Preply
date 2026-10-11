using C__Preply;
var Library = new Library();
bool libraryMenu = true;

while (libraryMenu)
{
    Console.WriteLine("=== WELCOME TO LIBRARY ===");
    Console.WriteLine("1. Add Book");
    Console.WriteLine("2. Show All Books;");
    Console.WriteLine("3. Find Book By Name");
    Console.WriteLine("4. Book Check Out.");
    Console.WriteLine("5. Book Check In.");
    Console.WriteLine("6. Delete book");
    Console.WriteLine("7. Show the number of books.");
    Console.WriteLine("8. Exit the program.");
    Console.Write("\nSelect an option (1-8): ");
    
    string choice = Console.ReadLine();

    switch (choice)
    {
        case"1":
            Library.AddBook();
            break;
        case "2":
            Library.AllBooks();
            break;
        case "3":
            Library.BookFindByTitle();
            break;
        case "4":
            Library.BookBorrow();
            break;
        case "5":
            Library.BookReturn();
            break;
        case "6":
            Library.DeleteBook();
            break;
        case "7":
            Console.WriteLine($"Total book amount - {Library.bookCount}");
            break;
        case "8":
            Console.WriteLine("Library is closed good bye!");
            break;
        default:
             Console.WriteLine("Error! Choose the number from the menu!");
             Console.WriteLine("\nInvalid option! Please enter 1 - 7");
             break;
    }
}