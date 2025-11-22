using System.Globalization;
using ClosedXML.Excel;
using VocabularHelper;

// Console.WriteLine("Enter test size");
// var numberOfQuestions = Console.ReadLine();


var questions = new QuestionLoader().LoadQuestions();

Console.Clear();

var exam = ExamFactory.GetExamFactory(questions, 2);
var answerPaper = exam.Test();

// foreach (var answer in answerPaper)
// {
//     answer.Correct = string.Compare(answer.Answer, answer.ExpectedAnswer, null, CompareOptions.IgnoreCase) == 0;
// }




new ReportCardGenerator().GenerateReportCard(answerPaper);

Console.WriteLine("Done");
Console.ReadKey();