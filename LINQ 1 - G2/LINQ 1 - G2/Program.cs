namespace LINQ_1___G2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //Console.WriteLine("Q1: Products Out of Stock\n");

            //// Method 1: Query Syntax
            //var outOfStock1 = from p in products
            //                  where p.UnitsInStock == 0
            //                  select p;

            //// Method 2: Method Syntax (more common)
            //var outOfStock2 = products.Where(p => p.UnitsInStock == 0);

            //foreach (var product in outOfStock2)
            //{
            //    Console.WriteLine($"  • {product}");
            //}

            //Console.WriteLine("\n" + new string('-', 60) + "\n");
            #endregion




            #region Q2

            //Console.WriteLine("Q2: Products in Stock and Price > $3.00\n");

            //var inStockExpensive = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

            //foreach (var product in inStockExpensive)
            //{
            //    Console.WriteLine($"  • {product}");
            //}

            //Console.WriteLine("\n" + new string('-', 60) + "\n");



            #endregion





            #region Q3

            //Console.WriteLine("Q3: Digits where name length < value\n");

            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //// Example: "six" (length=3) has value 6, so 3 < 6 ✓
            //var shortNames = digits.Where((name, index) => name.Length < index);

            //foreach (var digit in shortNames)
            //{
            //    int value = Array.IndexOf(digits, digit);
            //    Console.WriteLine($"  • \"{digit}\" (length={digit.Length}) < value={value}");
            //}

            //Console.WriteLine("\n" + new string('═', 60) + "\n");


            #endregion






            #region Q4
            //Console.WriteLine("Q1: Sort by Product Name\n");

            //var sortedByName = products.OrderBy(p => p.ProductName);

            //foreach (var product in sortedByName)
            //{
            //    Console.WriteLine($"  • {product.ProductName}");
            //}

            //Console.WriteLine("\n" + new string('-', 60) + "\n");


            #endregion




            #region Q5

            //Console.WriteLine("Q2: Case-Insensitive Sort\n");

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var caseInsensitive = words.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in caseInsensitive)
            //{
            //    Console.WriteLine($"  • {word}");
            //}

            //Console.WriteLine("\n" + new string('-', 60) + "\n");



            #endregion





            #region  Q6

            //Console.WriteLine("Q3: Sort by Stock (Highest to Lowest)\n");

            //var sortedByStock = products.OrderByDescending(p => p.UnitsInStock);

            //foreach (var product in sortedByStock)
            //{
            //    Console.WriteLine($"  • {product}");
            //}

            //Console.WriteLine("\n" + new string('-', 60) + "\n");



            #endregion




            #region Q7

            //Console.WriteLine("Q4: Sort by Length, then Alphabetically\n");

            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var sortedDigits = digits.OrderBy(d => d.Length).ThenBy(d => d);

            //foreach (var digit in sortedDigits)
            //{
            //    Console.WriteLine($"  • {digit} (length: {digit.Length})");
            //}

            //Console.WriteLine("\n" + new string('-', 60) + "\n");



            #endregion



            #region Q8

            //Console.WriteLine("Q5: Sort by Length, then Case-Insensitive\n");

            //var sortedWords = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine($"  • {word} (length: {word.Length})");
            //}

            //Console.WriteLine("\n" + new string('-', 60) + "\n");

            #endregion



            #region Q9

            //Console.WriteLine("Q6: Sort by Category, then Price (Descending)\n");

            //var sortedByCategoryPrice = products.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var product in sortedByCategoryPrice)
            //{
            //    Console.WriteLine($"  • [{product.Category}] {product.ProductName} - ${product.UnitPrice}");
            //}

            //Console.WriteLine("\n" + new string('-', 60) + "\n");



            #endregion



            #region Q10

            //Console.WriteLine("Q7: Sort by Length, then Descending\n");

            //var sortedDescending = words.OrderBy(w => w.Length)
            //                            .ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedDescending)
            //{
            //    Console.WriteLine($"  • {word}");
            //}

            //Console.WriteLine("\n" + new string('-', 60) + "\n");


            #endregion



            #region Q11
            //Console.WriteLine("Q8: Digits with 2nd letter 'i' (Reversed)\n");

            //var digitsWithI = digits.Where(d => d.Length >= 2 && d[1] == 'i')
            //                        .Reverse();

            //foreach (var digit in digitsWithI)
            //{
            //    Console.WriteLine($"  • {digit}");
            //}

            //Console.WriteLine("\n" + new string('═', 60) + "\n");
            #endregion



            #region Q12

            //Console.WriteLine("Q1: Product Names Only\n");

            //var names = products.Select(p => p.ProductName);

            //foreach (var name in names)
            //{
            //    Console.WriteLine($"  • {name}");
            //}

            //Console.WriteLine("\n" + new string('-', 60) + "\n");




            #endregion



            #region Q13

            //Console.WriteLine("Q2: Uppercase and Lowercase Versions\n");

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var upperLower = words.Select(w => new
            //{
            //    Upper = w.ToUpper(),
            //    Lower = w.ToLower()
            //});

            //foreach (var item in upperLower)
            //{
            //    Console.WriteLine($"  • Upper: {item.Upper}, Lower: {item.Lower}");
            //}

            //Console.WriteLine("\n" + new string('-', 60) + "\n");




            #endregion



            #region Q14


            //Console.WriteLine("Q3: Product Info (UnitPrice renamed to Price)\n");

            //var productInfo = products.Select(p => new
            //{
            //    p.ProductName,
            //    p.Category,
            //    Price = p.UnitPrice // Renamed!
            //});

            //foreach (var item in productInfo)
            //{
            //    Console.WriteLine($"  • {item.ProductName} ({item.Category}) - ${item.Price}");
            //}

            //Console.WriteLine("\n" + new string('-', 60) + "\n");


            #endregion


        }



    }





    
    
}
