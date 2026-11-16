var input = Console.ReadLine();
 
if (DateTime.TryParse(
        input, out var date))
{
    Console.WriteLine(
        date.ToString("dd.MM.yyyy"));
}
else
{
    Console.WriteLine("Неверная дата");
}