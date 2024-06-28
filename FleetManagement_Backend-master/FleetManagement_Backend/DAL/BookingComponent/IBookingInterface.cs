using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagement_Backend.DAL.BookingComponent
{
    public interface IBookingInterface
    {
        Task<ActionResult<Booking>?> GetBookingByPhoneNo(string phoneno);
        Task<ActionResult<Booking>?> GetBookingByEmail(string email);

        Task<ActionResult<Booking>> SaveInBooking(Booking booking);
        Task<ActionResult<Booking>> GetBookingById(int id);
    }
}
