using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using CurriculumVitae.Data;
using QuestPDF.Helpers;

namespace CurriculumVitae.Services.Components
{
    public class AddressComponent : IComponent
    {

        private readonly Person _person;
        private readonly TextStyle _titleStyle;
        private readonly TextStyle _headerStyle;

        public AddressComponent(Person person, TextStyle titleStyle, TextStyle headerStyle)
        {

            _person = person;
            _titleStyle = titleStyle;
            _headerStyle = headerStyle; 
        }

        public void Compose(IContainer container)
        {
            var birthday = _person.Birthday.ToShortDateString();
            container.Padding(10).Column(column =>
            {
                column.Spacing(2);

                column.Item().BorderBottom(2).BorderColor(Colors.Pink.Accent4).PaddingBottom(5).Text($"{_person.FirstName} {_person.LastName}").Style(_titleStyle);

                column.Item().Text($"*{birthday}").Italic(true).Style(_headerStyle);
                column.Item().Text($"{_person.Address.Street} {_person.Address.Housenumber}").Style(_headerStyle);
                column.Item().Text($"{_person.Address.City} {_person.Address.Postcode}").Style(_headerStyle);
                column.Item().Text($"{_person.Contact.MailAddress}").Style(_headerStyle);
                column.Item().Text($"{_person.Contact.Phonenumber}").Style(_headerStyle);

            });
        }
    }
}
