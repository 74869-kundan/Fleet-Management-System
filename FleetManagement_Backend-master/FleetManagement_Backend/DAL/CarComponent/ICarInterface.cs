using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagement_Backend.DAL.CarComponent
{
    public interface ICarInterface
    {
        Task<ActionResult<IEnumerable<Car>>?> GetCarsByHubAndCategory(int hubId, int categoryId);

        Task<ActionResult<IEnumerable<Car>>?> GetCarsByHubId(int hubId);
    }
}
