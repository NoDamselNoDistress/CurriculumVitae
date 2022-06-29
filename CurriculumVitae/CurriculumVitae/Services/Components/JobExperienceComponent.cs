using CurriculumVitae.Data;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Globalization;

namespace CurriculumVitae.Services.Components
{
    public class JobExperienceComponent : IComponent
    {


        private readonly JobExperience _job;
        private readonly TextStyle _titleStyle;

        public JobExperienceComponent(JobExperience job, TextStyle titleStyle)
        {

            _job = job;
            _titleStyle = titleStyle;
        }

        public void Compose(IContainer container)
        {
            var startJob = _job.BeginJob.ToShortDateString();
            var endJob = _job.EndJob.ToShortDateString();
                container.Padding(10).Column(column =>
                    {
                        column.Spacing(2);
                        column.Item().BorderBottom(2).PaddingBottom(5).Text($"{_job.Position} bei {_job.Company}").Style(_titleStyle);
                        if (_job.EndJob == DateTime.MinValue)
                        {
                            
                            column.Item().Text($" Von {startJob} bis -");

                        }
                        else
                        {
                            column.Item().Text($" Von {startJob} bis {endJob}");
                        }

                        column.Item().Text($"{_job.Describtion}");
                    });
            }

        }

    }

