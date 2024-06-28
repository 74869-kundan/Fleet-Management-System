using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagement_Backend.DAL.UserComponent
{
    public interface IUsersInterface
    {

        Task<ActionResult<Users>?> GetUsersByEmailId(string emailid);

        Task<ActionResult<Users>?> GetUsersByEmailIdAndPassword(string emailid, string password);
        Task<ActionResult<Users>> GetUserById(int id);
        Task<ActionResult<Users>?> PostUser(Users user);
    }
}
