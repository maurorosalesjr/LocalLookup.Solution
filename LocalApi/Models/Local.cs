using System.ComponentModel.DataAnnotations;

namespace LocalApi.Models
{
    public class Local
    {
        public int LocalId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Location { get; set; }
        [Required]
        [StringLength(50)]
        public string Cuisine { get; set; }
        [Required]
        [StringLength(1000)]
        public string Blerb { get; set; }
        [Required]
        [Range(0, 10, ErrorMessage = "We use a one to ten scale in these parts")]
        public int Rating { get; set; }
    }
}