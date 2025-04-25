using PhoneBook.PersonService.PhoneBook.PersonService.Models;

namespace PhoneBook.PersonService.Models
{
    public class Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }

        // Navigation property for contact info
        public ICollection<ContactInfo> ContactInfos { get; set; }
    }
}
