using System.ComponentModel.DataAnnotations;

namespace AppBI.Models
{
    public class JobApplication
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string PositionApplied { get; set; }

        public IFormFile Resume { get; set; }

        [Required]
        public string CoverLetter { get; set; }
    }
}
