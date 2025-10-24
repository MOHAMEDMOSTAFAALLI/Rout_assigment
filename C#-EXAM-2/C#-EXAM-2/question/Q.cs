using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
 
namespace C__EXAM_2.question
{
    public abstract class Q //questionn
    {
        public string Header;
        public string Body;
        public int Marks;
        public A[] Answers;   // Array of Answer objects
        public int CorrectAnswerId;  // The correct answer ID
        public int result;


        public Q (string H, string B ,int M, A[] answers, int correctId) //H=Header B=body M=Mark
        {
            Header = H;
            Body = B;

            if (M < 0) 
            {
                Console.WriteLine("GG"); //GG=GoodGame
            
            
            }
            else
            {
                Marks = M;
            }

            if (answers == null || answers.Length == 0)
            {
                Console.WriteLine("Question must have at least one answer.");
            }
            else
            {
                Answers = answers;
            }

            if (correctId < 0 || correctId > answers.Length)
            {
                Console.WriteLine("Invalid correct answer ID.");
            }
            else
            {
                CorrectAnswerId = correctId;
            }



        }
        public override string ToString()
        {
            string result = $"Question number is {Header},\nquestion is {Body},\nmark is {Marks}\n";

            for(int i = 0; i < Answers.Length; i++)
            {
                result += Answers[i].ToString() + "\n";
            }
            return result;

        }


    }
}
