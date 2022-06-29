using CurriculumVitae.Data;
using QuestPDF.Fluent;
using System.Diagnostics;

namespace CurriculumVitae.Utilities
{
    public class PDFBuilder
    {
        public void GenerateLocal(Person person)
        {
            var filePath = "CurriculumVitae.pdf";
            
            var document = new CVDocument(person);
            document.GeneratePdf(filePath);
            Process.Start("explorer.exe", filePath);
            

        }
        public Stream GenerateStream(Person person)
        {
            
            var document = new CVDocument(person);

            var stream = new MemoryStream();
            document.GeneratePdf(stream);

            return stream;
        }


    }
}
