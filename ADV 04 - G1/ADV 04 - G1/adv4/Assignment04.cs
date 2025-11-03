using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_04___G1.adv4
{
    public class Assignment04
    {
        public static void Question1()
        {
            Console.WriteLine(" Count Frequency ");

            int[] numbers = { 1, 2, 2, 3, 1, 1, 4, 5, 5, 5 };
            Console.WriteLine("Array: [" + string.Join(", ", numbers) + "]\n");

            // Create empty dictionary
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            // Go through each number
            foreach (int num in numbers)
            {
                // Does this number already exist in dictionary?
                if (frequency.ContainsKey(num))
                {
                    // Yes! Increase its count
                    frequency[num] = frequency[num] + 1;
                }
                else
                {
                    // No! Add it with count = 1
                    frequency[num] = 1;
                }
            }

            // Print results
            Console.WriteLine("Number | How Many Times");
            Console.WriteLine("-------|---------------");
            foreach (var item in frequency)
            {
                Console.WriteLine($"  {item.Key}    |      {item.Value}");
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }
        // ========================================
        // QUESTION 2: Find Key with Highest Value
        // ========================================

        public static void Question2()
        {
            Console.WriteLine(" Find Key with Highest Value ");

            // Create a dictionary with fruit names and prices
            Dictionary<string, int> prices = new Dictionary<string, int>
        {
            {"apple", 5},
            {"banana", 10},
            {"orange", 3},
            {"grape", 15},
            {"mango", 8}
        };

            // Print the dictionary
            Console.WriteLine("Dictionary:");
            foreach (var item in prices)
            {
                Console.WriteLine($"  {item.Key} = {item.Value}");
            }

            // Find the key with highest value
            string maxKey = "";
            int maxValue = int.MinValue; // Start with smallest possible number

            foreach (var item in prices)
            {
                if (item.Value > maxValue)
                {
                    maxValue = item.Value;
                    maxKey = item.Key;
                }
            }

            Console.WriteLine($"\nHighest value: {maxKey} = {maxValue}");

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }
        // ========================================

        // QUESTION 3: Find All Keys for a Target Value
        // ========================================


        public static void Question3()
        {
            Console.WriteLine("=== QUESTION 3: Find Keys with Target Value ===\n");

            Dictionary<string, string> data = new Dictionary<string, string>
        {
            {"key1", "apple"},
            {"key2", "banana"},
            {"key3", "apple"},
            {"key4", "orange"},
            {"key5", "apple"}
        };

            Console.WriteLine("Dictionary:");
            foreach (var item in data)
            {
                Console.WriteLine($"  {item.Key} → {item.Value}");
            }

            string targetValue = "apple";
            Console.WriteLine($"\nSearching for value: \"{targetValue}\"\n");

            // List to store all keys that match
            List<string> matchingKeys = new List<string>();

            foreach (var item in data)
            {
                if (item.Value == targetValue)
                {
                    matchingKeys.Add(item.Key);
                }
            }

            // Print results
            if (matchingKeys.Count > 0)
            {
                Console.WriteLine("Keys found:");
                foreach (string key in matchingKeys)
                {
                    Console.WriteLine($"  {key}");
                }
            }
            else
            {
                Console.WriteLine("Key not found");
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }

        // ========================================

        // QUESTION 4: Group Anagrams
        // ========================================


        public static void Question4()
        {
            Console.WriteLine("=== QUESTION 4: Group Anagrams ===\n");

            string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
            Console.WriteLine("Words: [" + string.Join(", ", words) + "]\n");

            // Dictionary: sorted letters → list of words
            Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

            foreach (string word in words)
            {
                // Sort the letters: "eat" → "aet"
                char[] chars = word.ToCharArray();
                Array.Sort(chars);
                string sortedWord = new string(chars);

                // Add to dictionary
                if (!groups.ContainsKey(sortedWord))
                {
                    groups[sortedWord] = new List<string>();
                }
                groups[sortedWord].Add(word);
            }

            // Print groups
            Console.WriteLine("Anagram Groups:");
            int groupNum = 1;
            foreach (var group in groups)
            {
                Console.WriteLine($"Group {groupNum}: [{string.Join(", ", group.Value)}]");
                groupNum++;
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }


        // ========================================
        // QUESTION 5: Check for Duplicates
        // ========================================
        

        public static void Question5()
        {
            Console.WriteLine("=== QUESTION 5: Check for Duplicates ===\n");

            int[] numbers = { 1, 2, 3, 4, 5, 2, 6 };
            Console.WriteLine("Array: [" + string.Join(", ", numbers) + "]\n");

            HashSet<int> seen = new HashSet<int>();
            bool hasDuplicates = false;

            foreach (int num in numbers)
            {
                // HashSet.Add returns false if element already exists
                if (!seen.Add(num))
                {
                    Console.WriteLine($"Duplicate found: {num}");
                    hasDuplicates = true;
                }
            }

            if (!hasDuplicates)
            {
                Console.WriteLine("No duplicates found!");
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }

        // ========================================
        // QUESTION 6: Student Directory (SortedDictionary)
        // ========================================
      

        public static void Question6()
        {
            Console.WriteLine(" Student Directory (SortedDictionary) ");

            // SortedDictionary keeps keys in sorted order!
            SortedDictionary<int, string> students = new SortedDictionary<int, string>();

            // Add students
            students.Add(103, "Alice");
            students.Add(101, "Bob");
            students.Add(105, "Charlie");
            students.Add(102, "Diana");

            Console.WriteLine("After adding (automatically sorted by ID):");
            foreach (var student in students)
            {
                Console.WriteLine($"  ID {student.Key}: {student.Value}");
            }

            // Retrieve a student
            Console.WriteLine("\nRetrieving student with ID 103:");
            if (students.ContainsKey(103))
            {
                Console.WriteLine($"  {students[103]}");
            }

            // Remove a student
            students.Remove(102);
            Console.WriteLine("\nAfter removing ID 102:");
            foreach (var student in students)
            {
                Console.WriteLine($"  ID {student.Key}: {student.Value}");
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }

        // ========================================
        // QUESTION 7: Employee Directory (SortedList)
        // ========================================

        public static void Question7()
        {
            Console.WriteLine(" Employee Directory (SortedList) ");

            SortedList<int, string> employees = new SortedList<int, string>();

            employees.Add(205, "John Smith");
            employees.Add(201, "Mary Johnson");
            employees.Add(203, "Bob Williams");
            employees.Add(210, "Sarah Davis");

            Console.WriteLine("Employees (sorted by ID):");
            foreach (var emp in employees)
            {
                Console.WriteLine($"  ID {emp.Key}: {emp.Value}");
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }
        // ========================================
        // QUESTION 8: Find Missing Numbers
        // ========================================
        

        public static void Question8()
        {
            Console.WriteLine("=== QUESTION 8: Find Missing Numbers ===\n");

            int[] numbers = { 1, 2, 4, 6, 7, 9, 10 };
            int N = 10; // Should have numbers from 1 to 10

            Console.WriteLine("Array: [" + string.Join(", ", numbers) + "]");
            Console.WriteLine($"Should contain: 1 to {N}\n");

            HashSet<int> present = new HashSet<int>(numbers);

            Console.WriteLine("Missing numbers:");
            for (int i = 1; i <= N; i++)
            {
                if (!present.Contains(i))
                {
                    Console.WriteLine($"  {i}");
                }
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }
        // ========================================
        // QUESTION 9: Remove Duplicates with HashSet
        // ========================================

        public static void Question9()
        {
            Console.WriteLine("=== QUESTION 9: Get Unique Values (HashSet) ===\n");

            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5, 1, 6, 6, 6 };
            Console.WriteLine("Original list: [" + string.Join(", ", numbers) + "]");

            // HashSet automatically removes duplicates!
            HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

            Console.WriteLine("Unique values:  [" + string.Join(", ", uniqueNumbers) + "]");

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }


        // ========================================
        // QUESTION 10: Swap Keys and Values
        // ========================================

        public static void Question10()
        {
            Console.WriteLine("=== QUESTION 10: Swap Keys and Values ===\n");

            Dictionary<string, int> original = new Dictionary<string, int>
        {
            {"apple", 1},
            {"banana", 2},
            {"orange", 3}
        };

            Console.WriteLine("Original:");
            foreach (var item in original)
            {
                Console.WriteLine($"  {item.Key} → {item.Value}");
            }

            // Swap: values become keys, keys become values
            Dictionary<int, string> swapped = new Dictionary<int, string>();

            foreach (var item in original)
            {
                swapped[item.Value] = item.Key;
            }

            Console.WriteLine("\nSwapped:");
            foreach (var item in swapped)
            {
                Console.WriteLine($"  {item.Key} → {item.Value}");
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }


        // ========================================
        // QUESTION 11: Union of Two Sets
        // ========================================

        public static void Question11()
        {
            Console.WriteLine("=== QUESTION 11: Union of Two Sets ===\n");

            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7, 8 };

            Console.WriteLine("Set 1: [" + string.Join(", ", set1) + "]");
            Console.WriteLine("Set 2: [" + string.Join(", ", set2) + "]");

            // Union = all unique elements from both sets
            HashSet<int> union = new HashSet<int>(set1);
            union.UnionWith(set2);

            Console.WriteLine("\nUnion: [" + string.Join(", ", union) + "]");

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }

        // ========================================
        // QUESTION 12: Count Keys Starting with Character
        // ========================================

        public static void Question12()
        {
            Console.WriteLine("=== QUESTION 12: Count Keys Starting with Character ===\n");

            Dictionary<string, int> data = new Dictionary<string, int>
        {
            {"apple", 1},
            {"animal", 2},
            {"airport", 3},
            {"banana", 4},
            {"avocado", 5}
        };

            Console.WriteLine("Dictionary:");
            foreach (var item in data)
            {
                Console.WriteLine($"  {item.Key} → {item.Value}");
            }

            char targetChar = 'a';
            Console.WriteLine($"\nSearching for keys starting with '{targetChar}':\n");

            int count = 0;
            foreach (var item in data)
            {
                if (item.Key.StartsWith(targetChar.ToString()))
                {
                    Console.WriteLine($"  Found: {item.Key}");
                    count++;
                }
            }

            Console.WriteLine($"\nTotal count: {count}");

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }
        // ========================================
        // QUESTION 13: Find Elements Greater Than Target
        // ========================================

        public static void Question13()
        {
            Console.WriteLine("=== QUESTION 13: Elements Greater Than Target ===\n");

            SortedSet<int> sortedSet = new SortedSet<int> { 5, 10, 15, 20, 25, 30 };
            Console.WriteLine("SortedSet: [" + string.Join(", ", sortedSet) + "]");

            int target = 15;
            Console.WriteLine($"Target: {target}\n");

            List<int> greaterThan = new List<int>();

            foreach (int num in sortedSet)
            {
                if (num > target)
                {
                    greaterThan.Add(num);
                }
            }

            Console.WriteLine("Elements greater than " + target + ":");
            Console.WriteLine("[" + string.Join(", ", greaterThan) + "]");

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }

        // ========================================
        // QUESTION 14: Find Keys with Even Values
        // ========================================

        public static void Question14()
        {
            Console.WriteLine("=== QUESTION 14: Keys with Even Values ===\n");

            SortedList<string, int> data = new SortedList<string, int>
        {
            {"apple", 4},
            {"banana", 7},
            {"cherry", 10},
            {"date", 3},
            {"elderberry", 8}
        };

            Console.WriteLine("SortedList:");
            foreach (var item in data)
            {
                Console.WriteLine($"  {item.Key} → {item.Value}");
            }

            Console.WriteLine("\nKeys with EVEN values:");
            foreach (var item in data)
            {
                if (item.Value % 2 == 0) // Even number: divisible by 2
                {
                    Console.WriteLine($"  {item.Key} (value = {item.Value})");
                }
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");
        }


    }
}
