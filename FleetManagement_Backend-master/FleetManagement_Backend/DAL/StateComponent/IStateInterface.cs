using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagement_Backend.DAL.StateComponent
{
    public interface IStateInterface
    {
        Task<ActionResult<IEnumerable<State>>> GetAllState();

        Task<ActionResult<State>?> GetState(int Id);
    }

}
