using PhoneBook.PersonService.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PersonDbContext>(options =>
    options.UseInMemoryDatabase("PhoneBookDb"));

builder.Services.AddControllers();
