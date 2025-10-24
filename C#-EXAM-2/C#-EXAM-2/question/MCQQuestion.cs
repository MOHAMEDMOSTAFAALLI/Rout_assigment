using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EXAM_2.question
{
    public class MCQQuestion : Q
    {
        public MCQQuestion(string H, string B, int M, A[] answers, int correctId)
         : base(H, B, M, answers, correctId) 
        
        { }

        public override string ToString()
        {
            return base.ToString() + "Choose one correct answer.\n";
        }

    }
}
