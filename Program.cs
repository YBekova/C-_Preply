using C__Preply;

var library = new Library();
var libraryMenu = true;

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
    
    var choice = Console.ReadLine();

    switch (choice)
    {
        case"1":
            library.AddBook();
            break;
        case "2":
            library.AllBooks();
            break;
        case "3":
            library.BookFindByTitle();
            break;
        case "4":
            library.BookBorrow();
            break;
        case "5":
            library.BookReturn();
            break;
        case "6":
            library.DeleteBook();
            break;
        case "7":
            Console.WriteLine($"Total book amount - {library.BookCount}");
            break;
        case "8":
            Console.WriteLine("Library is closed good bye!");
            libraryMenu = false;
            break;
        default:
             Console.WriteLine("Error! Choose the number from the menu!");
             Console.WriteLine("\nInvalid option! Please enter 1 - 8");
             break;
    }
}