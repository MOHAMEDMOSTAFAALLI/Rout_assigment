using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EXAM_2.question
{
    public class PracticalExam : E
    {
        public PracticalExam(int examTime, int numberOfQuestions, Q[] questions)
          : base(examTime, numberOfQuestions, questions)
        {


        }


        public override void ShowExam()
        {
            int totalGrade = 0;
            int userGrade = 0;

            Console.WriteLine(ToString()); // Print exam info

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}:");
                Console.WriteLine(Questions[i]); // Question details

                Console.Write("Enter your answer (ID number): ");
                int userAnswer;
                while (!int.TryParse(Console.ReadLine(), out userAnswer))
                {
                    Console.Write("Please enter a valid number: ");
                }

                if (userAnswer == Questions[i].CorrectAnswerId)
                {
                    userGrade += Questions[i].Marks;
                }

                totalGrade += Questions[i].Marks;
            }

            // Show results
            Console.WriteLine($"\nYour total grade: {userGrade} / {totalGrade}");
            Console.WriteLine("\nCorrect Answers:");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: Correct answer ID = {Questions[i].CorrectAnswerId}");
            }

            Console.WriteLine("\n===== End of Practical Exam =====");
        }

    }
}
