using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDDEMO.Models
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
