using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FleetManagement_Backend.DAL.BillingComponent
{
    public class SQLBillingRepository : IBillingInterface
    {


        private readonly AppDbContext _context;

        public SQLBillingRepository(AppDbContext context)
        {

            _context = context;
        }
        public async Task<ActionResult<Billing>?> GetBillingByBookingId(int Id)
        {
            var billing = await _context.Billings
                .Include(b => b.Booking)
                .Where(b => b.BookingId == Id)
                .FirstOrDefaultAsync();

            if (billing == null)
            {
                return null;
            }
            return billing;
        }

        public async Task<ActionResult<Billing>?> GetBillingById(int billingid)
        {
            if (_context.Billings == null)
            {
                return null;
            }

            var billing = await _context.Billings.FindAsync(billingid);
            if (billing == null)
            {
                return null;
            }
            return billing;
        }

        public async Task<ActionResult<Billing>> SaveBilling(Billing billing)
        {

            _context.Add(billing);
            await _context.SaveChangesAsync();
            return billing;

        }

        public async Task<ActionResult<Billing>?> GetBillingByUserEmailId(string userEmailId)
        {
            
        }
    }


}


