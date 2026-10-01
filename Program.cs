using C__Preply;

var membership1 = new GymMembership("Alex", 100);

var membership2 = new GymMembership("Tomiris", 1000);

var membership3 = new GymMembership("Amina", 1);

var membership4 = new GymMembership("Ricky");

var membership5 = new GymMembership("Dana",800);

membership1.Activate(12);
membership1.Activate(2);
membership1.Extend(6);
membership1.ShowInfo();

membership3.Activate();
membership3.ShowInfo();

membership4.Extend(1);
membership4.ShowInfo();

int result = 0;
int result2 = 0;
var isActive = false;

result = 5 + 3 == 8 
    ? 8 
    : 0;

if (isActive)
{
    result = 1;
}
else
{
    result = 0;
}

var status = MembershipStatus.Idle;
var status2 = MembershipStatus.Active;

var intStatus = (int) status;
var status3 = (MembershipStatus) intStatus;
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
Console.WriteLine($"Total orders: {Order.OrderCount}");
