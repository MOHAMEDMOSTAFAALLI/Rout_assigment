namespace OOP___G2___Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Q.1

            #region

            //    struct Person
            //{
            //    public string Name;
            //    public int Age;
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        // Create an array of 3 Person objects
            //        Person[] people = new Person[3];

            //        // Get details from the user
            //        for (int i = 0; i < people.Length; i++)
            //        {
            //            Console.WriteLine($"Enter details for person {i + 1}:");

            //            Console.Write("Enter name: ");
            //            people[i].Name = Console.ReadLine();

            //            Console.Write("Enter age: ");
            //            people[i].Age = int.Parse(Console.ReadLine());
            //        }

            //        // Display the details of all persons
            //        Console.WriteLine("\nDetails of all persons:");
            //        for (int i = 0; i < people.Length; i++)
            //        {
            //            Console.WriteLine($"Name: {people[i].Name}, Age: {people[i].Age}");
            //        }
            #endregion



            //Q.2

            #region
            //    struct Point
            //{
            //    public double X;
            //    public double Y;
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        Point p1, p2;

            //        // Input first point
            //        Console.WriteLine("Enter coordinates for the first point:");
            //        Console.Write("X1: ");
            //        p1.X = double.Parse(Console.ReadLine());
            //        Console.Write("Y1: ");
            //        p1.Y = double.Parse(Console.ReadLine());

            //        // Input second point
            //        Console.WriteLine("\nEnter coordinates for the second point:");
            //        Console.Write("X2: ");
            //        p2.X = double.Parse(Console.ReadLine());
            //        Console.Write("Y2: ");
            //        p2.Y = double.Parse(Console.ReadLine());

            //        // Calculate distance
            //        double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));

            //        // Display result
            //        Console.WriteLine($"\nThe distance between the two points is: {distance}");
            //    }

            #endregion




            //Q.3
            #region

            //    struct Person
            //{
            //    public string Name;
            //    public int Age;
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        Person[] people = new Person[3];

            //        // Input details for 3 persons
            //        for (int i = 0; i < people.Length; i++)
            //        {
            //            Console.WriteLine($"Enter details for person {i + 1}:");

            //            Console.Write("Enter name: ");
            //            people[i].Name = Console.ReadLine();

            //            Console.Write("Enter age: ");
            //            people[i].Age = int.Parse(Console.ReadLine());

            //            Console.WriteLine();
            //        }

            //        // Find the oldest person
            //        Person oldest = people[0];
            //        for (int i = 1; i < people.Length; i++)
            //        {
            //            if (people[i].Age > oldest.Age)
            //            {
            //                oldest = people[i];
            //            }
            //        }

            //        // Display the oldest person's details
            //        Console.WriteLine($"The oldest person is {oldest.Name}, Age: {oldest.Age}");
            //    }
            #endregion

            //Q.4


            #region

            //    struct Rectangle
            //{
            //    // Private fields
            //    private double width;
            //    private double height;

            //    // Public property for Width
            //    public double Width
            //    {
            //        get { return width; }
            //        set
            //        {
            //            if (value < 0)
            //            {
            //                Console.WriteLine("Error: Width cannot be negative!");
            //            }
            //            else
            //            {
            //                width = value;
            //            }
            //        }
            //    }

            //    // Public property for Height
            //    public double Height
            //    {
            //        get { return height; }
            //        set
            //        {
            //            if (value < 0)
            //            {
            //                Console.WriteLine("Error: Height cannot be negative!");
            //            }
            //            else
            //            {
            //                height = value;
            //            }
            //        }
            //    }

            //    // Read-only property for Area
            //    public double Area
            //    {
            //        get { return width * height; }
            //    }

            //    // Method to display rectangle info
            //    public void DisplayInfo()
            //    {
            //        Console.WriteLine($"Width: {width}");
            //        Console.WriteLine($"Height: {height}");
            //        Console.WriteLine($"Area: {Area}");
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        // Create an instance of Rectangle
            //        Rectangle rect = new Rectangle();

            //        // Set values using properties
            //        Console.Write("Enter width: ");
            //        rect.Width = double.Parse(Console.ReadLine());

            //        Console.Write("Enter height: ");
            //        rect.Height = double.Parse(Console.ReadLine());

            //        Console.WriteLine();

            //        // Display rectangle details
            //        rect.DisplayInfo();

            //        // Test negative values (optional)
            //        Console.WriteLine("\nTrying to set a negative width...");
            //        rect.Width = -5; // This should trigger an error message
            //    }
            #endregion
















        }
    }
}
