using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV3
{

        public class Book
        {
            // Properties (data about the book)
            public string ISBN { get; set; }
            public string Title { get; set; }
            public string[] Authors { get; set; }
            public DateTime PublicationDate { get; set; }
            public decimal Price { get; set; }

            // Constructor (to create a book)
            public Book(string isbn, string title, string[] authors, DateTime publicationDate, decimal price)
            {
                ISBN = isbn;
                Title = title;
                Authors = authors;
                PublicationDate = publicationDate;
                Price = price;
            }

            // ToString (for easy printing)
            public override string ToString()
            {
                return $"{Title} by {string.Join(", ", Authors)}";
            }








        }

    
}
