using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagement_Backend.Models
{
    public class Airport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AirportId { get; set; }

        public int? AirportCode { get; set; }

        public string? AirportName { get; set; }
    }
}
