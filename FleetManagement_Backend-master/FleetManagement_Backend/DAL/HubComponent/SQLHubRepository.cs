using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FleetManagement_Backend.DAL.HubComponent
{
    public class SQLHubRepository : IHubInterface
    {
        private readonly AppDbContext appDbContext;
        public SQLHubRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<ActionResult<IEnumerable<Hubs>>?> GetAllHub()
        {
            return await appDbContext.Hubs.ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<ActionResult<Hubs>?> GetHubByAirportId(int airportId)
        {
            var hub = await appDbContext.Hubs.FirstOrDefaultAsync(h => h.AirportId == airportId);

            if (hub == null)
            {
                return null;
            }

            return hub;

            //throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Hubs>>?> GetHubsByCityId(int cityId)
        {
            var hub = await appDbContext.Hubs.Where(h => h.CityId == cityId).ToListAsync();

            if (hub == null)
            {
                return null;
            }
            return hub;
            //throw new NotImplementedException();
        }
    }
}
