using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Countries.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="char")]
        [StringLength(2)]
        public string CountryCode { get; set; }
        
        [Required]
        public string CountryName { get; set; }
    }
}
