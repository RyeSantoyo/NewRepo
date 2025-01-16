using System.ComponentModel.DataAnnotations;

namespace LogRegistration.Models
{
    public class ReceivingReport
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string? ProductName { get; set; }

        [Required]
        [Display(Name = "Purchase Order")]
        public int PurchaseOrder { get; set; }

        [Required]
        [Display(Name = "Supplier")]
        public string? Supplier { get; set; }

        [Required]
        [Display(Name = "UOM")]
        public string? UOM { get; set; }

        [Required]
        [Display(Name ="Quantity")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Date Received")]
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
