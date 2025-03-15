using System.ComponentModel.DataAnnotations;

namespace One.Application.Dto
{
    public class CompanyDto
    {
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }
        public string Location { get; set; }

        public CompanyDto()
        {
            CompanyName = string.Empty;
            Location = string.Empty;
        }
    }
}
