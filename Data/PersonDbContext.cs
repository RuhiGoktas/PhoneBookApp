using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PhoneBook.PersonService.Models;
using PhoneBook.PersonService.PhoneBook.PersonService.Models;

namespace PhoneBook.PersonService.Data
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
    }
}
