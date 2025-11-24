using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF_2
{
    #region Models
    public class Airline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public List<AirlinePhone> Phones { get; set; } = new();
        public List<Aircraft> Aircrafts { get; set; } = new();
        public List<Transaction> Transactions { get; set; } = new();
        public List<Employee> Employees { get; set; } = new();
    }

    public class AirlinePhone
    {
        public int Id { get; set; }
        public int AirlineId { get; set; }
        public string Phone { get; set; }
        public Airline Airline { get; set; }
    }

    public class Aircraft
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public int AirlineId { get; set; }
        public Airline Airline { get; set; }
        public List<AircraftRoute> AircraftRoutes { get; set; } = new();
    }

    public class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int AirlineId { get; set; }
        public Airline Airline { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AirlineId { get; set; }
        public Airline Airline { get; set; }
    }

    public class Route
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Classification { get; set; }
        public int Distance { get; set; }
        public List<AircraftRoute> AircraftRoutes { get; set; } = new();
    }

    public class AircraftRoute
    {
        public int Id { get; set; }
        public int AircraftId { get; set; }
        public int RouteId { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public int NumOfPassengers { get; set; }
        public decimal Price { get; set; }
        public Aircraft Aircraft { get; set; }
        public Route Route { get; set; }
    }
    #endregion

    #region DbContext
    public class AppDbContext : DbContext
    {
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<AirlinePhone> AirlinePhones { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<AircraftRoute> AircraftRoutes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirlinePhone>()
                        .HasOne(p => p.Airline)
                        .WithMany(a => a.Phones)
                        .HasForeignKey(p => p.AirlineId);

            modelBuilder.Entity<Aircraft>()
                        .HasOne(a => a.Airline)
                        .WithMany(ae => ae.Aircrafts)
                        .HasForeignKey(a => a.AirlineId);

            modelBuilder.Entity<Transaction>()
                        .HasOne(t => t.Airline)
                        .WithMany(a => a.Transactions)
                        .HasForeignKey(t => t.AirlineId);

            modelBuilder.Entity<Employee>()
                        .HasOne(e => e.Airline)
                        .WithMany(a => a.Employees)
                        .HasForeignKey(e => e.AirlineId);

            modelBuilder.Entity<AircraftRoute>()
                        .HasOne(ar => ar.Aircraft)
                        .WithMany(a => a.AircraftRoutes)
                        .HasForeignKey(ar => ar.AircraftId);

            modelBuilder.Entity<AircraftRoute>()
                        .HasOne(ar => ar.Route)
                        .WithMany(r => r.AircraftRoutes)
                        .HasForeignKey(ar => ar.RouteId);
        }
    }
    #endregion

    #region Program
    class Program
    {
        static void Main()
        {
            Console.WriteLine("EF Core CRUD demo (SQLite) starting...");
            using var db = new AppDbContext();
            db.Database.EnsureCreated();

            #region 1) Insert a new airline "EgyptAir" with phones
            if (!db.Airlines.Any(a => a.Name == "EgyptAir"))
            {
                var egypt = new Airline
                {
                    Name = "EgyptAir",
                    Address = "Cairo",
                    ContactPerson = "Ahmed Ali",
                    Phones = new List<AirlinePhone>
                    {
                        new AirlinePhone { Phone = "0123456789" },
                        new AirlinePhone { Phone = "0113654789" }
                    }
                };
                db.Airlines.Add(egypt);
                db.SaveChanges();
            }
            #endregion

            #region 2) Add a new aircraft "Model01" for EgyptAir
            var airline = db.Airlines.First(a => a.Name == "EgyptAir");
            if (!db.Aircrafts.Any(ac => ac.Model == "Model01"))
            {
                db.Aircrafts.Add(new Aircraft { Model = "Model01", Capacity = 180, AirlineId = airline.Id });
                db.SaveChanges();
            }
            #endregion

            #region 3) Record a transaction (Tickets 50000) for EgyptAir
            db.Transactions.Add(new Transaction { Description = "Tickets", Amount = 50000, Date = DateTime.Now, AirlineId = airline.Id });
            db.SaveChanges();
            #endregion

            #region 4) Insert employees for EgyptAir
            if (!db.Employees.Any(e => e.AirlineId == airline.Id))
            {
                db.Employees.Add(new Employee { Name = "Mohamed", AirlineId = airline.Id });
                db.Employees.Add(new Employee { Name = "Sara", AirlineId = airline.Id });
                db.SaveChanges();
            }
            #endregion

            #region 5) Show all transactions for EgyptAir
            var transactions = db.Transactions.Where(t => t.AirlineId == airline.Id).ToList();
            foreach (var t in transactions)
                Console.WriteLine($"Transaction {t.Id}: {t.Description} - {t.Amount}");
            #endregion

            #region 6) Count of employees per airline
            var counts = db.Airlines.Select(a => new { a.Name, Count = a.Employees.Count }).ToList();
            foreach (var c in counts)
                Console.WriteLine($"{c.Name} has {c.Count} employees.");
            #endregion

            #region 7) Update aircraft capacity
            var aircraft = db.Aircrafts.First(ac => ac.Model == "Model01");
            aircraft.Capacity = 200;
            db.SaveChanges();
            #endregion

            #region 8) Delete old transactions (before 2020)
            var oldTx = db.Transactions.Where(t => t.Date.Year < 2020).ToList();
            db.Transactions.RemoveRange(oldTx);
            db.SaveChanges();
            #endregion

            #region 9) Insert route Cairo -> Dubai
            if (!db.Routes.Any(r => r.Origin == "Cairo" && r.Destination == "Dubai"))
            {
                db.Routes.Add(new Route { Origin = "Cairo", Destination = "Dubai", Classification = "International", Distance = 2400 });
                db.SaveChanges();
            }
            #endregion

            #region 10) Assign aircraft to Cairo->Dubai route
            var route = db.Routes.First(r => r.Origin == "Cairo" && r.Destination == "Dubai");
            db.AircraftRoutes.Add(new AircraftRoute
            {
                AircraftId = aircraft.Id,
                RouteId = route.Id,
                Departure = DateTime.Now,
                Arrival = DateTime.Now.AddHours(4),
                NumOfPassengers = 0,
                Price = 3000
            });
            db.SaveChanges();
            #endregion

            Console.WriteLine("All10 questions");
            Console.ReadKey();
        }
    }
    #endregion
}
