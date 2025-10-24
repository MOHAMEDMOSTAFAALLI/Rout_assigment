using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EXAM_2.question
{
    public abstract class E  //Exam
    {
        public int ExamTime;
        public int numberOfQuestions;
        public Q[] Questions;

        public abstract void ShowExam();


        public E(int examTime, int numberOfQuestions, Q[] questions)
        {
            ExamTime = examTime;
            this.numberOfQuestions = numberOfQuestions;
            Questions = questions;
        }


        public override string ToString()
        {
            return $"Exam Duration: {ExamTime} minutes, Number of Questions: {numberOfQuestions}";
        }
        //public static string "ture";
        public void ShowExam()
        {




        }





    }
}
