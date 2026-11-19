using C__Preply;

TestReportService service = new TestReportService();

List<TestRun> tests = new List<TestRun>();

FunctionalTest test1 = new FunctionalTest(
    "Test1",
    new DateTime(2026, 12, 12, 8, 0, 0),
    new DateTime(2026, 12, 12, 8, 0, 55),
    "Hello",
    "Hello");
    

FunctionalTest test2 = new FunctionalTest(
    "Test2",
    new DateTime(2026, 12, 12, 9, 0, 0),
    new DateTime(2026, 12, 12, 9, 0, 3),
    "Registered",
    "Error"
);

PerformanceTest test3 = new PerformanceTest(
    "Test3",
    new DateTime(2026, 12, 12, 10, 0, 0),
    new DateTime(2026, 12, 12, 10, 0, 7),
    10
);


PerformanceTest test4 = new PerformanceTest(
    "Test4",
    new DateTime(2026, 12, 12, 11, 0, 0),
    new DateTime(2026, 12, 12, 11, 0, 10),
    10
);


PerformanceTest test5 = new PerformanceTest(
    "Test5",
    new DateTime(2026, 12, 12, 23, 59, 50),
    new DateTime(2026, 12, 13, 0, 0, 10),
    15
);

tests.Add(test1);
tests.Add(test2);
tests.Add(test3);
tests.Add(test4);
tests.Add(test5);

string result = service.GenerateReport(tests);

try
{
    PerformanceTest invalidTest1 = new PerformanceTest(
        "Invalid test",
        new DateTime(2026, 12, 12, 10, 0, 0),
        new DateTime(2026, 12, 12, 10, 0, 5),
        -10
    );
}
catch (ArgumentException ex)
{
    Console.WriteLine("ErrorLog: " + ex.Message);
}

try
{
    FunctionalTest invalidTest2 = new FunctionalTest(
        "",
        new DateTime(2026, 12, 12, 10, 0, 0),
        new DateTime(2026, 12, 12, 10, 0, 5),
        "Success",
        "Success"
    );
}
catch (ArgumentException ex)
{
    Console.WriteLine("ErrorLog: " + ex.Message);
}

try
{
    PerformanceTest invalidTest3 = new PerformanceTest(
        "Invalid time",
        new DateTime(2026, 12, 12, 12, 0, 0),
        new DateTime(2026, 12, 12, 10, 0, 0),
        10
    );
}
catch (ArgumentException ex)
{
    Console.WriteLine("ErrorLog: " + ex.Message);
}

Console.WriteLine();
Console.WriteLine(result);