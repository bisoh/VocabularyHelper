namespace VocabularHelper;

public static class ExamFactory
{
    public static ExamBase GetExamFactory(List<Entry> entries, int numberOfQuestions)
    {
        return new SpanishToEnglishTranslationExam(entries, numberOfQuestions);
    }
}