using System.ComponentModel.DataAnnotations;

namespace Net6MVC.Models.Entity
{
    public class TblCompany
    {
        [Key]
        [Required]
        [Display(Name="Serial No")]
        public Guid Guid { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Account")]
        [StringLength(50)]
        public string Account { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Password")]
        [StringLength(512)]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Description")]
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;

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
