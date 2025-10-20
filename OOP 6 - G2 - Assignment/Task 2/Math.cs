using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Task 2: Maths Operations ===");

            Console.WriteLine($"Add(5, 2) = {Maths.Add(5, 2)}");
            Console.WriteLine($"Subtract(5, 2) = {Maths.Subtract(5, 2)}");
            Console.WriteLine($"Multiply(5, 2) = {Maths.Multiply(5, 2)}");

            double divResult = Maths.Divide(5, 2);
            Console.WriteLine($"Divide(5, 2) = {(double.IsNaN(divResult) ? "undefined (division by zero)" : divResult.ToString())}");
        }
    }

    static class Maths
    {
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b) => b != 0 ? a / b : double.NaN;
    }
}
