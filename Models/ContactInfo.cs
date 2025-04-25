using PhoneBook.PersonService.Models;

namespace PhoneBook.PersonService
{
    namespace PhoneBook.PersonService.Models
    {
        public class ContactInfo
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public string Type { get; set; } // e.g. "Phone", "Email", "Location"
            public string Value { get; set; }

            public Guid PersonId { get; set; }
            public Person Person { get; set; }
        }
    }

}
