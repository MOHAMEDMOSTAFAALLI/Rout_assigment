using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EFCoreAssignment.Data;
using EFCoreAssignment.Models;
using System.Numerics;

namespace EFCoreAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AirlineDbContext())
            {
                // Ensure database is created
                context.Database.EnsureCreated();

                // Seed sample data
                SeedData(context);

                Console.WriteLine("========== SECTION A: Loading Related Data ==========\n");

                // Question 1: Load EgyptAir with aircrafts and routes
                Console.WriteLine("1. Load EgyptAir with all its aircrafts and routes:");
                var egyptAir = context.Airlines
                    .Include(a => a.Aircrafts)
                        .ThenInclude(aircraft => aircraft.Routes)
                    .FirstOrDefault(a => a.Name == "EgyptAir");

                if (egyptAir != null)
                {
                    Console.WriteLine($"Airline: {egyptAir.Name}");
                    foreach (var aircraft in egyptAir.Aircrafts)
                    {
                        Console.WriteLine($"  Aircraft: {aircraft.Model}");
                        foreach (var route in aircraft.Routes)
                        {
                            Console.WriteLine($"    Route: {route.Origin} -> {route.Destination}");
                        }
                    }
                }
                Console.WriteLine();

                // Question 2: Retrieve airlines with employees and qualifications
                Console.WriteLine("2. Retrieve all airlines with employees and qualifications:");
                var airlinesWithEmployees = context.Airlines
                    .Include(a => a.Employees)
                        .ThenInclude(e => e.Qualifications)
                    .ToList();

                foreach (var airline in airlinesWithEmployees)
                {
                    Console.WriteLine($"Airline: {airline.Name}");
                    foreach (var employee in airline.Employees)
                    {
                        Console.WriteLine($"  Employee: {employee.Name}");
                        foreach (var qual in employee.Qualifications)
                        {
                            Console.WriteLine($"    Qualification: {qual.Name}");
                        }
                    }
                }
                Console.WriteLine();

                // Question 3: Load airlines with transactions (Amount > 10000)
                Console.WriteLine("3. Load airlines with transactions (Amount > 10000):");
                var airlinesWithTransactions = context.Airlines
                    .Include(a => a.Transactions.Where(t => t.Amount > 10000))
                    .ToList();

                foreach (var airline in airlinesWithTransactions)
                {
                    Console.WriteLine($"Airline: {airline.Name}");
                    foreach (var trans in airline.Transactions)
                    {
                        Console.WriteLine($"  Transaction: ${trans.Amount} - {trans.Description}");
                    }
                }
                Console.WriteLine();

                // Question 4: Select all routes with aircraft models
                Console.WriteLine("4. Select all routes with aircraft models:");
                var routesWithAircraft = context.Routes
                    .Include(r => r.Aircraft)
                    .Select(r => new
                    {
                        RouteOrigin = r.Origin,
                        RouteDestination = r.Destination,
                        AircraftModel = r.Aircraft.Model
                    })
                    .ToList();

                foreach (var item in routesWithAircraft)
                {
                    Console.WriteLine($"Route: {item.RouteOrigin} -> {item.RouteDestination}, Aircraft: {item.AircraftModel}");
                }
                Console.WriteLine();

                // Question 5: Retrieve aircrafts with airline and phones
                Console.WriteLine("5. Retrieve aircrafts with airline and phones:");
                var aircraftsWithPhones = context.Aircrafts
                    .Include(a => a.Airline)
                        .ThenInclude(airline => airline.Phones)
                    .ToList();

                foreach (var aircraft in aircraftsWithPhones)
                {
                    Console.WriteLine($"Aircraft: {aircraft.Model}, Airline: {aircraft.Airline.Name}");
                    foreach (var phone in aircraft.Airline.Phones)
                    {
                        Console.WriteLine($"  Phone: {phone.Number}");
                    }
                }
                Console.WriteLine();

                Console.WriteLine("\n========== SECTION B: Join Operators ==========\n");

                // Question 1: List all employees with airline name
                Console.WriteLine("1. List all employees with airline name:");
                var employeesWithAirline = context.Employees
                    .Join(context.Airlines,
                        employee => employee.AirlineId,
                        airline => airline.Id,
                        (employee, airline) => new
                        {
                            EmployeeName = employee.Name,
                            AirlineName = airline.Name
                        })
                    .ToList();

                foreach (var item in employeesWithAirline)
                {
                    Console.WriteLine($"Employee: {item.EmployeeName}, Airline: {item.AirlineName}");
                }
                Console.WriteLine();

                // Question 2: Show routes with aircraft model and airline name
                Console.WriteLine("2. Show routes with aircraft model and airline name:");
                var routesWithAirlines = context.Routes
                    .Join(context.Aircrafts,
                        route => route.AircraftId,
                        aircraft => aircraft.Id,
                        (route, aircraft) => new { route, aircraft })
                    .Join(context.Airlines,
                        temp => temp.aircraft.AirlineId,
                        airline => airline.Id,
                        (temp, airline) => new
                        {
                            Origin = temp.route.Origin,
                            Destination = temp.route.Destination,
                            AircraftModel = temp.aircraft.Model,
                            AirlineName = airline.Name
                        })
                    .ToList();

                foreach (var item in routesWithAirlines)
                {
                    Console.WriteLine($"Route: {item.Origin} -> {item.Destination}, Aircraft: {item.AircraftModel}, Airline: {item.AirlineName}");
                }
                Console.WriteLine();

                // Question 3: For each airline, list aircraft models
                Console.WriteLine("3. For each airline, list aircraft models:");
                var airlinesWithModels = context.Airlines
                    .GroupJoin(context.Aircrafts,
                        airline => airline.Id,
                        aircraft => aircraft.AirlineId,
                        (airline, aircrafts) => new
                        {
                            AirlineName = airline.Name,
                            AircraftModels = aircrafts.Select(a => a.Model).ToList()
                        })
                    .ToList();

                foreach (var item in airlinesWithModels)
                {
                    Console.WriteLine($"Airline: {item.AirlineName}");
                    foreach (var model in item.AircraftModels)
                    {
                        Console.WriteLine($"  Model: {model}");
                    }
                }
                Console.WriteLine();

                // Question 4: Show transactions (Amount > 20000) with airline name
                Console.WriteLine("4. Show transactions (Amount > 20000) with airline name:");
                var largeTransactions = context.Transactions
                    .Where(t => t.Amount > 20000)
                    .Join(context.Airlines,
                        transaction => transaction.AirlineId,
                        airline => airline.Id,
                        (transaction, airline) => new
                        {
                            transaction.Id,
                            transaction.Amount,
                            transaction.Description,
                            AirlineName = airline.Name
                        })
                    .ToList();

                foreach (var item in largeTransactions)
                {
                    Console.WriteLine($"Transaction #{item.Id}: ${item.Amount} - {item.Description}, Airline: {item.AirlineName}");
                }

                Console.WriteLine("\n\nPress any key to exit...");
                Console.ReadKey();
            }
        }

        static void SeedData(AirlineDbContext context)
        {
            // Check if data already exists
            if (context.Airlines.Any())
                return;

            // Create Airlines
            var egyptAir = new Airline { Name = "EgyptAir" };
            var emirates = new Airline { Name = "Emirates" };

            context.Airlines.AddRange(egyptAir, emirates);
            context.SaveChanges();

            // Create Phones
            context.Phones.AddRange(
                new Phone { Number = "+20-123-456-7890", AirlineId = egyptAir.Id },
                new Phone { Number = "+20-987-654-3210", AirlineId = egyptAir.Id },
                new Phone { Number = "+971-555-1234", AirlineId = emirates.Id }
            );

            // Create Aircrafts
            var aircraft1 = new Aircraft { Model = "Boeing 737", AirlineId = egyptAir.Id };
            var aircraft2 = new Aircraft { Model = "Airbus A320", AirlineId = egyptAir.Id };
            var aircraft3 = new Aircraft { Model = "Boeing 777", AirlineId = emirates.Id };

            context.Aircrafts.AddRange(aircraft1, aircraft2, aircraft3);
            context.SaveChanges();

            // Create Routes
            context.Routes.AddRange(
                new Route { Origin = "Cairo", Destination = "Dubai", AircraftId = aircraft1.Id },
                new Route { Origin = "Cairo", Destination = "London", AircraftId = aircraft2.Id },
                new Route { Origin = "Dubai", Destination = "New York", AircraftId = aircraft3.Id }
            );

            // Create Employees
            var emp1 = new Employee { Name = "Ahmed Ali", AirlineId = egyptAir.Id };
            var emp2 = new Employee { Name = "Sara Mohamed", AirlineId = egyptAir.Id };
            var emp3 = new Employee { Name = "Omar Hassan", AirlineId = emirates.Id };

            context.Employees.AddRange(emp1, emp2, emp3);
            context.SaveChanges();

            // Create Qualifications
            context.Qualifications.AddRange(
                new Qualification { Name = "Pilot License", EmployeeId = emp1.Id },
                new Qualification { Name = "Type Rating A320", EmployeeId = emp1.Id },
                new Qualification { Name = "Flight Attendant", EmployeeId = emp2.Id },
                new Qualification { Name = "Safety Certificate", EmployeeId = emp2.Id },
                new Qualification { Name = "Pilot License", EmployeeId = emp3.Id }
            );

            // Create Transactions
            context.Transactions.AddRange(
                new Transaction { Amount = 15000, Description = "Fuel Purchase", AirlineId = egyptAir.Id },
                new Transaction { Amount = 25000, Description = "Aircraft Maintenance", AirlineId = egyptAir.Id },
                new Transaction { Amount = 5000, Description = "Office Supplies", AirlineId = egyptAir.Id },
                new Transaction { Amount = 30000, Description = "Equipment Upgrade", AirlineId = emirates.Id }
            );

            context.SaveChanges();
            Console.WriteLine("Sample data seeded successfully!\n");
        }
    }
}