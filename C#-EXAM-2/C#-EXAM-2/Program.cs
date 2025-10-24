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

            TrueFalseQuestion q2 = new TrueFalseQuestion("Q2", "The Earth is flat.", 2, 2);
            Console.WriteLine(q2);




            // name of the class + name of the instence = new name of the calss(the data in the constructor)



        }
    }
}
