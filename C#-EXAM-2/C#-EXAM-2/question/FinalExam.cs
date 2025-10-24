using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EXAM_2.question
{
    public class FinalExam : E 
    {


        public FinalExam (int examTime, int numberOfQuestions, Q[] questions)
         : base(examTime, numberOfQuestions, questions)
        {


        }
        public override void ShowExam()
        {
            int totalGrade = 0;
            int userGrade = 0;

            Console.WriteLine(ToString()); // Show exam info (duration, number of questions)

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}:");
                Console.WriteLine(Questions[i]); // Uses the Question’s ToString()

                Console.Write("Enter your answer (ID number): ");
                int userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == Questions[i].CorrectAnswerId)
                {
                    Console.WriteLine("Correct!\n");
                    userGrade += Questions[i].Marks;
                }
                else
                {
                    Console.WriteLine($"Wrong! Correct answer was: {Questions[i].CorrectAnswerId}\n");
                }

                totalGrade += Questions[i].Marks;
            }

            Console.WriteLine($"Your grade: {userGrade} / {totalGrade}");
        }

        
    }
}
