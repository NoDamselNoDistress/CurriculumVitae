using System.ComponentModel.DataAnnotations;
namespace CurriculumVitae.Data
{
    public class JobExperience
    {
        [Required]
        public string Company { get; set; }
        [Required]
        public string Position { get; set; }
        
        public string? Describtion { get; set; }

        [Required]
        public DateTime BeginJob { get; set; }
        public DateTime EndJob { get; set; }
    }
}
