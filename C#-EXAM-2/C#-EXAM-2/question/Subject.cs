using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EXAM_2.question
{


    public class Subject
    {
        public string SubjectName;
        public E Exam; // Or Exam if you renamed it

        public Subject(string name, E exam)
        {
            SubjectName = name;
            Exam = exam;
        }

        public void ShowSubjectExam()
        {
            Console.WriteLine($"Subject: {SubjectName}\n");
            Exam.ShowExam(); // This calls the correct version (Final or Practical)
        }
    }





}


  


 }
