using FleetManagement_Backend.DAL.HubComponent;
using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class HubController : ControllerBase
    {
        private readonly IHubInterface _hub;

        public HubController(IHubInterface hub)
        {
            _hub = hub;
        }

        // GET: api/<HubController>
        // Get list of all Hubs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hubs>>?> GetAllHubs()
        {
            if (await _hub.GetAllHub() == null)
            {
                return NotFound();
            }

            return await _hub.GetAllHub();
        }


        // Get List of Hubs by providing City Id
        [HttpGet("city/{cityId:int}")]
        public async Task<ActionResult<IEnumerable<Hubs>>> GetHubsByCityId(int cityId)
        {
            var hub = await _hub.GetHubsByCityId(cityId);

            return hub == null ? NotFound() : hub;
        }

        // Get list of Hubs by providing AirportId
        [HttpGet("airport/{airportId:int}")]
        public async Task<ActionResult<Hubs>> GetHubByAirportId(int airportId) 
        {
            var hub = await _hub.GetHubByAirportId(airportId);

            return hub == null ? NotFound() : hub;
        }
    }
}
