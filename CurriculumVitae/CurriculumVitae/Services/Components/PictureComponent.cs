using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using CurriculumVitae.Data;
using QuestPDF.Helpers;

namespace CurriculumVitae.Services.Components
{
    public class PictureComponent : IComponent
    {
        private readonly string _imgPath;


        public PictureComponent(string imgPath)
        {

            _imgPath = imgPath;

        }

        public void Compose(IContainer container)
        {
            
            if (_imgPath is not null)
            {
                try
                { byte[] imageData = File.ReadAllBytes(_imgPath);
                    container.Image(imageData);
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }

            }
            else
            {
                container.Width(1);
            }


        }
    }
}
