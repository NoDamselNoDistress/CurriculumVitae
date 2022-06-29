using System.ComponentModel.DataAnnotations;

namespace CurriculumVitae.Data
{
    public class Education
    {
        [Required]
        public string Schoolname { get; set; }
        [Required]
        public DateTime BeginEducation { get; set; }
        public DateTime EndEducation { get; set; }
        public int Grade { get; set; }
        public TypOfDegree Degree { get; set; }
    }
}
