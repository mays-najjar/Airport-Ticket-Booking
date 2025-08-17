using Airport_Ticket_Booking.Data;
using Airport_Ticket_Booking.Models;

namespace Airport_Ticket_Booking.Services;

public class PassengerService
{
    private readonly IRepository<Passenger> _passengerRepository;

    public PassengerService(IRepository<Passenger> passengerRepository)
    {
        _passengerRepository = passengerRepository;
    }

    public async Task<IEnumerable<Passenger>> GetAllPassengersAsync()
    {
        return await _passengerRepository.GetAll();
    }

    public async Task<Passenger?> GetPassengerByIdAsync(string id)
    {
        return await _passengerRepository.GetById(id);
    }

public async Task<Passenger?> GetPassengerByEmailAsync(string email)
{
    var passengers = await _passengerRepository.GetAll();
    var trimmedEmail = email.Trim().ToLowerInvariant();
    return passengers.FirstOrDefault(p => p.Email.Trim().ToLowerInvariant() == trimmedEmail);
}

    public async Task AddPassengerAsync(Passenger passenger)
    {
        await _passengerRepository.AddAsync(passenger);
    }

    public async Task UpdatePassengerAsync(Passenger passenger)
    {
        await _passengerRepository.UpdateAsync(passenger);
    }

    public async Task DeletePassengerAsync(string id)
    {
        await _passengerRepository.DeleteAsync(id);
    }
}
