using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV3
{
    


        public class BookFunctions
        {
            
            public static string GetTitle(Book book)
            {
                return book.Title;
            }

            public static string GetAuthors(Book book)
            {
                return string.Join(", ", book.Authors);
            }

            public static string GetPrice(Book book)
            {
                return $"${book.Price:0.00}";
            }

            public static string GetISBN(Book book)
            {
                return book.ISBN;
            }

            public static string GetPublicationDate(Book book)
            {
                return book.PublicationDate.ToString("yyyy-MM-dd");
            }
        }
    
}
