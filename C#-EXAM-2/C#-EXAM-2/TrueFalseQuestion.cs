using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__EXAM_2.question
{
    public class TrueFalseQuestion : Q
    {
        public TrueFalseQuestion(string H, string B, int M, int correctId)
            : base(H, B, M, new A[] { new A(1, "True"), new A(2, "False") }, correctId)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "\n(True / False Question)\n";
        }


    }
}
