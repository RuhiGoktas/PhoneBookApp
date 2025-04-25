using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneBook.PersonService.Data;
using PhoneBook.PersonService.Models;
using PhoneBook.PersonService.PhoneBook.PersonService.Models;

namespace PhoneBook.PersonService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactInfoController : ControllerBase
    {
        private readonly PersonDbContext _context;

        public ContactInfoController(PersonDbContext context)
        {
            _context = context;
        }

        [HttpPost("{personId}")]
        public IActionResult AddContact(Guid personId, [FromBody] ContactInfo contactInfo)
        {
            var person = _context.Persons.Include(p => p.ContactInfos).FirstOrDefault(p => p.Id == personId);
            if (person == null) return NotFound("Person not found.");

            contactInfo.PersonId = personId;
            _context.ContactInfos.Add(contactInfo);
            _context.SaveChanges();

            return Ok(contactInfo);
        }

        [HttpDelete("{contactId}")]
        public IActionResult RemoveContact(Guid contactId)
        {
            var contact = _context.ContactInfos.Find(contactId);
            if (contact == null) return NotFound("Contact not found.");

            _context.ContactInfos.Remove(contact);
            _context.SaveChanges();

            return NoContent();
        }
        [HttpGet("{id}")]
        public IActionResult GetPersonById(Guid id)
        {
            var person = _context.Persons
                .Include(p => p.ContactInfos)
                .FirstOrDefault(p => p.Id == id);

            if (person == null) return NotFound();

            return Ok(person);
        }
    }
}
