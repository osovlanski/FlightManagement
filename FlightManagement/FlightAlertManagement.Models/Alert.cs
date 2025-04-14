using System.ComponentModel.DataAnnotations;

public class Alert
{
    public Guid AlertId { get; set; }
    public Guid UserId { get; set; }
    public Route Route { get; set; }
    public DateRange DateRange { get; set; }
    public decimal PriceThreshold { get; set; }
    public List<string> Airlines { get; set; }
    public string CabinClass { get; set; }
    public int MaxStops { get; set; }
    public bool Active { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? LastNotified { get; set; }
}

public class Route
{
    public string Origin { get; set; }
    public string Destination { get; set; }
    public bool OneWay { get; set; }
}

public class DateRange
{
    public DateTime DepartureStart { get; set; }
    public DateTime DepartureEnd { get; set; }
    public DateTime? ReturnStart { get; set; }
    public DateTime? ReturnEnd { get; set; }
}