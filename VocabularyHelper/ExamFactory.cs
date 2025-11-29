public static class ExamFactory
{
    public static ExamBase GetExamFactory(ExamType selectedExam, List<Entry> entries, int numberOfQuestions)
        => selectedExam switch
        {
            ExamType.SpanishToEnglishNounTranslation => new SpanishToEnglishNounTranslationExam(entries, numberOfQuestions),
            ExamType.EnglishToSpanishNounTranslation => new EnglishToSpanishNounTranslationExam(entries, numberOfQuestions),
            ExamType.SpanishToEnglishVerbTranslation => new EnglishToSpanishVerbTranslationExam(entries, numberOfQuestions),
            ExamType.EnglishToSpanishVerbTranslation => new SpanishToEnglishVerbTranslationExam(entries, numberOfQuestions),
            _ => new SpanishToEnglishNounTranslationExam(entries, numberOfQuestions)
        };
}