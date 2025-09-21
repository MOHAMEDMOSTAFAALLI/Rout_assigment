using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q.1
            #region


            //Console.Write("Please enter a number: ");
            //Console.Write("number");
            //string? number = Console.ReadLine();

            #endregion

            // Q.2
            #region


            //string x = "MOMO";
            //int y = int.Parse(x);
            //Exeption  Unhandled
            #endregion

            // Q.3
            #region

            //float x = 1.1f;
            //float y = 2.2f;
            //float sum = x + y;
            // Console.WriteLine(sum);
            #endregion
            //Q.4
            #region

            //string x = "coffe";
            // string s = x.Substring(3);
            // Console.WriteLine(s);
            #endregion

            //Q.5
            #region
            //int a = 10;

            //int b = a;

            //Console.WriteLine($"Before modification: a = {a}, b = {b}");

            //a = 20;

            //Console.WriteLine($"After modifying a: a = {a}, b = {b}");
            #endregion


            //Q.6
            #region


            // int[] numbers1 = { 1, 2, 3 };


            //int[] numbers2 = numbers1;

            //Console.WriteLine("Before modification:");
            //Console.WriteLine("numbers1[0] = " + numbers1[0]);
            //Console.WriteLine("numbers2[0] = " + numbers2[0]);


            //numbers1[0] = 99;

            //Console.WriteLine("\nAfter modifying numbers1:");
            //Console.WriteLine("numbers1[0] = " + numbers1[0]);
            //Console.WriteLine("numbers2[0] = " + numbers2[0]);
            #endregion


            //Q.7
            #region
            //Console.Write("Enter the first string: ");
            //string? first = Console.ReadLine();

            //Console.Write("Enter the second string: ");
            //string? second = Console.ReadLine();
             



             //string combined = first + " " + second;


             //Console.WriteLine("Combined string: " + combined);

            #endregion

            //Q.8
            #region


            //Console.Write("Enter Principal: ");
            // double principal = Convert.ToDouble(Console.ReadLine());


            // Console.Write("Enter Rate : ");
            //  double rate = Convert.ToDouble(Console.ReadLine());


            //Console.Write("Enter Time : ");
            // double time = Convert.ToDouble(Console.ReadLine());



            //double interest = (principal * rate * time) / 100;


            //Console.WriteLine("Simple Interest = " + interest);
            #endregion



            //Q.9
            #region
            // Console.Write("Enter weight (in kg): ");
            //double weight = Convert.ToDouble(Console.ReadLine());


            // Console.Write("Enter height (in meters): ");
            // double height = Convert.ToDouble(Console.ReadLine());


            // double bmi = weight / (height * height);


            //Console.WriteLine("\nYour BMI = " + bmi);
            #endregion


            //Q.10

            #region
            //Console.Write("Enter the temperature in °C: ");
            //int temp = Convert.ToInt32(Console.ReadLine());


            // string result = (temp < 10) ? "Just Cold" : (temp > 30) ? "Just Hot" : "Just Good";




            // Console.WriteLine("Temperature status: " + result);
            #endregion


            //Q.11
            #region



            //Console.Write("Enter day: ");
            //string? day = Console.ReadLine();

            //Console.Write("Enter month: ");
            //string? month = Console.ReadLine();

            //Console.Write("Enter year: ");
            //string? year = Console.ReadLine();


            //Console.WriteLine($"\nToday's date : {day} , {month} , {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} - {month} - {year}");

            #endregion


            //Q.12 choise
            #region
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");


            //the output  is : The event is on 06/14/2024

            #endregion


            //Q.13 choise
            #region

            //int d;
            //d = Convert.ToInt32(!(30 < 20));


            // the output  is :	The code reports an error.
            #endregion

            //Q.14 choise
            #region
            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            // the output  is :		6 1 .


            #endregion

            //Q.15
            #region
            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);


            // the output  is :		7  7 .

            #endregion
        }
    }
}
