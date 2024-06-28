using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FleetManagement_Backend.Models
{
    public class Billing
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillingId { get; set; }

        public string? StaffName { get; set; }
        public string? UserName { get; set; }
        public string? UserEmailId { get; set; }
        public string? CustomerMobileNo { get; set; }
        public string? CustomerAadharNo { get; set; }
        public string? CustomerPassNo { get; set; }
        public double? BillAmount { get; set; }
        public string? FuelStatus { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CategoryId { get; set; }

        [ForeignKey("Car")]
        public int? CarId { get; set; }
        public virtual Car? Car { get; set; }

        [ForeignKey("Booking")]
        public int? BookingId { get; set; }
        public virtual Booking? Booking { get; set; }

        [ForeignKey("Hubs")]
        public int? PickupHubId { get; set; }
        public virtual Hubs? PickupHub { get; set; }

        [ForeignKey("Hubs")]
        public int? DropHubId { get; set; }
        public virtual Hubs? DropHub { get; set; }

        public override string ToString()
        {
            return "Billing [BillingId=" + BillingId + ", StaffName=" + StaffName + ", UserName=" + UserName
                + ", UserEmailId=" + UserEmailId + ", CustomerMobileNo=" + CustomerMobileNo + ", CustomerAadharNo="
                + CustomerAadharNo + ", CustomerPassNo=" + CustomerPassNo + ", BillAmount=" + BillAmount
                + ", FuelStatus=" + FuelStatus + ", StartDate=" + StartDate + ", EndDate=" + EndDate + ", CategoryId="
                + CategoryId + ", Car=" + Car + ", Booking=" + Booking + ", PickupHub=" + PickupHub + ", DropHub="
                + DropHub + "]";
        }
    }
}
