using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Application.Dto
{
    public class ExpenseItemDto
    {
        public int ItemId { get; set; }

        public int ExpenseId { get; set; }

        public virtual ExpenseDto? Expense { get; set; }
        public string Itemname { get; set; }

        public int UnitId { get; set; }

        public decimal Quantity { get; set; }  // Changed from int to decimal to match Column type

        public decimal Amount { get; set; }

        public decimal PPU { get; set; }

        public int? CreatedBy { get; set; }  // Removed [Required] since it's nullable

        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }  // Removed [Required] since it's nullable

        public DateTime? UpdatedDate { get; set; }  // Removed [Required] since it's nullable

        public int? Flag { get; set; }

        public ExpenseItemDto()
        {
            Itemname = string.Empty;
            Quantity = 0;
            CreatedDate = DateTime.Now;
        }
    }
}
