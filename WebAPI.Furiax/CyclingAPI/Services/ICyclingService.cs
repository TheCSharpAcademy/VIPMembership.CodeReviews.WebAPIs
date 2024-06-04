using CyclingAPI.Models;

namespace CyclingAPI.Services
{
    public interface ICyclingService
    {
        public List<CyclingTrip> GetAllCyclingTrips();
        public CyclingTrip? GetCyclingTripById(int id);
        public CyclingTrip AddCyclingTrip(CyclingTrip trip);
        public CyclingTrip EditCyclingTrip(int id, CyclingTrip updatedTrip);
        public string? DeleteCyclingTrip(int id);
    }
}
