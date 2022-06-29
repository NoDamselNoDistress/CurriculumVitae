using CurriculumVitae.Data;
using CurriculumVitae.Services.Components;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CurriculumVitae.Utilities
{
    public class CVDocument : IDocument
    {
        private Person _person { get; }
        

        public CVDocument(Person person)
        {
            _person = person;
            
        }
        public void Compose(IDocumentContainer container)
        {
            var header = new CVHeader(_person);
            var content = new CVContent(_person);
            

            container
                .Page(page =>
                {

                    page.Header().Element(header.ComposeHeader);
                    page.Content().Element(content.ComposeContent);
                    page.Footer().Height(50).Background(Colors.Black);
                });
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
    }


}
