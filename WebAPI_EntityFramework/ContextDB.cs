using Microsoft.EntityFrameworkCore;
using WebAPI_EntityFramework.Models;

namespace WebAPI_EntityFramework;

public class ContextDB : DbContext
{
    public ContextDB(DbContextOptions<ContextDB> options) : base(options)
    {
        
    }

    public DbSet<Person> Persons { get; set; }
}