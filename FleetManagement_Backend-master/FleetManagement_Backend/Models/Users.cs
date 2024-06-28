using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SQLite;

namespace FleetManagement_Backend.Models
{
    public class Users
    {
       
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int UserId { get; set; }

            public string? FirstName { get; set; }
            public string? LastName { get; set; }

            [Unique]
            public string? MobileNumber { get; set; }

            [Unique]
            [EmailAddress]
            public string? EmailId { get; set; }

            public string? Address { get; set; }

            public string? Password { get; set; } // Note: In a real-world application, you'd never store passwords as plain text. Instead, you'd store a hashed and salted version.

            [Unique]
            public string? DlNo { get; set; }

            [Unique]
            public long? AadharNo { get; set; }

            [Unique]
            public long? PassportNo { get; set; }

            public int? IsRegisteredUser { get; set; }
            public int? IsEmployee { get; set; }

            // Foreign Key for State
            public int? StateId { get; set; }
            [ForeignKey("StateId")]
            public virtual State? State { get; set; } // 'virtual' keyword for lazy loading in EF Core

            // Foreign Key for City
            public int? CityId { get; set; }
            [ForeignKey("CityId")]
            public virtual City? City { get; set; }

            // Foreign Key for Hubs
            public int? HubId { get; set; }
            [ForeignKey("HubId")]
            public virtual Hubs? Hubs { get; set; } // Note: Ideally, a single hub should probably be named "Hub" instead of "Hubs".
        }
    }


