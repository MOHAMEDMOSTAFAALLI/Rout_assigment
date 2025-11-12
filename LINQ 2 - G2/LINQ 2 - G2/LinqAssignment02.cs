using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Data;

namespace LINQ_2___G2
{
    public class LinqAssignment02
    {

        static List<Product> products;
        static List<Customer> customers;

        static void InitializeSampleData()
        {
            products = new List<Product>
        {
            new Product { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00m, UnitsInStock = 39 },
            new Product { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.00m, UnitsInStock = 17 },
            new Product { ProductID = 3, ProductName = "Aniseed", Category = "Condiments", UnitPrice = 10.00m, UnitsInStock = 0 },
            new Product { ProductID = 4, ProductName = "Tofu", Category = "Produce", UnitPrice = 23.25m, UnitsInStock = 35 },
            new Product { ProductID = 5, ProductName = "Gumbo", Category = "Seafood", UnitPrice = 1200.00m, UnitsInStock = 0 },
            new Product { ProductID = 6, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.00m, UnitsInStock = 31 }
        };

            customers = new List<Customer>
        {
            new Customer
            {
                CustomerID = "ALFKI",
                CompanyName = "Alfreds",
                City = "Berlin",
                Region = "WA",
                Orders = new List<Order>
                {
                    new Order { OrderID = 1, OrderDate = new DateTime(1997, 8, 25), Total = 500 },
                    new Order { OrderID = 2, OrderDate = new DateTime(1997, 9, 15), Total = 600 },
                    new Order { OrderID = 3, OrderDate = new DateTime(1997, 10, 3), Total = 700 }
                }
            },
            new Customer
            {
                CustomerID = "BONAP",
                CompanyName = "Bon app",
                City = "Marseille",
                Region = "WA",
                Orders = new List<Order>
                {
                    new Order { OrderID = 4, OrderDate = new DateTime(1998, 1, 10), Total = 300 }
                }
            }
        };

        }



        static void ElementOperators()
        { 


       

        // Q1: Get FIRST product out of stock
        Console.WriteLine("Q1: First Product Out of Stock\n");

        // First() - throws exception if not found
        // FirstOrDefault() - returns null if not found (safer!)
        var firstOutOfStock = products.FirstOrDefault(p => p.UnitsInStock == 0);

        if (firstOutOfStock != null)
            Console.WriteLine($"  • {firstOutOfStock}");
        else
            Console.WriteLine("  • No products out of stock");

        Console.WriteLine("\n" + new string ('-', 60) + "\n");

        // Q2: First product with Price > 1000, or null
        Console.WriteLine("Q2: First Product with Price > $1000\n");

        var expensiveProduct = products.FirstOrDefault(p => p.UnitPrice > 1000);

        if (expensiveProduct != null)
            Console.WriteLine($"  • {expensiveProduct}");
        else
            Console.WriteLine("  • No product found with price > $1000");

        Console.WriteLine("\n" + new string ('-', 60) + "\n");

        // Q3: SECOND number greater than 5
        Console.WriteLine("Q3: Second Number Greater Than 5\n");

        int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        // Step 1: Filter numbers > 5
        // Step 2: Skip the first one
        // Step 3: Take the next one (which is the second)
        var secondGreater = arr.Where(n => n > 5).Skip(1).FirstOrDefault();

        Console.WriteLine($"  Array: [{string.Join(", ", arr)}]");
        Console.WriteLine($"  Numbers > 5: [{string.Join(", ", arr.Where(n => n > 5))}]");
        Console.WriteLine($"  Second number > 5: {secondGreater}");

        Console.WriteLine("\n" + new string ('═', 60) + "\n");
        }




