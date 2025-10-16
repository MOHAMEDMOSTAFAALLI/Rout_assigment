using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ass5.IInterFaces;

namespace ass5.CLASSES
{
    public class Rectangle : IRectangle
    {
        public float Area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("this is Rectangle");


        }
    }
}
