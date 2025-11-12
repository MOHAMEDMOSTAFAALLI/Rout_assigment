using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_1___G2
{
    internal class LinqAssignment
    {


        public static void RestrictionOperators()
        {

            // Sample products
            List<Product> products = new List<Product>
        {
            new Product { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00m, UnitsInStock = 39 },
            new Product { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.00m, UnitsInStock = 17 },
            new Product { ProductID = 3, ProductName = "Aniseed", Category = "Condiments", UnitPrice = 10.00m, UnitsInStock = 0 },
            new Product { ProductID = 4, ProductName = "Chef Mix", Category = "Condiments", UnitPrice = 22.00m, UnitsInStock = 0 },
            new Product { ProductID = 5, ProductName = "Gumbo", Category = "Seafood", UnitPrice = 2.50m, UnitsInStock = 15 },
            new Product { ProductID = 6, ProductName = "Syrup", Category = "Condiments", UnitPrice = 3.50m, UnitsInStock = 25 }
        };
        }
    }
}
