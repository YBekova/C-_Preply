using C__Preply;

TestData<int> intData = new TestData<int>(10000, "Integer");
TestData<string> stringData = new TestData<string>("Hello, String!", "String");
TestData<bool> boolData = new TestData<bool>(false,"Boolean");

Console.WriteLine($"Integer data name: {intData.Name}, and value: {intData.Value}," +
                  $"\nString data name: {stringData.Name}, and value: {stringData.Value}," +
                  $"\nBoolean data name: {boolData.Name}, and value: {boolData.Value}\n");
                  
intData.SetValue(2020);
stringData.SetValue("Hello, New Value!");
boolData.SetValue(true);

Console.WriteLine($"New value integer = {intData.Value}," +
                  $"\nNew value string = {stringData.Value}," +
                  $"\nNew value bool = {boolData.Value}");

try
{
    TestData<string> stringName = new TestData<string>("Hello, String!", "");
}
catch (ArgumentException ex)
{
    Console.WriteLine("\nError log: " + ex.Message);
}

                  
                  
                  