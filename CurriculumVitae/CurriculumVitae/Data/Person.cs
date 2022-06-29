using CurriculumVitae.ValidationModel;

namespace CurriculumVitae.Data
{
    public class Person
    {   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public Address Address { get; set; }
        public Contact Contact{ get; set; }
        public string? ImagePath { get; set; }
        public List<JobExperience> JobExperiences { get; set; }
        public List<Education> Educations { get; set; }

        

        public Person(PersonValidationModel _person, string _imgpath)
        {
            FirstName = _person.FirstName;
            LastName = _person.LastName;
            Birthday = _person.Birthday;
            Address = _person.Address;
            Contact = _person.Contact;
            JobExperiences = _person.JobExperiences;
            Educations = _person.Educations;
            if(_imgpath is not null)
            {
                ImagePath = _imgpath;
            }
            else
            {
                ImagePath = string.Empty;
            }

        }
    }

}
