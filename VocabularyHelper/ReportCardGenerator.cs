namespace VocabularHelper;

public class ReportCardGenerator
{
    public void GenerateReportCard(List<ExamQuestion> answerPaper)
    {
        int correct = 0;
        foreach (var answer in answerPaper)
        {
            if (answer.Correct)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{answer.Question} is {answer.Answer}");
                Console.ForegroundColor = ConsoleColor.White;
                correct++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{answer.Question} is {answer.ExpectedAnswer}, not {answer.Answer}");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        var percent = ((decimal)correct / answerPaper.Count) * 100;
        Console.WriteLine($"You got {correct}/{answerPaper.Count}. That is {percent:N}%");
    }
}