using System.Net;
using System.Reflection.Metadata;
using System.Reflection;
using System;

namespace C__Basics___G1___Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q.1
            #region
            //By Value → A copy of the variable is sent.Changes inside the method do not affect the original.
            //By Reference → The actual variable is sent.Changes inside the method do affect the original.

            //EX

            //static void ByValue(int num)
            //{
            //    num = num + 5; 
            //    Console.WriteLine("Inside ByValue: " + num);
            //}


            //static void ByReference(ref int num)
            //{
            //    num = num + 5;  
            //    Console.WriteLine("Inside PassByReference: " + num);
            //}

            //static void Main()
            //{
            //    int number = 10;

            //    Console.WriteLine("Original number: " + number);

            //    ByValue(number);
            //    Console.WriteLine("After PassByValue: " + number);

            //    ByReference(ref number);
            //    Console.WriteLine("After PassByReference: " + number);

            //}
            #endregion





            //Q.2  // ERROR
            #region
            //Passing Reference Type by Value(default)


            //Inside the method, you can change the object’s data.

            //But if you make the parameter point to a new object, it won’t affect the original outside the method.

            //2.Passing Reference Type by Reference(ref)

            //The method gets the actual reference itself.

            //That means the method can change the object’s data and also make the variable point to a different object.



            //EX

            //// Pass Reference Type by Value
            //static void PassByValue(Person p)
            //{
            //    p.Name = "Ali";   // This will change the original object
            //    p = new Person(); // This creates a new object (only inside method)
            //    p.Name = "Omar";  // Does not affect the original outside
            //}

            //// Pass Reference Type by Reference
            //static void PassByReference(ref Person p)
            //{
            //    p.Name = "Sara";   // Change original object
            //    p = new Person();  // Change the reference itself
            //    p.Name = "Mona";   // Affects original outside too
            //}

            //static void Main()
            //{
            //    Person person = new Person();
            //    person.Name = "Mohamed";

            //    Console.WriteLine("Original Name: " + person.Name);

            //    // Pass by Value
            //    PassByValue(person);
            //    Console.WriteLine("After PassByValue: " + person.Name);

            //    // Pass by Reference
            //    PassByReference(ref person);
            //    Console.WriteLine("After PassByReference: " + person.Name);



            #endregion


            //Q.3
            #region
            //static string Calculate(int a, int b, int c, int d)
            //{
            //    int sum = a + b;     
            //    int sub = c - d;     

            //    return "Summation = " + sum + ", Subtraction = " + sub;
            //}



            //    Console.Write("Enter first number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter second number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter third number: ");
            //    int num3 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter fourth number: ");
            //    int num4 = Convert.ToInt32(Console.ReadLine());

            //    string result = Calculate(num1, num2, num3, num4);
            //    Console.WriteLine(result);




            #endregion



            //Q.4

            #region


            //static int Sum(int number)
            //{
            //    string num= number.ToString(); 
            //    int sum = 0;

            //    for (int i = 0; i < num.Length; i++)
            //    {
            //        int digit = Convert.ToInt32(num[i].ToString());
            //        sum = sum + digit;
            //    }

            //    return sum;
            //}


            //    Console.Write("Enter ypur number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    int result = Sum(num);

            //    Console.WriteLine("The sum of the digits of the number " + num + " is: " + result);


            #endregion






            //Q.5
            #region

            //static bool IsPrime(int number)
            //{
            //    if (number <= 1)   
            //        return false;

            //    for (int i = 2; i < number; i++)
            //    {
            //        if (number % i == 0)  
            //            return false;
            //    }

            //    return true; 
            //}



            //    Console.Write("Enter a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (IsPrime(num))
            //        Console.WriteLine(num + " is a prime number.");
            //    else
            //        Console.WriteLine(num + " is not a prime number.");



            #endregion





            //Q.6


            #region

            //static void MinMaxArray(int[] arr, ref int min, ref int max)
            //{
            //    min = arr[0];
            //    max = arr[0];

            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (arr[i] < min)
            //        {
            //            min = arr[i];  
            //        }

            //        if (arr[i] > max)
            //        {
            //            max = arr[i]; 
            //        }
            //    }
            //}



            //    int[] numbers = { 4, 9, 1, 7, 3 };

            //    int minValue = 0;
            //    int maxValue = 0;

            //    MinMaxArray(numbers, ref minValue, ref maxValue);

            //    Console.WriteLine("Minimum value = " + minValue);
            //    Console.WriteLine("Maximum value = " + maxValue);


            #endregion



            //Q.7

            #region
            //static int Factorial(int number)
            //{
            //    int result = 1;  

            //    for (int i = 1; i <= number; i++)
            //    {
            //        result = result * i;  
            //    }

            //    return result;
            //}


            //    Console.Write("Enter a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    int fact = Factorial(num);

            //    Console.WriteLine("Factorial of " + num + " is: " + fact);



            #endregion



            //Q.8

            #region

            //static string ChangeChar(string text, int position, char newChar)
            //{
            //    char[] letters = text.ToCharArray();  
            //    letters[position] = newChar;         
            //    return new string(letters);           
            //}


            //    string word = "hello";        
            //    Console.WriteLine("Original word: " + word);

            //    string newWord = ChangeChar(word, 1, 'a');  

            //    Console.WriteLine("New word: " + newWord);



            #endregion



            //Q.9

            #region

            //Console.Write("Enter how many numbers you want: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int sum = 0; 

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write("Enter number " + i + ": ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    sum = sum + num; 
            //}

            //Console.WriteLine("The sum of all numbers = " + sum);
























            #endregion



            //Q.10

            #region

            //int[] array1 = { 1, 5, 3 };
            //int[] array2 = { 4, 2, 6 };

            //int[] merged = new int[array1.Length + array2.Length];

            //merged[0] = array1[0];
            //merged[1] = array1[1];
            //merged[2] = array1[2];

            //merged[3] = array2[0];
            //merged[4] = array2[1];
            //merged[5] = array2[2];

            //Array.Sort(merged);

            //Console.WriteLine("Merged array in ascending order:");
            //for (int i = 0; i < merged.Length; i++)
            //{
            //    Console.Write(merged[i] + " ");
            //}

            #endregion


            //Q.11

            #region

            //Console.Write("Enter the number of elements: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[n];


            //Console.WriteLine("Enter the elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("\nFrequency of each element:");
            //for (int i = 0; i < n; i++)
            //{
            //    bool alreadyCounted = false;

            //    for (int k = 0; k < i; k++)
            //    {
            //        if (arr[i] == arr[k])
            //        {
            //            alreadyCounted = true;
            //            break;
            //        }
            //    }

            //    if (!alreadyCounted)
            //    {
            //        int count = 0;
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                count++;
            //            }
            //        }
            //        Console.WriteLine(arr[i] + " occurs " + count + " times");
            //    }



            //}


            ///////////////other wayy///////////



            //// Example array
            //int[] numbers = { 1, 2, 2, 3 };

            //Console.WriteLine("Frequency of each element:");

            //// Check each element
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int count = 0;

            //    // Count how many times numbers[i] appears
            //    for (int j = 0; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] == numbers[j])
            //        {
            //            count++;
            //        }
            //    }

            //    Console.WriteLine(numbers[i] + " occurs " + count + " times");
            //}

            #endregion


            //Q.12

            #region

            //// Example array
            //int[] numbers = { 10, 25, 5, 40, 15 };

            //// Assume first element is both min and max
            //int max = numbers[0];
            //int min = numbers[0];

            //// Check each element
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }

            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}

            //Console.WriteLine("Maximum element = " + max);
            //Console.WriteLine("Minimum element = " + min);

            #endregion



            //Q.13

            #region


            //Console.Write("Enter the number of elements: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int max = arr[0];
            //for (int i = 1; i < n; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}

            //int secondMax = int.MinValue; 
            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] != max && arr[i] > secondMax)
            //    {
            //        secondMax = arr[i];
            //    }
            //}

            //if (secondMax == int.MinValue)
            //    Console.WriteLine("There is no second largest element (all numbers are equal).");
            //else
            //{
            //    Console.WriteLine("The largest element = " + max);
            //    Console.WriteLine("The second largest element = " + secondMax);


            //    


            //}



            //////////////other way///////////////////






            //// Example array
            //int[] numbers = { 10, 25, 5, 40, 15 };

            //// Assume first element is largest and second largest
            //int first = numbers[0];
            //int second = int.MinValue; // very small number

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > first)
            //    {
            //        // Update both first and second
            //        second = first;
            //        first = numbers[i];
            //    }
            //    else if (numbers[i] > second && numbers[i] != first)
            //    {
            //        // Update only second
            //        second = numbers[i];
            //    }
            //}

            //Console.WriteLine("The largest element is: " + first);
            //Console.WriteLine("The second largest element is: " + second);

            #endregion



            //Q.14

            #region
            //Console.Write("Enter size of array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter array elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int maxDistance = -1; 

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j]) 
            //        {
            //            int distance = j - i - 1; 
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}

            //if (maxDistance == -1)
            //    Console.WriteLine("No equal elements found.");
            //else
            //    Console.WriteLine("The longest distance between equal cells is: " + maxDistance);



            #endregion



            //Q.15
            #region

            //Console.Write("Enter a sentence: ");
            //string input = Console.ReadLine();


            //string[] words = input.Split(' ');

            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ", words));


            #endregion





            //Q.16
            #region
            //// Create two 2x2 arrays
            //int[,] firstArray = new int[2, 2];
            //int[,] secondArray = new int[2, 2];

            //// Take input from user for firstArray
            //Console.WriteLine("Enter 4 numbers for the first array:");

            //Console.Write("Enter element [0,0]: ");
            //firstArray[0, 0] = int.Parse(Console.ReadLine());

            //Console.Write("Enter element [0,1]: ");
            //firstArray[0, 1] = int.Parse(Console.ReadLine());

            //Console.Write("Enter element [1,0]: ");
            //firstArray[1, 0] = int.Parse(Console.ReadLine());

            //Console.Write("Enter element [1,1]: ");
            //firstArray[1, 1] = int.Parse(Console.ReadLine());

            //// Copy values to secondArray
            //secondArray[0, 0] = firstArray[0, 0];
            //secondArray[0, 1] = firstArray[0, 1];
            //secondArray[1, 0] = firstArray[1, 0];
            //secondArray[1, 1] = firstArray[1, 1];

            //// Print secondArray
            //Console.WriteLine("\nThe second array is:");
            //Console.WriteLine(secondArray[0, 0] + " " + secondArray[0, 1]);
            //Console.WriteLine(secondArray[1, 0] + " " + secondArray[1, 1]);

            #endregion



            //Q.17

            #region
            //Console.Write("Enter number of elements: ");

            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("\nArray in reverse order:");
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            #endregion
















        }





    }














}   




