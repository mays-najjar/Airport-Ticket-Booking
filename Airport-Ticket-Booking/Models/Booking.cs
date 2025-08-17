using System.ComponentModel.DataAnnotations;

namespace Airport_Ticket_Booking.Models;

public class Booking
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    [Required(ErrorMessage = "Flight ID is required")]
    public string FlightId { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Passenger ID is required")]
    public string PassengerId { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Flight class is required")]
    public FlightClass SelectedClass { get; set; }
    
    [Required(ErrorMessage = "Booking date is required")]
    public DateTime BookingDate { get; set; } = DateTime.Now;
    
    [Required(ErrorMessage = "Total price is required")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Total price must be greater than 0")]
    public decimal TotalPrice { get; set; }
    
    [Required(ErrorMessage = "Number of seats is required")]
    [Range(1, int.MaxValue, ErrorMessage = "Number of seats must be at least 1")]
    public int NumberOfSeats { get; set; } = 1;
    
    public bool IsCancelled { get; set; }
    
    public override string ToString()
    {
        return $"Booking {Id} - Flight: {FlightId}, Passenger: {PassengerId}, Class: {SelectedClass}, Seats: {NumberOfSeats}, Total: ${TotalPrice}";
    }
}
