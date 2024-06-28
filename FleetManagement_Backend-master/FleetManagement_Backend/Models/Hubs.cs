using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FleetManagement_Backend.Models
{
    public class Hubs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HubId { get; set; }

        public string? HubName { get; set; }

        public string? ContactNumber { get; set; }

        public string? Address { get; set; }

        [ForeignKey("City")]
        public int? CityId { get; set; }
        //why virtual
        public virtual City? City { get; set; }

        [ForeignKey("Airport")]
        public int? AirportId { get; set; }
        public virtual Airport? Airport { get; set; }
        public virtual ICollection<Car>? Cars { get; set; }
        public virtual ICollection<Users>? Users { get; set; }
    }
}
