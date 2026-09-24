using C__Preply;

var room1 = new HotelRoom(1);
var room2 = new HotelRoom(2, 800);
var room3 = new HotelRoom(3, 10000);

room1.Book("Anna Wise");
room1.ShowInfo();
room1.Book("Nikita Wise");
room1.ShowInfo();

