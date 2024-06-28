using FleetManagement_Backend.DAL.StateComponent;
using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FleetManagement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class StateController : ControllerBase
    {
        
        private readonly IStateInterface _state;

        public StateController(IStateInterface state)
        {
            _state = state; 
        }

        // GET: api/<StateController>

        //Get List of All the States
        [HttpGet]
        public async Task<ActionResult<IEnumerable<State>>> GetState()
        {
            if (await _state.GetAllState() == null)
            {
                return NotFound();
            }

            return await _state.GetAllState();
        }


        // Get a single record by providing State id
        [HttpGet("{id:int}")] // api/State/
        public async Task<ActionResult<State>> GetStateById(int id)
        {
            var state = await _state.GetState(id);

            return state == null ? NotFound() : state;
        }
    }
}
