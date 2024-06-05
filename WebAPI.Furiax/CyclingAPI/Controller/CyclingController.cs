using CyclingAPI.Models;
using CyclingAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CyclingAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CyclingController : ControllerBase
    {
        private readonly ICyclingService _cyclingService;
        public CyclingController(ICyclingService cyclingService)
        {
            _cyclingService = cyclingService;
        }

        [HttpGet]
        public ActionResult<List<CyclingTrip>> GetAllTrips() 
        {
            return Ok(_cyclingService.GetAllCyclingTrips());
        }

        [HttpGet("{id}")]
        public ActionResult<CyclingTrip> GetTripById(int id) 
        {
            var result = _cyclingService.GetCyclingTripById(id);
            if (result is null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public ActionResult<CyclingTrip> CreateTrip(CyclingTrip trip)
        {
            return Ok(_cyclingService.AddCyclingTrip(trip));
        }

        [HttpPut("{id}")]
        public ActionResult<CyclingTrip> UpdateTrip(int id, CyclingTrip updatedTrip)
        {
            var result = _cyclingService.EditCyclingTrip(id, updatedTrip);
            if (result is null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteTrip(int id)
        {
            var result = _cyclingService.DeleteCyclingTrip(id);
            if(result is null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
