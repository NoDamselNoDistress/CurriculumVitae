using CurriculumVitae.Data;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Globalization;

namespace CurriculumVitae.Services.Components
{
    public class SchoolExperienceComponent : IComponent
    {
        private readonly Education _education;
        private readonly TextStyle _titleStyle;

        public SchoolExperienceComponent(Education education, TextStyle titleStyle)
        {

            _education = education;
            _titleStyle = titleStyle;
        }

        public void Compose(IContainer container)
        {
            var startEducation = _education.BeginEducation.ToShortDateString();
            var endEducation = _education.EndEducation.ToShortDateString();
            container.Padding(10).Column(column =>
            {
                column.Spacing(2);
                column.Item().BorderBottom(2).PaddingBottom(5).Text($"{_education.Degree} | {_education.Schoolname}").Style(_titleStyle);
                if (_education.EndEducation == DateTime.MinValue)
                {
                    
                    column.Item().Text($" Von {startEducation} bis -");

                }
                else
                {
                    column.Item().Text($" Von {startEducation} bis {endEducation}");
                }

                
            });
        }

    }
}

