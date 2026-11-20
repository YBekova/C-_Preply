using C__Preply;

var intBox = new Box<int>(10);
var stringBox = new Box<string>("Hello");
var doubleBox = new Box<double>(3.14);
var boolBox = new Box<bool>(true);

var first = new Box<int>(3);
var second = new Box<int>(10);

var test = new Box<List<int>>([1, 2, 3, 4, 5]);

first.Replace(20);
test.Replace([5, 4, 3, 2, 1]);

var testBox = new Box<TestCase>(new TestCase("Test"));

Console.WriteLine(testBox.Value.Name);



