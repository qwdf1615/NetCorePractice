using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net6MVC.Models.Entity
{
    public class TblPurchase
    {
        [Key]
        [Required]
        [Display(Name = "Serial No")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Item Id")]
        public int ItemId { get; set; }

        [Required]
        [Display(Name = "Count")]
        public double Count { get; set; }

        [Required]
        [Display(Name = "Price")]
        public double Price { get; set; }

    }
}
