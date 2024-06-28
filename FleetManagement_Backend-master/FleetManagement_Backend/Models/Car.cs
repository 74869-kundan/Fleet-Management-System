using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagement_Backend.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }

        public string? CarName { get; set; }

        public int? CarNumberplate { get; set; }

        public int? Capacity { get; set; }

        public string? FuelType { get; set; }

        public double? Milage { get; set; }

        public string? Color { get; set; }

        public int? Availability { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public virtual CarCategory? Category { get; set; }

        [ForeignKey("Hub")]
        public int? HubId { get; set; }

        public virtual Hubs? Hub { get; set; }

        public override string ToString()
        {
            return $"Car [CarId={CarId}, CarName={CarName}, CarNumberplate={CarNumberplate}, Capacity={Capacity}, FuelType={FuelType}, Milage={Milage}, Color={Color}, Availability={Availability}, Category={Category}, Hub={Hub}]";
        }
    }
}
