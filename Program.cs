using C__Preply;

var room1 = new HotelRoom(1);
var room2 = new HotelRoom(1, 1000);

room1.ShowInfo();
room2.ShowInfo();

room1.Book("Guest",1);

// var room3 = new HotelRoom(3, 10000);
//
// room1.Book("Anna Wise");
// room1.ShowInfo();
// var roomNum = room1.RoomNumber;
// room1.Book("Nikita Wise");
// room1.ShowInfo();
//
