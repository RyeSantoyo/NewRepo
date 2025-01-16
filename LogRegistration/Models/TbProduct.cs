using System.ComponentModel.DataAnnotations;

namespace LogRegistration.Models
{
    public class TbProduct
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name ="Product Name")] //Product
        public string? ProductName { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name = "Product Key")] //Product Key
        public string? ProductKey { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name = "Product Category")]
        public string? Category { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name = "Serial Number")]
        public string? SerialNumber { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name = "Description")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name = "Price")] //Price
        public double Price { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name = "Quantity")]//Quantity
        public int Quantity { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name = "UOM")]
        public string? UOM { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name ="Total Cost")]
        public double TotalCost { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name = "Cost per unit")] //Cost per unit
        public double CostPerUnit { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        [Display(Name = "Expected Gross Income")]
        public double GrossIncome { get; set; }
        [Required(ErrorMessage ="This is a required field.")]
        [Display(Name = "Income After Cost")]
        public double TotalIncome { get; set; }

       // [Display(Name ="Status")]
        //public Status? Status { get; set; } 
    }
}