
using ClassLibrary1;
namespace OOP___G2___Assignment_1
{

    //we can write in namespace
    //class
    //enum
    //struct
    //interface
    public class Program
    {
        internal void Main(string[] args)
        {
            //Q.1` part one ther is file created  
            // MyStruct , MyClass , MYENUM , iMyinterface
            #region 

            //Class1 class1 = new Class1()
            //{
            //    id=5,
            //    name="mohamed",
            //    age =25


            //};

            #endregion




            //part two


            //Q.1
            #region 
            //    enum WeekDays
            //    {
            //     Monday,
            //     Tuesday,
            //       Wednesday,
            //     Thursday,
            //      Friday,
            //      Saturday,
            //       Sunday
            //      }

            //static void Main()
            //{
            //Console.WriteLine("Days of the Week:");

            //// Loop through all enum values
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}













            // }
            #endregion


            //Q.2
            #region


            //     struct Person
            //     {
            //       public string Name;
            //       public int Age;
            //      }

            //static void Main()
            //{
            //    // Create array of 3 persons
            //    Person[] people = new Person[3];

            //    // Add data
            //    people[0].Name = "Ali";
            //    people[0].Age = 20;

            //    people[1].Name = "Sara";
            //    people[1].Age = 25;

            //    people[2].Name = "Omar";
            //    people[2].Age = 30;

            //    // Print details
            //    Console.WriteLine("Person details:");
            //    for (int i = 0; i < people.Length; i++)
            //    {
            //        Console.WriteLine("Name: " + people[i].Name + ", Age: " + people[i].Age);
            //    }
            //}

            #endregion






            //Q.3

            #region



            // Create enum for Seasons
            //enum Season
            //{
            //    Spring,
            //    Summer,
            //    Autumn,
            //    Winter
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter): ");
            //        string input = Console.ReadLine();

            //        // Convert input string to enum
            //        Season season;

            //        if (Enum.TryParse(input, true, out season))
            //        {
            //            // Match season and display month range
            //            if (season == Season.Spring)
            //            {
            //                Console.WriteLine("Spring: March to May");
            //            }
            //            else if (season == Season.Summer)
            //            {
            //                Console.WriteLine("Summer: June to August");
            //            }
            //            else if (season == Season.Autumn)
            //            {
            //                Console.WriteLine("Autumn: September to November");
            //            }
            //            else if (season == Season.Winter)
            //            {
            //                Console.WriteLine("Winter: December to February");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid season name! Please try again.");
            //        }



            #endregion




            //Q.4
            #region




            //[Flags]  
            //enum Permissions
            //{
            //    None = 0,
            //    Read = 1,
            //    Write = 2,
            //    Delete = 4,
            //    Execute = 8
            //}



            //        Permissions userPermission = Permissions.None;

            //        userPermission = userPermission | Permissions.Read;
            //        userPermission = userPermission | Permissions.Write;
            //        Console.WriteLine("After adding Read and Write: " + userPermission);

            //        if ((userPermission & Permissions.Read) == Permissions.Read)
            //        {
            //            Console.WriteLine("User has Read permission");
            //        }

            //        if ((userPermission & Permissions.Delete) == Permissions.Delete)
            //        {
            //            Console.WriteLine("User has Delete permission");
            //        }
            //        else
            //        {
            //            Console.WriteLine("User does NOT have Delete permission");
            //        }

            //        userPermission = userPermission & ~Permissions.Write;
            //        Console.WriteLine("After removing Write: " + userPermission);
            #endregion






            //Q.5

            #region


            //     enum Colors
            //{
            //    Red,
            //    Green,
            //    Blue
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        // Step 2: Ask user to enter a color
            //        Console.Write("Enter a color name (Red, Green, Blue): ");
            //        string input = Console.ReadLine();

            //        // Step 3: Try to convert user input to enum
            //        Colors color;

            //        if (Enum.TryParse(input, true, out color))
            //        {
            //            // Step 4: Check if color is a primary color
            //            if (color == Colors.Red || color == Colors.Blue || color == Colors.Green)
            //            {
            //                Console.WriteLine($"{color} is a primary color.");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{color} is not a primary color.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid color name! Please try again.");
            //        }

            #endregion



            //Q.6
            #region

            //struct Point
            //{
            //    public double X; // X coordinate
            //    public double Y; // Y coordinate

            //    public Point(double x, double y)
            //    {
            //        X = x;
            //        Y = y;
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        // Step 3: Take first point input
            //        Console.Write("Enter X for first point: ");
            //        double x1 = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Enter Y for first point: ");
            //        double y1 = Convert.ToDouble(Console.ReadLine());

            //        // Step 4: Take second point input
            //        Console.Write("Enter X for second point: ");
            //        double x2 = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Enter Y for second point: ");
            //        double y2 = Convert.ToDouble(Console.ReadLine());

            //        // Step 5: Create two Point variables
            //        Point p1 = new Point(x1, y1);
            //        Point p2 = new Point(x2, y2);

            //        // Step 6: Calculate the distance between points
            //        double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));

            //        // Step 7: Display the result
            //        Console.WriteLine($"\nThe distance between the two points is: {distance}");
            //    }
            #endregion

            //Q.7
            #region


            //    struct Person
            //    {
            //    public string Name; // Person's name
            //    public int Age;     // Person's age

            //    // Constructor to set Name and Age
            //    public Person(string name, int age)
            //    {
            //        Name = name;
            //        Age = age;
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        // Step 2: Create an array to hold 3 persons
            //        Person[] people = new Person[3];

            //        // Step 3: Take input for 3 persons
            //        for (int i = 0; i < 3; i++)
            //        {
            //            Console.WriteLine($"\nEnter details for person {i + 1}:");

            //            Console.Write("Enter Name: ");
            //            string name = Console.ReadLine();

            //            Console.Write("Enter Age: ");
            //            int age = Convert.ToInt32(Console.ReadLine());

            //            people[i] = new Person(name, age);
            //        }

            //        // Step 4: Find the oldest person
            //        Person oldest = people[0]; // assume first person is oldest at start

            //        for (int i = 1; i < people.Length; i++)
            //        {
            //            if (people[i].Age > oldest.Age)
            //            {
            //                oldest = people[i];
            //            }
            //        }

            //        // Step 5: Display the result
            //        Console.WriteLine($"\nThe oldest person is {oldest.Name}, Age: {oldest.Age}");
            #endregion



        }
    }
}
