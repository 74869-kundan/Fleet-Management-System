using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FleetManagement_Backend.DAL
{
    public class SQLBookingRepository : IBookingInterface
    {
        private readonly AppDbContext context;
        
        public SQLBookingRepository(AppDbContext context)
        { 
            this.context = context;
        }
        public async Task<ActionResult<Booking>?> GetBookingByPhoneNo(string phoneno)
        {

            var booking = await context.Booking
                        .Where(b => b.MobileNumber == phoneno)
                        .OrderByDescending(b => b.BookingDateAndTime)
                        .FirstOrDefaultAsync();

            if (booking == null)
            {
                return null;
            }
            return booking;
        }


        public async Task<ActionResult<Booking>?> GetBookingByEmail(string email)
        {

            var booking = await context.Booking
                .Where(b => b.EmailId == email)
                .OrderByDescending (b => b.BookingDateAndTime)
                .FirstOrDefaultAsync();

            if(booking == null)
            {
                return null;
            }
            return booking;
        }

        public async Task<ActionResult<Booking>> SaveInBooking(Booking booking)
        {
            context.Add(booking);
            await context.SaveChangesAsync();
            return booking;
            //throw new NotImplementedException();
        }

        public async Task<ActionResult<Booking>> GetBookingById(int id)
        {
            if (context.Booking == null)
            {
                return null;
            }

            var booking = await context.Booking.FindAsync(id);
            if (booking == null)
            {
                return null;
            }
            return booking;

            //throw new NotImplementedException();
        }
    }
}
