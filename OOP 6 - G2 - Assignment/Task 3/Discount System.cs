using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Task 3: Discount System ===");

            string userType = ReadUserType("Enter user type (regular/premium/guest): ");
            decimal price = ReadDecimal("Enter product price: ");
            int quantity = ReadInt("Enter quantity: ");

            decimal total = price * quantity;
            decimal discount = userType switch
            {
                "regular" => total * 0.05m,
                "premium" => 100m,
                _ => 0m
            };

            if (discount < 0) discount = 0m;
            if (discount > total) discount = total;

            decimal finalPrice = total - discount;

            Console.WriteLine($"Total: {total.ToString("F2", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Discount: {discount.ToString("F2", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Final Price: {finalPrice.ToString("F2", CultureInfo.CurrentCulture)}");
        }

        static int ReadInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        static decimal ReadDecimal(string prompt)
        {
            Console.Write(prompt);
            return decimal.Parse(Console.ReadLine());
        }

        static string ReadUserType(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a user type.");
                    continue;
                }

                string normalized = input.Trim().ToLowerInvariant();
                if (normalized == "regular" || normalized == "premium" || normalized == "guest")
                    return normalized;

                Console.WriteLine("Unknown user type. Please enter one of: regular, premium, guest.");
            }
        }
    }
}
