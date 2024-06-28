using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace FleetManagement_Backend.DAL.CarComponent
{
    public class SQLCityRepository : ICityInterface
    {
        private readonly AppDbContext _appDbContext;
        public SQLCityRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<ActionResult<IEnumerable<City>>?> GetAllCityByStateId(int stateId)
        {
            if (_appDbContext.City == null)
            {
                return null;
            }

            
            var cities = await _appDbContext.City.Where(c => c.StateId == stateId).ToListAsync();
            
            if (cities == null) 
            {
                return null;
            }  
            return cities;
            //return cities;
          
                /*// Log the exception if necessary
                return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
           */
        }


    }
}
