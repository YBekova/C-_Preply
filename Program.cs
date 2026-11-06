using C__Preply;

// var warrior = new Warrior("First swordmaster");
// var mage = new Mage("First healer");
//
// var warrior2 = new Warrior("Second cleaver");
// var mage2 = new Mage("Second druid");
//
// var characters = new List<Character>
// {
//     warrior, mage, warrior2, mage2
// };
//
// foreach (var charect in characters)
// {
//     charect.Attack();
// }

// int test = 132;
//
// var attackers = new List<IAttacker>();
//  
// attackers.Add(new Warrior("Артём"));
// attackers.Add(new Mage("Анна"));
// attackers.Add(new Tower());
//
// foreach (var attacker in attackers)
// {
//     attacker.Attack();
// }


Warrior warrior = new Warrior("Артём");
IAttacker attacker = warrior;
IDefender defender = warrior;

var test = warrior.Name;
warrior.Attack();
warrior.Defend();

attacker.Attack();
defender.Defend();
