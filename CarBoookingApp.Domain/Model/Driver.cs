namespace CarBoookingApp.Domain.Model;

public class Driver
{
    public required Guid Id { get; init; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public List<Ride> CreatedRides { get; set; }
    public required string LicenseNumber { get; set; }
    public VehicleType VehicleType { get; set; }
    
}