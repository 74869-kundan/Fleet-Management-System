using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FleetManagement_Backend.DAL.StateComponent
{
    public class SQLStateRepository : IStateInterface
    {
        private readonly AppDbContext _appDbContext;

        public SQLStateRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ActionResult<IEnumerable<State>>> GetAllState()
        {
            if (_appDbContext.State == null)
            {
                return null;
            }

            return await _appDbContext.State.ToListAsync();
        }

        public async Task<ActionResult<State>?> GetState(int Id)
        {
            if (_appDbContext.State == null)
            {
                return null;
            }

            var state = await _appDbContext.State.FindAsync(Id);
            if (state == null)
            {
                return null;
            }
            return state;
            //throw new NotImplementedException();
        }
    }
}
