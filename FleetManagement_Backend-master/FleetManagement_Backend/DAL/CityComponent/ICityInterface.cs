using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagement_Backend.DAL.CarComponent
{
    public interface ICityInterface
    {
        //Task<ActionResult<IEnumerable<City>>> GetAllCity();

        Task<ActionResult<IEnumerable<City>>> GetAllCityByStateId(int stateId);

    }
}
