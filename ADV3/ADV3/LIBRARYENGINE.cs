using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV3
{
    public class LibraryEngine
    {
       

        public static void ProcessBooks(List<Book> books, BookDelegate fPtr, string title)
        {
            Console.WriteLine($" {title} ");

            foreach (Book book in books)
            {
                // Call whatever method fPtr is pointing to
                string result = fPtr(book);
                Console.WriteLine($"  • {result}");
            }
        }
    }

}
