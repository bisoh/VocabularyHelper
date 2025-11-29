public class ExamSelector
{
    public ExamType SelectExam()
    {
        Console.WriteLine("What kind of test do you want to do?");
        Console.WriteLine("1 - Noun translation: Spanish -> English");
        Console.WriteLine("2 - Noun translation: English -> Spanish");
        Console.WriteLine("3 - Verb translation: Spanish --> English");
        Console.WriteLine("4 - Verb translation: English --> Spanish");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("-->");
        var selected = Console.ReadLine();


        return (ExamType)Convert.ToInt16(selected);
    }
}