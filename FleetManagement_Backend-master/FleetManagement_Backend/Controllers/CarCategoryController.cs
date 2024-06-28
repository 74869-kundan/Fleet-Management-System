using FleetManagement_Backend.DAL.CarCategoryComponent;
using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class CarCategoryController : ControllerBase
    {
        private readonly ICarCategoryInterface carCategoryInterface;

        public CarCategoryController(ICarCategoryInterface carCategoryInterface)
        {
            this.carCategoryInterface = carCategoryInterface;
        }


        //this method will return List of Categories of all cars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarCategory>>?> GetAllCarCategory() 
        {
            if (await carCategoryInterface.GetAllCarCategories() == null) 
            {
                return NotFound();
            }

            return await carCategoryInterface.GetAllCarCategories();
        }
    }
}
