using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }
        [Required]
        public DateTime ExpenseDate { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal Tax { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal TaxAmount { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Discount { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal SubTotalAmount { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal NetAmount { get; set; }
        public bool? IsAmountModified { get; set; }
        [Required]
        public int? CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public int? UpdatedBy { get; set; }
        [Required]
        public DateTime UpdatedDate { get; set; }

        [Required]
        public ICollection<ExpenseItem> ExpenseItems { get; set; } // Navigation property

        public Expense()
        {
            ExpenseItems = new HashSet<ExpenseItem>();
            Location = string.Empty;
            ExpenseDate = DateTime.Now;
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }
    }
}
