using CurriculumVitae.Data;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CurriculumVitae.Services.Components
{
    public class CVContent
    {
        private readonly Person _person;

        public CVContent(Person person)
        {

            _person = person;

        }
        public void ComposeContent(IContainer container)
        {
            var titleStyle = TextStyle.Default.FontSize(20).SemiBold().FontColor(Colors.Pink.Accent4);
            container.PaddingVertical(10).Column(column =>
            {
                foreach (Education education in _person.Educations)
                {
                    column.Spacing(10);

                    column.Item()
                    .Background(Colors.Grey.Medium)
                    .Component(new SchoolExperienceComponent(education, titleStyle));
                }
                foreach (JobExperience job in _person.JobExperiences)
                {
                    column.Spacing(10);

                    column.Item()
                    .Background(Colors.Grey.Lighten1)
                    .Component(new JobExperienceComponent(job, titleStyle));
                }

            });
        }
    }
}
