using ADV_G2_Assignment1.range;

namespace ADV_G2_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                Console.WriteLine("=== Range<T> Generic Class - Examples ===\n");

                // Example 1: Integer Range
                Console.WriteLine("1. Integer Range:");
                Range<int> intRange = new Range<int>(10, 50);
                Console.WriteLine($"   {intRange}");
                Console.WriteLine($"   Length: {intRange.Length()}");
                Console.WriteLine($"   Is 25 in range? {intRange.IsInRange(25)}");
                Console.WriteLine($"   Is 5 in range? {intRange.IsInRange(5)}");
                Console.WriteLine();

                // Example 2: Double Range
                Console.WriteLine("2. Double Range:");
                Range<double> doubleRange = new Range<double>(1.5, 9.8);
                Console.WriteLine($"   {doubleRange}");
                Console.WriteLine($"   Length: {doubleRange.Length()}");
                Console.WriteLine($"   Is 5.5 in range? {doubleRange.IsInRange(5.5)}");
                Console.WriteLine();

                // Example 3: Character Range
                Console.WriteLine("3. Character Range:");
                Range<char> charRange = new Range<char>('A', 'Z');
                Console.WriteLine($"   {charRange}");
                Console.WriteLine($"   Length: {charRange.Length()}");
                Console.WriteLine($"   Is 'M' in range? {charRange.IsInRange('M')}");
                Console.WriteLine();

                // Example 4: DateTime Range
                Console.WriteLine("4. DateTime Range:");
                Range<DateTime> dateRange = new Range<DateTime>(
                    new DateTime(2024, 1, 1),
                    new DateTime(2024, 12, 31)
                );
                Console.WriteLine($"   {dateRange}");
                Console.WriteLine($"   Length (days): {dateRange.Length()}");
                Console.WriteLine($"   Is June 15, 2024 in range? {dateRange.IsInRange(new DateTime(2024, 6, 15))}");
                Console.WriteLine();

                // Example 5: Error Handling
                Console.WriteLine("5. Error Handling:");
                try
                {
                    Range<int> invalidRange = new Range<int>(100, 50);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"   Error caught: {ex.Message}");
                }

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();


            }
        }
    }
}
    
    

