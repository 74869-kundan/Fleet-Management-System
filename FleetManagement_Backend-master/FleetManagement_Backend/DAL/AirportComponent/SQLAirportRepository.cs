using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FleetManagement_Backend.DAL.AirportComponent
{
    public class SQLAirportRepository : IAirportInterface
    {
        private readonly AppDbContext _appDbContext;

        public SQLAirportRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ActionResult<IEnumerable<Airport>>?> GetAllAirport()
        {
            if (_appDbContext.Airport == null)
            {
                return null;
            }

            return await _appDbContext.Airport.ToListAsync();
        }

        public async Task<ActionResult<Airport>?> GetAirport(int Id)
        {
            if (_appDbContext.Airport == null)
            {
                return null;
            }

            var airport = await _appDbContext.Airport.FindAsync(Id);
            if (airport == null)
            {
                return null;
            }
            return airport;
            //throw new NotImplementedException();
        }
    }
}

