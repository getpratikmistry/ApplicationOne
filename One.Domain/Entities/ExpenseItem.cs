using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class ExpenseItem
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        public int ExpenseId { get; set; }

        [ForeignKey("ExpenseId")]
        public virtual Expense? Expense { get; set; }

        [Required]
        [StringLength(100)]
        public string Itemname { get; set; }

        [Required]
        public int UnitId { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal Quantity { get; set; }  // Changed from int to decimal to match Column type

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal PPU { get; set; }

        public int? CreatedBy { get; set; }  // Removed [Required] since it's nullable

        [Required]
        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }  // Removed [Required] since it's nullable

        public DateTime? UpdatedDate { get; set; }  // Removed [Required] since it's nullable

        public int? Flag { get; set; }

        public ExpenseItem()
        {
            Itemname = string.Empty;
            Quantity = 0;
            CreatedDate = DateTime.Now;
        }
    }
}
