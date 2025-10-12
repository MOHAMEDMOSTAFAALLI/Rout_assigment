namespace ASSIGNMENT_OOP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q.1
            #region

            //    class Calculator
            //{
            //    // Method to add two integers
            //    public int Add(int a, int b)
            //    {
            //        return a + b;
            //    }

            //    // Method to add three integers
            //    public int Add(int a, int b, int c)
            //    {
            //        return a + b + c;
            //    }

            //    // Method to add two doubles
            //    public double Add(double a, double b)
            //    {
            //        return a + b;
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        Calculator calc = new Calculator();

            //        // Calling Add with two integers
            //        Console.WriteLine("Sum of 5 and 10: " + calc.Add(5, 10));

            //        // Calling Add with three integers
            //        Console.WriteLine("Sum of 1, 2, and 3: " + calc.Add(1, 2, 3));

            //        // Calling Add with two doubles
            //        Console.WriteLine("Sum of 4.5 and 5.5: " + calc.Add(4.5, 5.5));
            //    }
            #endregion


            //Q.2
            #region


            //    class Rectangle
            //{
            //    private int width;
            //    private int height;

            //    // Parameterless constructor
            //    public Rectangle()
            //    {
            //        width = 0;
            //        height = 0;
            //    }

            //    // Constructor that accepts width and height
            //    public Rectangle(int width, int height)
            //    {
            //        this.width = width;
            //        this.height = height;
            //    }

            //    // Constructor that accepts a single integer (square)
            //    public Rectangle(int size)
            //    {
            //        width = size;
            //        height = size;
            //    }

            //    // Method to display rectangle dimensions
            //    public void Display()
            //    {
            //        Console.WriteLine($"Width: {width}, Height: {height}");
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        // Using parameterless constructor
            //        Rectangle rect1 = new Rectangle();
            //        rect1.Display();

            //        // Using constructor with width and height
            //        Rectangle rect2 = new Rectangle(10, 5);
            //        rect2.Display();

            //        // Using constructor with one parameter (square)
            //        Rectangle rect3 = new Rectangle(7);
            //        rect3.Display();
            //    }
            #endregion


            //Q.3

            #region

            //    class ComplexNumber
            //{
            //    private double real;
            //    private double imaginary;

            //    // Constructor to initialize real and imaginary parts
            //    public ComplexNumber(double real, double imaginary)
            //    {
            //        this.real = real;
            //        this.imaginary = imaginary;
            //    }

            //    // Overload + operator to add two complex numbers
            //    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
            //    {
            //        return new ComplexNumber(c1.real + c2.real, c1.imaginary + c2.imaginary);
            //    }

            //    // Overload - operator to subtract two complex numbers
            //    public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
            //    {
            //        return new ComplexNumber(c1.real - c2.real, c1.imaginary - c2.imaginary);
            //    }

            //    // Method to display the complex number in a + bi format
            //    public void Display()
            //    {
            //        Console.WriteLine($"{real} + {imaginary}i");
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        ComplexNumber c1 = new ComplexNumber(3, 4);
            //        ComplexNumber c2 = new ComplexNumber(1, 2);

            //        ComplexNumber sum = c1 + c2;
            //        ComplexNumber difference = c1 - c2;

            //        Console.Write("First Complex Number: ");
            //        c1.Display();

            //        Console.Write("Second Complex Number: ");
            //        c2.Display();

            //        Console.Write("Sum: ");
            //        sum.Display();

            //        Console.Write("Difference: ");
            //        difference.Display();
            //    }
            #endregion



            //Q.4
            #region
            //    class Employee
            //{
            //    // Method in the base class
            //    public virtual void Work()
            //    {
            //        Console.WriteLine("Employee is working");
            //    }
            //}

            //class Manager : Employee
            //{
            //    // Override the Work method in the derived class
            //    public override void Work()
            //    {
            //        // Call the base class method
            //        base.Work();

            //        // Add Manager-specific behavior
            //        Console.WriteLine("Manager is managing");
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        Employee emp = new Employee();
            //        emp.Work();

            //        Console.WriteLine();

            //        Manager mgr = new Manager();
            //        mgr.Work();
            //    }
            #endregion


            //Q.5

            #region

            //    class BaseClass
            //{
            //    // Virtual method in base class
            //    public virtual void DisplayMessage()
            //    {
            //        Console.WriteLine("Message from BaseClass");
            //    }
            //}

            //class DerivedClass1 : BaseClass
            //{
            //    // Override the base class method
            //    public override void DisplayMessage()
            //    {
            //        Console.WriteLine("Message from DerivedClass1 (Overridden)");
            //    }
            //}

            //class DerivedClass2 : BaseClass
            //{
            //    // Hide the base class method
            //    public new void DisplayMessage()
            //    {
            //        Console.WriteLine("Message from DerivedClass2 (Hidden)");
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        // Base class reference and derived class objects
            //        BaseClass baseRef;

            //        Console.WriteLine("Using DerivedClass1 (override):");
            //        baseRef = new DerivedClass1();
            //        baseRef.DisplayMessage(); // Calls DerivedClass1 version (runtime binding)

            //        Console.WriteLine("\nUsing DerivedClass2 (new):");
            //        baseRef = new DerivedClass2();
            //        baseRef.DisplayMessage(); // Calls BaseClass version (compile-time binding)

            //        Console.WriteLine("\nDirectly using DerivedClass2 object:");
            //        DerivedClass2 obj2 = new DerivedClass2();
            //        obj2.DisplayMessage(); // Calls DerivedClass2 version
            //    }
            #endregion


            //Q.6
            #region
            //    class Duration
            //{
            //    public int Hours { get; set; }
            //    public int Minutes { get; set; }
            //    public int Seconds { get; set; }

            //    // ✅ Constructors
            //    public Duration()
            //    {
            //        Hours = Minutes = Seconds = 0;
            //    }

            //    public Duration(int hours, int minutes, int seconds)
            //    {
            //        Hours = hours;
            //        Minutes = minutes;
            //        Seconds = seconds;
            //        Normalize();
            //    }

            //    public Duration(int totalSeconds)
            //    {
            //        Hours = totalSeconds / 3600;
            //        totalSeconds %= 3600;
            //        Minutes = totalSeconds / 60;
            //        Seconds = totalSeconds % 60;
            //        Normalize();
            //    }

            //    // ✅ Normalize to handle values like 75 seconds = 1 minute 15 seconds
            //    private void Normalize()
            //    {
            //        if (Seconds >= 60)
            //        {
            //            Minutes += Seconds / 60;
            //            Seconds %= 60;
            //        }
            //        if (Minutes >= 60)
            //        {
            //            Hours += Minutes / 60;
            //            Minutes %= 60;
            //        }

            //        if (Seconds < 0 || Minutes < 0 || Hours < 0)
            //        {
            //            Hours = Math.Max(0, Hours);
            //            Minutes = Math.Max(0, Minutes);
            //            Seconds = Math.Max(0, Seconds);
            //        }
            //    }

            //    // ✅ Override ToString()
            //    public override string ToString()
            //    {
            //        string result = "";
            //        if (Hours > 0)
            //            result += $"Hours: {Hours}, ";
            //        if (Minutes > 0 || Hours > 0)
            //            result += $"Minutes: {Minutes}, ";
            //        result += $"Seconds: {Seconds}";
            //        return result;
            //    }

            //    // ✅ Override Equals()
            //    public override bool Equals(object obj)
            //    {
            //        if (obj is Duration other)
            //        {
            //            return Hours == other.Hours &&
            //                   Minutes == other.Minutes &&
            //                   Seconds == other.Seconds;
            //        }
            //        return false;
            //    }

            //    // ✅ Override GetHashCode()
            //    public override int GetHashCode()
            //    {
            //        return HashCode.Combine(Hours, Minutes, Seconds);
            //    }

            //    // ✅ Convert total time to seconds
            //    private int ToTotalSeconds()
            //    {
            //        return Hours * 3600 + Minutes * 60 + Seconds;
            //    }

            //    // ✅ Operator Overloading
            //    public static Duration operator +(Duration d1, Duration d2)
            //    {
            //        return new Duration(d1.ToTotalSeconds() + d2.ToTotalSeconds());
            //    }

            //    public static Duration operator +(Duration d, int seconds)
            //    {
            //        return new Duration(d.ToTotalSeconds() + seconds);
            //    }

            //    public static Duration operator +(int seconds, Duration d)
            //    {
            //        return new Duration(d.ToTotalSeconds() + seconds);
            //    }

            //    public static Duration operator -(Duration d1, Duration d2)
            //    {
            //        return new Duration(Math.Abs(d1.ToTotalSeconds() - d2.ToTotalSeconds()));
            //    }

            //    public static Duration operator ++(Duration d)
            //    {
            //        // Increase by one minute
            //        return new Duration(d.ToTotalSeconds() + 60);
            //    }

            //    public static Duration operator --(Duration d)
            //    {
            //        // Decrease by one minute (ensure not negative)
            //        int total = d.ToTotalSeconds() - 60;
            //        if (total < 0) total = 0;
            //        return new Duration(total);
            //    }

            //    // ✅ Comparison Operators
            //    public static bool operator >(Duration d1, Duration d2)
            //    {
            //        return d1.ToTotalSeconds() > d2.ToTotalSeconds();
            //    }

            //    public static bool operator <(Duration d1, Duration d2)
            //    {
            //        return d1.ToTotalSeconds() < d2.ToTotalSeconds();
            //    }

            //    public static bool operator >=(Duration d1, Duration d2)
            //    {
            //        return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
            //    }

            //    public static bool operator <=(Duration d1, Duration d2)
            //    {
            //        return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
            //    }

            //    // ✅ "If (D1)" — convert to bool: true if total seconds > 0
            //    public static implicit operator bool(Duration d)
            //    {
            //        return d.ToTotalSeconds() > 0;
            //    }

            //    // ✅ Cast to DateTime
            //    public static explicit operator DateTime(Duration d)
            //    {
            //        DateTime start = new DateTime(1, 1, 1, 0, 0, 0);
            //        return start.AddSeconds(d.ToTotalSeconds());
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        Duration D1 = new Duration(1, 10, 15);
            //        Console.WriteLine(D1.ToString());
            //        // Output: Hours: 1, Minutes :10, Seconds :15

            //        Duration D2 = new Duration(7800);
            //        Console.WriteLine(D2.ToString());
            //        // Output: Hours: 2, Minutes :10, Seconds :0

            //        Duration D3 = new Duration(666);
            //        Console.WriteLine(D3.ToString());
            //        // Output: Minutes :11, Seconds :6

            //        // Operator tests
            //        D3 = D1 + D2;
            //        Console.WriteLine("\nD3 = D1 + D2 → " + D3);

            //        D3 = D1 + 7800;
            //        Console.WriteLine("D3 = D1 + 7800 → " + D3);

            //        D3 = 666 + D3;
            //        Console.WriteLine("D3 = 666 + D3 → " + D3);

            //        D3 = ++D1;
            //        Console.WriteLine("D3 = ++D1 → " + D3);

            //        D3 = --D2;
            //        Console.WriteLine("D3 = --D2 → " + D3);

            //        D1 = D1 - D2;
            //        Console.WriteLine("D1 = D1 - D2 → " + D1);

            //        if (D1 > D2)
            //            Console.WriteLine("D1 is greater than D2");
            //        else if (D1 <= D2)
            //            Console.WriteLine("D1 is less than or equal to D2");

            //        if (D1)
            //            Console.WriteLine("D1 is not zero duration");

            //        DateTime obj = (DateTime)D1;
            //        Console.WriteLine("DateTime Obj = " + obj.ToLongTimeString());
            //    }
            #endregion









        }
    }
}
