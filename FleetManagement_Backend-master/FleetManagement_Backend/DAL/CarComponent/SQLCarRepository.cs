using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FleetManagement_Backend.DAL.CarComponent
{
    public class SQLCarRepository : ICarInterface
    {
        private readonly AppDbContext _appDbContext;

        public SQLCarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ActionResult<IEnumerable<Car>>?> GetCarsByHubAndCategory(int hubId, int categoryId)
        {
            var cars = await _appDbContext.Car
                .Where(c => c.HubId == hubId && c.CategoryId == categoryId && c.Availability == 1)
                .ToListAsync();

            if (cars == null || cars.Count == 0)
                return null;

            return new ActionResult<IEnumerable<Car>>(cars);
        }

        public async Task<ActionResult<IEnumerable<Car>>?> GetCarsByHubId(int hubId)
        {
            var cars = await _appDbContext.Car.Where(c => c.HubId == hubId).ToListAsync();

            if (cars == null || cars.Count == 0)
            {
                return null;
            }

            return new ActionResult<IEnumerable<Car>>(cars);

            //throw new NotImplementedException();
        }
    }
}
