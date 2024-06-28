using FleetManagement_Backend.DAL;
using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FleetManagement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class UsersController : ControllerBase
    {
        private readonly IUsersInterface _usersInterface;

        public UsersController(IUsersInterface usersInterface)
        {
            _usersInterface = usersInterface;
        }


        [HttpGet("/byemail/{emailid}")]

        public async Task<ActionResult<Users>> GetUserByEmailId(string emailid)
        {
            var user_list = await _usersInterface.GetUsersByEmailId(emailid);

            return user_list== null ? NotFound() : user_list;

        }


        [HttpGet("/byemail-password/{emailid}/{password}")]

        public async Task<ActionResult<Users>> GetUserByEmailIdAndPassword(string emailid, string password)
        {
            var user_list = await _usersInterface.GetUsersByEmailIdAndPassword(emailid, password);

            return user_list == null ? NotFound() : user_list;

        }

        [HttpGet("byUserId/{id:int}")]
        public async Task<ActionResult<Users>> GetUserById(int id)
        {
            var user_list = await _usersInterface.GetUserById(id);

            return user_list == null ? NotFound() : user_list;

        }


        [HttpPost]
        public async Task<ActionResult<Users>?> PostUser(Users User)
        {
            await _usersInterface.PostUser(User);

            return Ok(User);
        }


    }
}
