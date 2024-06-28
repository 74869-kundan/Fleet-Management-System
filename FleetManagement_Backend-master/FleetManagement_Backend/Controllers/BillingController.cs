using FleetManagement_Backend.DAL.BillingComponent;
using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingController : ControllerBase
    {
         private readonly IBillingInterface _billingInterface;


        public BillingController(IBillingInterface billingInterface)
        {
            _billingInterface = billingInterface;
        }



        [HttpGet("billingbybookingId/{id}")]
        public async Task<ActionResult<Billing>> GetBillingByBookingId(int id)
        {
            var billing = await _billingInterface.GetBillingByBookingId(id);

            return billing == null ? NotFound() : billing;

        }

        [HttpGet("byBillingId/{billingid:int}")]
        public async Task<ActionResult<Billing>> GetBillingById(int billingid)
        {
            var billing = await _billingInterface.GetBillingById(billingid);

            return billing == null ? NotFound() : billing;
        }



        [HttpPost]
        public async Task<ActionResult<Billing>?> SaveBilling(Billing billing)
        {
            await _billingInterface.SaveBilling(billing);

            return CreatedAtAction("GetBillingById", new { id = billing.BillingId }, billing);
        }



    }
}
