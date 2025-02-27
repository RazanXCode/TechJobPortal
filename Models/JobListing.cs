using System.ComponentModel.DataAnnotations;

namespace TechJobPortal.Models
{
    public enum JobType
    {
        FullTime,
        PartTime,
        Remote,
        Contract
    }

    public class JobListing
    {

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string CompanyName { get; set; }

        public string Location { get; set; }

        [Required]
        public JobType JobType { get; set; }

        public DateTime PostedDate { get; set; } = DateTime.UtcNow;
    }

        public class JobListing
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;  // Default empty string

        [Required]
        public string CompanyName { get; set; } = string.Empty;  // Default empty string

        public string Location { get; set; } = string.Empty;  // Default empty string

        [Required]
        public JobType JobType { get; set; }

        public DateTime PostedDate { get; set; } = DateTime.UtcNow;
    }


}