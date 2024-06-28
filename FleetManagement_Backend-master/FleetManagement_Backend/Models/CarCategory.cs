using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagement_Backend.Models
{
    [Table("CarCategory")] 
    public class CarCategory
    {
        [Key]
        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }

        public string? ImgPath { get; set; }

        public double? DailyRates { get; set; }

        public double? WeeklyRates { get; set; }

        public double? MonthlyRates { get; set; }

        public override string ToString()
        {
            return $"CarCategory [CategoryId={CategoryId}, CategoryName={CategoryName}, ImgPath={ImgPath}, DailyRates={DailyRates}, WeeklyRates={WeeklyRates}, MonthlyRates={MonthlyRates}]";
        }

        public virtual ICollection<Car>? Cars { get; set; }
        public virtual ICollection<Booking>? Bookings { get; set; }

    }
}
