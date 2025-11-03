namespace ADV3
{
    internal class Program
    {
        static void Main(string[] args)
     
        {

            List<Book> library = new List<Book>
            {
              new Book(
                "978-1-111111-11-1",
                "C# for Beginners",
                new string[] { "John Smith" },
                new DateTime(2020, 3, 15),
                29.99m  ),
                new Book(
                "978-2-222222-22-2",
                "Advanced Programming",
                new string[] { "Mary Jones", "Bob Lee" },
                new DateTime(2021, 7, 22),
                45.50m),
               new Book(
                "978-3-333333-33-3",
                "Design Patterns",
                new string[] { "Alice Brown" },
                new DateTime(2019, 11, 5),
                39.99m )
            };

            Console.WriteLine("📚 Library contains 3 books\n");
        }
    }
    
}
