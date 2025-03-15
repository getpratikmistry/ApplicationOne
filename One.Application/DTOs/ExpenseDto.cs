using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Application.Dto
{
    public class ExpenseDto
    {
        public int ExpenseId { get; set; }
        public DateTime ExpenseDate { get; set; }
        public int CompanyId { get; set; }
        public string Location { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal SubTotalAmount { get; set; }
        public decimal NetAmount { get; set; }
        public bool? IsAmountModified { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<ExpenseItemDto> ExpenseItems { get; set; } // Navigation property

        public ExpenseDto()
        {
            ExpenseItems = new HashSet<ExpenseItemDto>();
            Location = string.Empty;
            ExpenseDate = DateTime.Now;
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }
    }
}
