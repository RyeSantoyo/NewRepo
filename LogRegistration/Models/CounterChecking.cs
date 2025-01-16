using System.ComponentModel.DataAnnotations;

namespace LogRegistration.Models
{
    public class CounterChecking
    {
      
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string? ProductName { get; set; }
        public ReceivingReport? ReceivingReport { get; set; }
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
        [Display(Name = "Quantity")]
        public double Quantity { get; set; }

        [Display(Name = "Total Cost")]
        public double TotalCost { get; set; }

        [Required]
        [Display(Name = "Date Received")]
        public DateTime DateTime { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Date Received")]
        public DateTime DateChecked { get; set; } = DateTime.Now;
    }
}
