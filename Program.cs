using C__Preply;

var membership1 = new GymMembership("Alex");

var membership2 = new GymMembership("Tomiris", 1000);

var membership3 = new GymMembership("Amina", 0);

var membership4 = new GymMembership("Ricky");

var membership5 = new GymMembership("Dana",800);

membership1.Activate(12);
membership1.Activate(2);
membership1.Extend(6);
membership1.ShowInfo();

membership3.Activate();
membership3.ShowInfo();