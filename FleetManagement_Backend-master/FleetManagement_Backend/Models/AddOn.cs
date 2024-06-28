using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FleetManagement_Backend.Models
{
    public class AddOn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddOnId { get; set; }

        public string? AddOnName { get; set; }

        public double? AddOnRate { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
