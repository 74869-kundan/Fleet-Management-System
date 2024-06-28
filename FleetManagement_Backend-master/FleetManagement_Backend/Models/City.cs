using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagement_Backend.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }

        public string? CityName { get; set; }

        [ForeignKey("State")]
        public int? StateId { get; set; }

        public virtual State? State { get; set; } 

        public virtual ICollection<Hubs>? Hubs { get; set; }
        public virtual ICollection<Booking>? Bookings { get; set; }
        public virtual ICollection<Users>? Users { get; set; }

    }
}
