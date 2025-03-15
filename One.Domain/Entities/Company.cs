using System.ComponentModel.DataAnnotations;

namespace One.Domain.Entities
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        public Company()
        {
            CompanyName = string.Empty;
            Location = string.Empty;
        }
    }
}