        static void AggregateOperators()
        {
            Console.WriteLine("        SECTION 2: AGGREGATE OPERATORS                  ");
            

            
            // Q1: COUNT odd numbers
            Console.WriteLine("Q1: Count Odd Numbers\n");

            int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Odd number: number % 2 != 0
            int oddCount = arr.Count(n => n % 2 != 0);

            Console.WriteLine($"  Array: [{string.Join(", ", arr)}]");
            Console.WriteLine($"  Odd numbers: [{string.Join(", ", arr.Where(n => n % 2 != 0))}]");
            Console.WriteLine($"  Count: {oddCount}");

            Console.WriteLine("\n" + new string('-', 60) + "\n");

            // Q2: Customers and their order count
            Console.WriteLine("Q2: Customers and Order Count\n");

            var customerOrderCounts = customers.Select(c => new
            {
                Customer = c.CompanyName,
                OrderCount = c.Orders.Count
            });

            foreach (var item in customerOrderCounts)
            {
                Console.WriteLine($"  • {item.Customer}: {item.OrderCount} orders");
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");

            // Q3: Categories and product count
            Console.WriteLine("Q3: Categories and Product Count\n");

            var categoryProductCounts = products.GroupBy(p => p.Category)
                                               .Select(g => new
                                               {
                                                   Category = g.Key,
                                                   ProductCount = g.Count()
                                               });

            foreach (var item in categoryProductCounts)
            {
                Console.WriteLine($"  • {item.Category}: {item.ProductCount} products");
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");

            // Q4: SUM of all numbers
            Console.WriteLine("Q4: Sum of Numbers\n");

            int sum = arr.Sum();

            Console.WriteLine($"  Array: [{string.Join(", ", arr)}]");
            Console.WriteLine($"  Sum: {sum}");

            Console.WriteLine("\n" + new string('-', 60) + "\n");

            // Q5-8: Dictionary operations (with sample data)
            Console.WriteLine("Q5-8: Dictionary Operations\n");
            Console.WriteLine("Note: Using sample words. Replace with dictionary_english.txt\n");

            // Sample words (in real assignment, read from file)
            string[] words = { "apple", "pie", "banana", "cat", "dog" };

            // Q5: Total characters
            int totalChars = words.Sum(w => w.Length);
            Console.WriteLine($"  Q5 - Total characters: {totalChars}");

            // Q6: Shortest word length
            int shortest = words.Min(w => w.Length);
            Console.WriteLine($"  Q6 - Shortest word length: {shortest}");

            // Q7: Longest word length
            int longest = words.Max(w => w.Length);
            Console.WriteLine($"  Q7 - Longest word length: {longest}");

            // Q8: Average word length
            double average = words.Average(w => w.Length);
            Console.WriteLine($"  Q8 - Average word length: {average:F2}");

            Console.WriteLine("\n" + new string('-', 60) + "\n");

            // Q9: Total units in stock per category
            Console.WriteLine("Q9: Total Units in Stock by Category\n");

            var stockByCategory = products.GroupBy(p => p.Category)
                                         .Select(g => new
                                         {
                                             Category = g.Key,
                                             TotalStock = g.Sum(p => p.UnitsInStock)
                                         });

            foreach (var item in stockByCategory)
            {
                Console.WriteLine($"  • {item.Category}: {item.TotalStock} units");
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");

            // Q10: Cheapest price per category
            Console.WriteLine("Q10: Cheapest Price by Category\n");

            var cheapestByCategory = products.GroupBy(p => p.Category)
                                            .Select(g => new
                                            {
                                                Category = g.Key,
                                                CheapestPrice = g.Min(p => p.UnitPrice)
                                            });

            foreach (var item in cheapestByCategory)
            {
                Console.WriteLine($"  • {item.Category}: ${item.CheapestPrice}");
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");

            // Q11: Products with cheapest price (using let)
            Console.WriteLine("Q11: Cheapest Products by Category (using let)\n");

            var cheapestProducts = from p in products
                                   group p by p.Category into g
                                   let minPrice = g.Min(p => p.UnitPrice)
                                   select new
                                   {
                                       Category = g.Key,
                                       CheapestProducts = g.Where(p => p.UnitPrice == minPrice)
                                   };

            foreach (var category in cheapestProducts)
            {
                Console.WriteLine($"  {category.Category}:");
                foreach (var product in category.CheapestProducts)
                {
                    Console.WriteLine($"    • {product}");
                }
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");

            // Q12: Most expensive price per category
            Console.WriteLine("Q12: Most Expensive Price by Category\n");

            var expensiveByCategory = products.GroupBy(p => p.Category)
                                             .Select(g => new
                                             {
                                                 Category = g.Key,
                                                 MaxPrice = g.Max(p => p.UnitPrice)
                                             });

            foreach (var item in expensiveByCategory)
            {
                Console.WriteLine($"  • {item.Category}: ${item.MaxPrice}");
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");

            // Q13: Products with most expensive price
            Console.WriteLine("Q13: Most Expensive Products by Category\n");

            var expensiveProducts = products.GroupBy(p => p.Category)
                                           .Select(g => new
                                           {
                                               Category = g.Key,
                                               MaxPrice = g.Max(p => p.UnitPrice),
                                               Products = g.Where(p => p.UnitPrice == g.Max(pr => pr.UnitPrice))
                                           });

            foreach (var category in expensiveProducts)
            {
                Console.WriteLine($"  {category.Category}: ${category.MaxPrice}");
                foreach (var product in category.Products)
                {
                    Console.WriteLine($"    • {product.ProductName}");
                }
            }

            Console.WriteLine("\n" + new string('-', 60) + "\n");

            // Q14: Average price per category
            Console.WriteLine("Q14: Average Price by Category\n");

            var avgByCategory = products.GroupBy(p => p.Category)
                                       .Select(g => new
                                       {
                                           Category = g.Key,
                                           AveragePrice = g.Average(p => p.UnitPrice)
                                       });

            foreach (var item in avgByCategory)
            {
                Console.WriteLine($"  • {item.Category}: ${item.AveragePrice:F2}");
            }

            Console.WriteLine("\n" + new string('═', 60) + "\n");




            static void SetOperators()
            {
                Console.WriteLine("              SECTION 3: SET OPERATORS                     ");

                // Q1: UNIQUE category names
                Console.WriteLine("Q1: Unique Category Names\n");

                var uniqueCategories = products.Select(p => p.Category).Distinct();

                foreach (var category in uniqueCategories)
                {
                    Console.WriteLine($"  • {category}");
                }

                Console.WriteLine("\n" + new string('-', 60) + "\n");

                // Q2: Unique first letters from products AND customers
                
                Console.WriteLine("Q2: Unique First Letters (Products + Customers)\n");

                var productFirstLetters = products.Select(p => p.ProductName[0]);
                var customerFirstLetters = customers.Select(c => c.CompanyName[0]);

                var allFirstLetters = productFirstLetters.Concat(customerFirstLetters).Distinct();

                Console.WriteLine($"  Letters: {string.Join(", ", allFirstLetters.OrderBy(c => c))}");

                Console.WriteLine("\n" + new string('-', 60) + "\n");

                // Q3: COMMON first letters (Intersection)
                Console.WriteLine("Q3: Common First Letters\n");

                var commonLetters = productFirstLetters.Intersect(customerFirstLetters);

                Console.WriteLine($"  Common letters: {string.Join(", ", commonLetters)}");

                Console.WriteLine("\n" + new string('-', 60) + "\n");

                // Q4: Product letters NOT in customer letters (Except)
                Console.WriteLine("Q4: Product Letters NOT in Customer Letters\n");

                var productOnly = productFirstLetters.Except(customerFirstLetters);

                Console.WriteLine($"  Product-only letters: {string.Join(", ", productOnly)}");

                Console.WriteLine("\n" + new string('-', 60) + "\n");

                // Q5: Last 3 characters (with duplicates)
                Console.WriteLine("Q5: Last 3 Characters (with duplicates)\n");

                var productLast3 = products.Select(p => p.ProductName.Length >= 3
                    ? p.ProductName.Substring(p.ProductName.Length - 3)
                    : p.ProductName);

                var customerLast3 = customers.Select(c => c.CompanyName.Length >= 3
                    ? c.CompanyName.Substring(c.CompanyName.Length - 3)
                    : c.CompanyName);

                var allLast3 = productLast3.Concat(customerLast3);

                foreach (var last3 in allLast3)
                {
                    Console.WriteLine($"  • {last3}");
                }

                Console.WriteLine("\n" + new string('═', 60) + "\n");
            }


            static void PartitioningOperators()
            {
                Console.WriteLine("         SECTION 4: PARTITIONING OPERATORS                ");

                // Q1: First 3 orders from Washington customers
                Console.WriteLine("Q1: First 3 Orders from Washington\n");

                var washingtonOrders = customers.Where(c => c.Region == "WA")
                                               .SelectMany(c => c.Orders)
                                               .Take(3);

                foreach (var order in washingtonOrders)
                {
                    Console.WriteLine($"  • Order #{order.OrderID} - {order.OrderDate:yyyy-MM-dd}");
                }

                Console.WriteLine("\n" + new string('-', 60) + "\n");

                // Q2: All but first 2 orders from Washington
                
                Console.WriteLine("Q2: Skip First 2 Orders from Washington\n");

                var skippedOrders = customers.Where(c => c.Region == "WA")
                                            .SelectMany(c => c.Orders)
                                            .Skip(2);

                foreach (var order in skippedOrders)
                {
                    Console.WriteLine($"  • Order #{order.OrderID} - {order.OrderDate:yyyy-MM-dd}");
                }

                Console.WriteLine("\n" + new string('-', 60) + "\n");

                // Q3: TakeWhile - until number < its position
                Console.WriteLine("Q3: Elements Until Number < Position\n");

                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

                var takeWhileResult = numbers.TakeWhile((n, index) => n >= index);

                Console.WriteLine($"  Array: [{string.Join(", ", numbers)}]");
                Console.WriteLine($"  Result: [{string.Join(", ", takeWhileResult)}]");
                Console.WriteLine("  (Stops at index 2: value 1 < index 2)");

                Console.WriteLine("\n" + new string('-', 60) + "\n");

                // Q4: SkipWhile - starting from first divisible by 3
                Console.WriteLine("Q4: Elements Starting from First Divisible by 3\n");

                var skipWhileResult = numbers.SkipWhile(n => n % 3 != 0);

                Console.WriteLine($"  Array: [{string.Join(", ", numbers)}]");
                Console.WriteLine($"  Result: [{string.Join(", ", skipWhileResult)}]");
                Console.WriteLine("  (Starts at 3, first number divisible by 3)");

                Console.WriteLine("\n" + new string('-', 60) + "\n");

                // Q5: SkipWhile - starting from first element < position
                Console.WriteLine("Q5: Elements Starting from First < Position\n");

                var skipWhileResult2 = numbers.SkipWhile((n, index) => n >= index);

                Console.WriteLine($"  Array: [{string.Join(", ", numbers)}]");
                Console.WriteLine($"  Result: [{string.Join(", ", skipWhileResult2)}]");
                Console.WriteLine("  (Starts at index 2: value 1 < index 2)");

                Console.WriteLine("\n" + new string('═', 60) + "\n");
            }
            static void Quantifiers()
            {
                Console.WriteLine("           SECTION 5: QUANTIFIERS                     ");

                string[] words = { "believe", "relief", "receipt", "field" };

                // Q1: ANY word contains "ei"
                Console.WriteLine("Q1: Any Word Contains 'ei'\n");

                bool hasEI = words.Any(w => w.Contains("ei"));

                Console.WriteLine($"  Sample words: [{string.Join(", ", words)}]");
                Console.WriteLine($"  Any contain 'ei'? {hasEI}");

                Console.WriteLine("\n" + new string('-', 60) + "\n");

                // Q2: Categories with at least one product out of stock
                Console.WriteLine("Q2: Categories with At Least One Out of Stock\n");

                var categoriesWithOutOfStock = products.GroupBy(p => p.Category)
                                                      .Where(g => g.Any(p => p.UnitsInStock == 0))
                                                      .Select(g => new
                                                      {
                                                          Category = g.Key,
                                                          Products = g.ToList()
                                                      });

                foreach (var category in categoriesWithOutOfStock)
                {
                    Console.WriteLine($"  {category.Category}:");
                    foreach (var product in category.Products)
                    {
                        Console.WriteLine($"    • {product}");
                    }
                }

                Console.WriteLine("\n" + new string('-', 60) + "\n");

                // Q3: Categories where ALL products are in stock
                Console.WriteLine("Q3: Categories with ALL Products in Stock\n");

                var categoriesAllInStock = products.GroupBy(p => p.Category)
                                                  .Where(g => g.All(p => p.UnitsInStock > 0))
                                                  .Select(g => new
                                                  {
                                                      Category = g.Key,
                                                      Products = g.ToList()
                                                  });

                foreach (var category in categoriesAllInStock)
                {
                    Console.WriteLine($"  {category.Category}:");
                    foreach (var product in category.Products)
                    {
                        Console.WriteLine($"    • {product}");
                    }
                }

                Console.WriteLine("\n" + new string('═', 60) + "\n");
            }

            static void GroupingOperators()
            {
                Console.WriteLine("╔═══════════════════════════════════════════════════════════╗");
                Console.WriteLine("║            SECTION 6: GROUPING OPERATORS                  ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════╝\n");

                // ───────────────────────────────────────────────────────────
                // Q1: Group by remainder when divided by 5
                // ───────────────────────────────────────────────────────────
                Console.WriteLine("Q1: Group by Remainder (% 5)\n");

                List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

                var groupedByRemainder = numbers.GroupBy(n => n % 5);

                foreach (var group in groupedByRemainder)
                {
                    Console.WriteLine($"  Numbers with remainder {group.Key}:");
                    Console.WriteLine($"    [{string.Join(", ", group)}]");
                }

                Console.WriteLine("\n" + new string('-', 60) + "\n");

                // ───────────────────────────────────────────────────────────
                // Q2: Group words by first letter
                // ───────────────────────────────────────────────────────────
                Console.WriteLine("Q2: Group Words by First Letter\n");

                string[] words = { "apple", "blueberry", "cherry", "avocado", "banana", "apricot" };

                var groupedByFirstLetter = words.GroupBy(w => w[0]);

                foreach (var group in groupedByFirstLetter)
                {
                    Console.WriteLine($"  Words starting with '{group.Key}':");
                    foreach (var word in group)
                    {
                        Console.WriteLine($"    • {word}");
                    }
                }

                Console.WriteLine("\n" + new string('-', 60) + "\n");

                // ───────────────────────────────────────────────────────────
                // Q3: Group by same characters (anagrams)
                // ───────────────────────────────────────────────────────────
                Console.WriteLine("Q3: Group Words with Same Characters\n");

                string[] arr = { "from", "salt", "earn", "last", "near", "form" };

                var groupedByChars = arr.GroupBy(word => string.Concat(word.OrderBy(c => c)));

                foreach (var group in groupedByChars)
                {
                    Console.WriteLine($"  Group (sorted: {group.Key}):");
                    foreach (var word in group)
                    {
                        Console.WriteLine($"• {{word}} ");



                    }
        }   }   }

    } 
}
