using C__EXAM_2.question;
namespace C__EXAM_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //A[] answers = {new A(1, "Paris"), new A(2, "London"), new A(3, "Cairo")};

            //MCQQuestion q1 = new MCQQuestion("Q1", "What is the capital of France?", 5, answers, 1);
            //Console.WriteLine(q1);

            //TrueFalseQuestion q2 = new TrueFalseQuestion("Q2", "The Earth is flat.", 2, 2);
            //Console.WriteLine(q2);

            #region EX::
            //A[] answers1 = {
            // new A(1, "Paris"),
            // new A(2, "London"),
            // new A(3, "Cairo")
            //};

            //A[] answers2 = {
            // new A(1, "True"),
            // new A(2, "False")
            //};

            //Q[] questions = {
            // new MCQQuestion("Q1", "What is the capital of France?", 5, answers1, 1),
            // new TrueFalseQuestion("Q2", "The Earth is flat.", 2, 2)
            //};

            //FinalExam finalExam = new FinalExam(60, 2, questions);
            //finalExam.ShowExam(); 
            #endregion




            #region EX::

            //A[] answers1 = {
            // new A(1, "C#"),
            // new A(2, "Python"),
            // new A(3, "Java")
            //};

            //A[] answers2 = {
            // new A(1, "True"),
            // new A(2, "False")
            // };

            //Q[] questions = {
            // new MCQQuestion("Q1", "Which language is used for .NET?", 5, answers1, 1),
            // new TrueFalseQuestion("Q2", "C# is case sensitive.", 2, 1)
            // };

            //// You can switch between FinalExam and PracticalExam easily
            //E exam = new FinalExam(60, 2, questions);
            //// E exam = new PracticalExam(30, 2, questions);

            //Subject subject = new Subject("Programming 1", exam);
            //subject.ShowSubjectExam();

            #endregion


            // name of the class + name of the instence = new name of the calss(the data in the constructor)



            #region

            A[] answers1 = {
                new A(1, "C#"),
                new A(2, "Python"),
                new A(3, "Java")
            };

            A[] answers2 = {
                new A(1, "True"),
                new A(2, "False")
            };

            Q[] questions = {
                new MCQQuestion("Q1", "Which language is used for .NET?", 5, answers1, 1),
                new TrueFalseQuestion("Q2", "C# is case sensitive.", 2, 1)
            };

            E finalExam = new FinalExam(60, 2, questions);
            E practicalExam = new PracticalExam(30, 2, questions);

            Subject subject1 = new Subject("Object Oriented Programming", finalExam);
            Subject subject2 = new Subject("Programming Fundamentals", practicalExam);

            Console.WriteLine("===== SUBJECT 1: FINAL EXAM =====\n");
            subject1.ShowSubjectExam();

            Console.WriteLine("\n===== SUBJECT 2: PRACTICAL EXAM =====\n");
            subject2.ShowSubjectExam();

            Console.WriteLine("\nAll exams finished. Good job!\n");



            #endregion

        }





    }
    

}
    

