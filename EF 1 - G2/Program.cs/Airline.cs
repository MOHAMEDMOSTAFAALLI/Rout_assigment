#region Aircraft
public class Aircraft
{
    public int Id { get; set; }
    public int Capacity { get; set; }
    public string Model { get; set; }
    public string MainPilot { get; set; }
    public string Assistant { get; set; }
    public string Host1 { get; set; }
    public string Host2 { get; set; }
    public int AirlineId { get; set; }
}
#endregion

#region Airline
public class Airline
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactPerson { get; set; }
}

#endregion

#region Airline_Phones
public class AirlinePhone
{
    public int AirlineId { get; set; }
    public string Phone { get; set; }
}
#endregion

#region Transaction
public class Transaction
{
    public int Id { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public int AirlineId { get; set; }
}

#endregion

#region Employee
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }
    public string Position { get; set; }
    public int BirthYear { get; set; }
    public int BirthMonth { get; set; }
    public int BirthDay { get; set; }
    public int AirlineId { get; set; }
}
#endregion

#region Emp_Qualifications
public class EmpQualification
{
    public int EmpId { get; set; }
    public string Qualification { get; set; }
}
#endregion

#region Route
public class Route
{
    public int Id { get; set; }
    public int Distance { get; set; }
    public string Destination { get; set; }
    public string Origin { get; set; }
    public string Classification { get; set; }
}
#endregion 


#region Aircraft_Routes
public class AircraftRoute
{
    public int AircraftId { get; set; }
    public int RouteId { get; set; }
    public DateTime Departure { get; set; }
    public int NumOfPassengers { get; set; }
    public decimal Price { get; set; }
    public DateTime Arrival { get; set; }
}
#endregion