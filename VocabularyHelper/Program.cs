

// Console.WriteLine("Enter test size");2
// var numberOfQuestions = Console.ReadLine();


var selectedExam = new ExamSelector().SelectExam();
var questions = new QuestionLoader().LoadQuestions();

Console.Clear();

var exam = ExamFactory.GetExamFactory(selectedExam, questions, 2);
var answerPaper = exam.Test();





new ReportCardGenerator().GenerateReportCard(answerPaper);

Console.WriteLine("Done");
Console.ReadKey();