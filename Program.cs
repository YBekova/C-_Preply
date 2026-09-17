using C__Preply;

var riffle = new Weapon("Riffle", 20);
var staff = new Weapon("Staff", 50);

var soldier = new Player("Soldier", 100, riffle);
var mage = new Player("Mage", 60, staff);

soldier.Attack(mage);
mage.ShowInfo();

mage.Attack(soldier);
soldier.ShowInfo();

soldier.Attack(soldier);

soldier.ShowInfo();
