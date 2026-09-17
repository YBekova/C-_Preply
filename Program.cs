using C__Preply;

var book1 = new Book("Idiot", "Feoder Dostoevsky");

book1.Borrow();
book1.ReturnBook();
book1.Borrow();

var book2 = new Book("Misery", "Stephen King");

book2.Borrow();

var book3 = new Book("Room", "Emma Donoghue");

book3.Borrow();

Book.ShowStats();


 