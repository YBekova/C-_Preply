using C__Preply;

var order1 = new Order(1, "Masanchi 76");
var order2 = new Order(2, "Seifullin 499");
var order3 = new Order(3, "Jambyll 98");

var courierAlex = new Courier("Alex");
var courierDima = new Courier("Dima");

courierAlex.Deliver(order1);
order1.ShowInfo();
courierAlex.Deliver(order2);
order2.ShowInfo();
courierDima.Deliver(order1);
order1.ShowInfo();
order3.ShowInfo();