using ClosedXML.Excel;

public class QuestionLoader
{
    public List<Entry> LoadQuestions()
    {
        var workbook = new XLWorkbook("../../../vocab.xlsx");

        var worksheet1 = workbook.Worksheets.Worksheet(1);
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