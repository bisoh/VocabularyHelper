public record Entry(string spanish, string english/*, string mf*/);


public class ExamQuestion
{
    public string Question { get; set; }
    public string ExpectedAnswer { get; set; }
    public string Answer { get; set; }
    public bool Correct { get; set; }
}