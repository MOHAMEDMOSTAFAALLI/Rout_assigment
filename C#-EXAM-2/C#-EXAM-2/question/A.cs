using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EXAM_2.question
{
    public class A
    {
        public int AnswerId;
        public string AnswerText;


        public A(int number, string text)
        {
            if (number < 0 || number > 100)
            {
                Console.WriteLine("Invalid ID. It must be between 0 and 100.");
                AnswerId = 0;
            }
            else
            {
                AnswerId = number;
            }

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Answer text cannot be empty.");
                AnswerText = "Invalid Answer";
            }
            else
            {
                AnswerText = text;
            }


        }

        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        }




    }
}