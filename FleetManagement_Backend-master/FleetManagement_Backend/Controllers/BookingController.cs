using FleetManagement_Backend.DAL.BookingComponent;
using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class BookingController : ControllerBase
    {

        private readonly IBookingInterface booking;

        public BookingController(IBookingInterface booking)
        {
            this.booking = booking;
        }


        // get a booking record by providing BookingId
        [HttpGet("byBookingId/{id}")]
        public async Task<ActionResult<Booking>> GetBookingById(int id) 
        {
            var booking_list = await booking.GetBookingById(id);

            return booking_list == null ? NotFound() : booking_list;
        }


        // get a booking record by providing Customer Mobile number
        [HttpGet("by-phone/{mobileno}")]

        public async Task<ActionResult<Booking>> GetBookingByPhoneNo(string mobileno) 
        {
            var booking_list = await booking.GetBookingByPhoneNo(mobileno);

            return booking_list == null ? NotFound() : booking_list;
        }


        // get a booking record by providing Customer Email-id
        [HttpGet("by-email/{email}")]
        public async Task<ActionResult<Booking>> GetBookingByEmail(string email)
        {
            var booking_list = await booking.GetBookingByEmail(email);
            return booking_list == null ? NotFound() : booking_list;
        }


        // Entering Booking data in the database
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking booking_post) 
        {
           await booking.SaveInBooking(booking_post);

            return CreatedAtAction("GetBookingById", new { id = booking_post.BookingId }, booking_post);
        }

    }
}
