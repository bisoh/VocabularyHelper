public class EnglishToSpanishVerbTranslationExam : ExamBase
{
    public EnglishToSpanishVerbTranslationExam(List<Entry> entries, int numberOfQuestions)
    {
        PickQuestions(entries, numberOfQuestions);
    }

    public override List<ExamQuestion> Test()
    {
        foreach (var examQuestion in ExamQuestions)
        {
            Console.Write($"What is {examQuestion.Question} in spanish? ");
            examQuestion.Answer = Console.ReadLine().Trim();
        }

        CorrectExam();

        return ExamQuestions;
    }

    protected virtual void PickQuestions(List<Entry> entries, int numberOfQuestions)
    {
        HashSet<int> selectedQuestions = new HashSet<int>();
        Random rnd = new Random();

        ExamQuestions = new List<ExamQuestion>();

        for (int i = 0; i < numberOfQuestions; i++)
        {
            var currentRandom = rnd.Next(1, entries.Count);
            while (selectedQuestions.TryGetValue(currentRandom, out _))
            {
                currentRandom = rnd.Next(1, entries.Count);
            }

            selectedQuestions.Add(currentRandom);

            var selectedEntry = entries[currentRandom];
            ExamQuestions.Add(new ExamQuestion()
            {
                Question = selectedEntry.spanish,
                ExpectedAnswer = selectedEntry.english
            });
        }
    }

}