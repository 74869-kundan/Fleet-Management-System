using FleetManagement_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.Collections;
using Microsoft.AspNetCore.Cors;
using FleetManagement_Backend.DAL.CityComponent;

namespace FleetManagement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class CityController : ControllerBase
    {
        private readonly ICityInterface _cityInterface;

        public CityController(ICityInterface cityInterface) 
        {
            _cityInterface = cityInterface;
        }


        // Get List of City by providing state id
        [HttpGet("{state_id:int}")]
        public async Task<ActionResult<IEnumerable<City>>> GetCitiesByStateId(int state_id)
        {
            var cities = await _cityInterface.GetAllCityByStateId(state_id);

            return cities == null ? NotFound() : cities;
        }
    }
}
