using CurriculumVitae.Data;
using System.ComponentModel.DataAnnotations;
namespace CurriculumVitae.ValidationModel
{
    public class PersonValidationModel
    {
        [Required]
        public string FirstName { get; set; } 
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        public string? PictureUri { get; set; }
        [ValidateComplexType]
        public List<Education> Educations { get; set; } = new();
        [ValidateComplexType]
        public List<JobExperience> JobExperiences { get; set; } = new();
        [ValidateComplexType]
        public Contact Contact { get; set; } = new();
        [ValidateComplexType]
        public Address Address { get; set; } = new();
        
    }
}
