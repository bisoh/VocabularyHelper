public class ExamSelector
{
    public string SelectExam()
    {
        Console.WriteLine("What kind of test do you want to do?");
        Console.WriteLine("1 - Spanish -> English");
        Console.WriteLine("2 - English -> Spanish");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("--> ");
        var selected = Console.ReadLine();
        return selected;
    }
}