using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using CurriculumVitae.Data;
using QuestPDF.Helpers;

namespace CurriculumVitae.Services.Components
{
    public class CVHeader
    {
        private readonly Person _person;
        

        public CVHeader(Person person)
        {

            _person = person;
            
        }

        public void ComposeHeader(IContainer container)
        {
            var titleStyle = TextStyle.Default.FontSize(20).SemiBold().FontColor(Colors.Pink.Accent4);
            var headerStyle = TextStyle.Default.FontSize(16).FontColor(Colors.White);

            container
                .Height(200)
                .Background(Colors.Black)
                .BorderBottom(4)
                .BorderColor(Colors.Pink.Accent4)
                .Row(row =>
                {
                    row.RelativeItem().Component(new AddressComponent(_person, titleStyle, headerStyle));
                    row.Spacing(10);
                    row.ConstantItem(150).Width(100).Height(150).PaddingTop(10).AlignRight().Component(new PictureComponent(_person.ImagePath));
                    //row.ConstantItem(150).Width(100).Height(150).AlignRight().Placeholder();
                });
            
            

        }

    }

    
    

}

