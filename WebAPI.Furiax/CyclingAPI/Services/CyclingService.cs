using CyclingAPI.Data;
using CyclingAPI.Models;

namespace CyclingAPI.Services
{
    public class CyclingService : ICyclingService
    {
        private readonly CyclingDbContext _context;

        public CyclingService(CyclingDbContext context)
        {
            _context = context;
        }
        public CyclingTrip AddCyclingTrip(CyclingTrip trip)
        {
            CalculateAverageSpeed(trip);
            var newTrip = _context.CyclingTrips.Add(trip);
            _context.SaveChanges();

            return newTrip.Entity;
        }

        public string? DeleteCyclingTrip(int id)
        {
            CyclingTrip? trip = _context.CyclingTrips.Find(id);

            if (trip is null)
            {
                return null;
            }

            _context.CyclingTrips.Remove(trip);
            _context.SaveChanges();
            return $"The trip with id number {id} was successfully deleted.";
        }

        public CyclingTrip EditCyclingTrip(int id, CyclingTrip updatedTrip)
        {
            CyclingTrip? tripData = _context.CyclingTrips.Find(id);

            if (tripData is null)
            {
                return null;
            }

            tripData.Id = updatedTrip.Id;
            tripData.Date = updatedTrip.Date;
            tripData.StartingLocation = updatedTrip.StartingLocation;
            tripData.EndLocation = updatedTrip.EndLocation;
            tripData.Distance = updatedTrip.Distance;
            tripData.Duration = updatedTrip.Duration;

            tripData.AltitudeMeters = updatedTrip.AltitudeMeters;

            CalculateAverageSpeed(tripData);

            _context.SaveChanges();

            return tripData;

        }

        public List<CyclingTrip> GetAllCyclingTrips()
        {
            return _context.CyclingTrips.ToList();
        }

        public CyclingTrip? GetCyclingTripById(int id)
        {
            var result = _context.CyclingTrips.Find(id);
            if (result is null)
            {
                return null;
            }
            return result;
        }

        private void CalculateAverageSpeed(CyclingTrip trip)
        {
            if (trip.Duration.TotalHours > 0)
            {
                trip.AvarageSpeed = trip.Distance / trip.Duration.TotalHours;
            }
            else
            {
                trip.AvarageSpeed = 0;
            }
        }
    }
}
