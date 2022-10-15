using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net6MVC.Models.Entity
{
    public class TblItem
    {
        [Key]
        [Required]
        [Display(Name = "Serial No")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Guid CompanyGuid { get; set; }

        [Display(Name = "Barcode")]
        public string Barcode { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;        

        [Display(Name = "Name")]
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Inventory")]
        public double Inventory { get; set; } = 0;

        [Display(Name = "Costprice")]
        public double Costprice { get; set; } = 0;

        /// <summary>
        /// Y:Open N:Close 
        /// </summary>
        [Required]
        [StringLength(1)]
        public string Status { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Create Date")]
        public DateTime CreateTime { get; set; }

        [Display(Name = "Modify Date")]
        public DateTime ModifyTime { get; set; }

    }
}
