using System.Globalization;

public abstract class ExamBase
{
    public List<ExamQuestion> ExamQuestions { get; protected set; }

    public abstract List<ExamQuestion> Test();

    protected void CorrectExam()
    {
        foreach (var ExamQuestion in ExamQuestions)
        {
            ExamQuestion.Correct = string.Compare(ExamQuestion.Answer, ExamQuestion.ExpectedAnswer, null, CompareOptions.IgnoreCase) == 0;
        }
    }
}