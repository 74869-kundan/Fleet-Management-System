using FleetManagement_Backend.DAL.CarComponent;
using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class CarController : ControllerBase
    {
        private readonly ICarInterface _cars;

        public CarController(ICarInterface cars) 
        {
            _cars = cars;
        }

        // to get Cars List from hub id and category Id
        [HttpGet("cars/{hubId:int}/{categoryId:int}")]
        public async Task<ActionResult<IEnumerable<Car>>> GetCarsByHubAndCategory(int hubId, int categoryId)
        {
            var cars = await _cars.GetCarsByHubAndCategory(hubId, categoryId);

            return cars == null ? NotFound() : cars;
        }

        // to get Cars list from only Hub id
        [HttpGet("cars/{hubId:int}")]
        public async Task<ActionResult<IEnumerable<Car>>> GetCarByHubId(int hubId) 
        {
            var cars = await _cars.GetCarsByHubId(hubId);

            return cars == null ? NotFound() : cars;
        }
    }
}
