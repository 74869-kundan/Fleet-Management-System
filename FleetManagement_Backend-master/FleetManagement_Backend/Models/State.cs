using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagement_Backend.Models
{
    public class State
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StateId { get; set; }

        //[Column("State_Name")]
        public string? StateName { get; set; }
        
        public ICollection<City>? Cities { get; set; }

        public ICollection<Booking>? Bookings { get; set; }
        public ICollection<Users>? Users { get; set; }
    }
}
