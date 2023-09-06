
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class ProductVM
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("ProducNAME")]
        [MaxLength(8)]
        public string? ProducName { get; set; }
        [Required]
        [DisplayName("ProducPRICE")]
        public decimal? ProducPrice { get; set; }
        public int? ProducQuantity { get; set; }
        public string? CategoryName { get; set; }
    }
}
