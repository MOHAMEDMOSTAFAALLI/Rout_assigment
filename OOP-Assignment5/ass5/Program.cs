using ass5.CLASSES;

namespace ass5
{
    public class Program
    {
        static void Main(string[] args)
        {

            Circle c = new Circle ();
            c.DisplayShapeInfo();
            c.Area = 4;
            Console.WriteLine(c.Area);


            Rectangle r = new Rectangle ();
            r.DisplayShapeInfo();
            r.Area = 10;
            Console.WriteLine(r.Area);
            




        }
    }
}
