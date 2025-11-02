using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_02___G2.BubbleSortOptimizationn
{
    internal class BubbleSortOptimization
    {

        public static void RegularBubbleSort(int[] arr)
        {
            int n = arr.Length;

            // Outer loop: number of passes
            for (int i = 0; i < n - 1; i++)
            {
                // Inner loop: compare adjacent elements
                for (int j = 0; j < n - 1; j++)
                {
                    // If current element > next element, swap them
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void OptimizedBubbleSort1(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Optimization: reduce inner loop by 'i'
                // Because last 'i' elements are already sorted!
                for (int j = 0; j < n - 1 - i; j++)  // Notice: n - 1 - i
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void OptimizedBubbleSort2(int[] arr)
        {
            int n = arr.Length;
            bool swapped; // Flag to track if any swap happened

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false; // Reset flag at start of each pass

                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true; // A swap happened!
                    }
                }
            }

        }


       
    }
}
