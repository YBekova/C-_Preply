using C__Preply;

var employeeDeveloper1 = new Developer("Damir", 2000, 8,"C#");
var employeeTester1 = new Tester("Zhanna", 1500, 8,"automation");
var employeeDesigner1 = new Designer("Joker", 1000, 8, "Figma");

void ShowAllInfo()
{
    List<Employee> employees = new List<Employee>();

    employees.Add(employeeDeveloper1);
    employees.Add(employeeTester1);
    employees.Add(employeeDesigner1);

    foreach (Employee employee in employees)
    {
        employee.ShowInfo();
    }
}

ShowAllInfo();

Console.WriteLine("");
employeeDeveloper1.WriteCode();
employeeTester1.TestProgramm();
employeeDesigner1.CreateDesign();

Console.WriteLine("");
employeeDeveloper1.Salary = 5000;

Console.WriteLine("");
ShowAllInfo();

Console.WriteLine("");
employeeDesigner1.Work();
employeeDeveloper1.Work();
employeeTester1.Work();