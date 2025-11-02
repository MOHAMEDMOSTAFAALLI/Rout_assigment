
namespace ADV_02___G2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== OPTIMIZED BUBBLE SORT ===\n");

            // Test Case 1: Unsorted array
            Console.WriteLine("Test 1: Unsorted Array");
            int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
            Console.Write("Before: ");
            PrintArray(arr1);

            OptimizedBubbleSort2(arr1);

            Console.Write("After:  ");
            PrintArray(arr1);
            Console.WriteLine();
        }

        private static void PrintArray(int[] arr1)
        {
            throw new NotImplementedException();
        }

        private static void OptimizedBubbleSort2(int[] arr1)
        {
            throw new NotImplementedException();
        }
    }
}
