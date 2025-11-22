public static class ExamFactory
{
    public static ExamBase GetExamFactory(string selectedExam, List<Entry> entries, int numberOfQuestions)
        => selectedExam switch
        {
            "1" => new SpanishToEnglishTranslationExam(entries, numberOfQuestions),
            "2" => new EnglishToSpanishTranslationExam(entries, numberOfQuestions),
            _ => new SpanishToEnglishTranslationExam(entries, numberOfQuestions)
        };
}