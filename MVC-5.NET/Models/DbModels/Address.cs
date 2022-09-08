using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_5.NET.Models.DbModels
{
    public class Address
    {
        [Key,ForeignKey("User")]
        public string UserId { get; set; }
        public string StreetName { get; set; }
        public int PostalCode { get; set; }
        public ApplicationUser User { get; set; }

    }
}