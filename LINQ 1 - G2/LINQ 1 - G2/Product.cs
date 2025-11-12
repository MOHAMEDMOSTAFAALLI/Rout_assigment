using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_1___G2
{
    internal class Product
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }



        public static void OrderingOperators()
        
            
            List<Product> products = new List<Product>
        {
            new Product { ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00m, UnitsInStock = 39 },
            new Product { ProductName = "Aniseed", Category = "Condiments", UnitPrice = 10.00m, UnitsInStock = 13 },
            new Product { ProductName = "Tofu", Category = "Produce", UnitPrice = 23.25m, UnitsInStock = 35 },
            new Product { ProductName = "Gumbo", Category = "Seafood", UnitPrice = 21.35m, UnitsInStock = 0 }
        };

        public static void TransformationOperators()
        
           
            List<Product> products = new List<Product>
        {
            new Product { ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00m, UnitsInStock = 39 },
            new Product { ProductName = "Tofu", Category = "Produce", UnitPrice = 23.25m, UnitsInStock = 35 }
        };



        public override string ToString()
        {
            return $"{ProductName} (${UnitPrice}) - Stock: {UnitsInStock}";
        }







    }

   

}
