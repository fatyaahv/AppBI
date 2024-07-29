using System.ComponentModel.DataAnnotations;

namespace AppBI.Models
{
    public class JobListing
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime PostedDate { get; set; }
    }
}
