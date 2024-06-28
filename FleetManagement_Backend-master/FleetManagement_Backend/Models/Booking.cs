using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FleetManagement_Backend.Models
{
    public class Booking
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }

        [Required]
        public DateTime? BookingDateAndTime { get; set; }

        [Required, MaxLength(50)]
        public string? FirstName { get; set; }

        [Required, MaxLength(50)]
        public string? LastName { get; set; }

        [Required, MaxLength(15)]
        public string? MobileNumber { get; set; }

        [Required, MaxLength(100)]
        public string? EmailId { get; set; }

        [MaxLength(50)]
        public string? DLNumber { get; set; }

        [MaxLength(20)]
        public string? AadharNo { get; set; }

        [MaxLength(20)]
        public string? PassportNo { get; set; }

        // User - considering UserId as just an integer without a navigation property as per your Java class
        public int? UserId { get; set; }

        // Relationship with State
        [ForeignKey("State")]
        public int? StateId { get; set; }
        public virtual State? State { get; set; }

        // Relationship with City
        [ForeignKey("City")]
        public int? CityId { get; set; }
        public virtual City? City { get; set; }

        // Relationship with CarCategory
        [ForeignKey("CarCategory")]
        public int? CategoryId { get; set; }
        public virtual CarCategory? CarCategory { get; set; }

        // Since you mentioned PickupHubId and DropHubId as just integer fields, I'm leaving them as is.
        public int? PickupHubId { get; set; }
        public int? DropHubId { get; set; }

        // ToString override if you need it
        public override string ToString()
        {
            return $"Booking [bookingId={BookingId}, bookingDateAndTime={BookingDateAndTime}, firstName={FirstName}, " +
                   $"lastName={LastName}, mobileNumber={MobileNumber}, emailId={EmailId}, DLNumber={DLNumber}, " +
                   $"aadharNo={AadharNo}, passportNo={PassportNo}, userId={UserId}, state={State}, city={City}, " +
                   $"pickupHubId={PickupHubId}, dropHubId={DropHubId}, category={CarCategory}]";
        }
    }
}
