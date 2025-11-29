using ClosedXML.Excel;

public class QuestionLoader
{
    public List<Entry> LoadQuestions(ExamType selectedExam)
    {
        var workbook = new XLWorkbook("../../../vocab.xlsx");

        int worksheet = 0;
        if (selectedExam == ExamType.SpanishToEnglishNounTranslation ||
            selectedExam == ExamType.EnglishToSpanishNounTranslation)
        {
            worksheet = 1;
        }

        if (selectedExam == ExamType.SpanishToEnglishVerbTranslation ||
            selectedExam == ExamType.EnglishToSpanishVerbTranslation)
        {
            worksheet = 2;
        }

        var worksheet1 = workbook.Worksheets.Worksheet(worksheet);
        var rows = worksheet1.Rows();
        //var lastRowUsed = worksheet1.LastRowUsed();

        var entries = new List<Entry>();
        foreach (var row in rows)
        {
            if (row.RowNumber() == 1)
            {
                continue;
            }

            entries.Add(new Entry(row.Cell(1).Value.GetText(), row.Cell(2).Value.GetText()));
        }

        return entries;
    }
}