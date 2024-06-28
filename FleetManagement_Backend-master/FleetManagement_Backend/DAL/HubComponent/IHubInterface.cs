using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagement_Backend.DAL.HubComponent
{
    public interface IHubInterface
    {
        Task<ActionResult<IEnumerable<Hubs>>?> GetAllHub();

        Task<ActionResult<IEnumerable<Hubs>>?> GetHubsByCityId(int cityId);

        Task<ActionResult<Hubs>?> GetHubByAirportId(int airportId);
    }
}
