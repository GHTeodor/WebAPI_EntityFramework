using Microsoft.EntityFrameworkCore;
using WebAPI_EntityFramework.Models;

namespace WebAPI_EntityFramework.Services;

public class DbService : IDbService
{
    ContextDB _contextDb;

    public DbService(ContextDB contextDb)
    {
        _contextDb = contextDb;
    }

    public IEnumerable<Person> Get()
    {
        return _contextDb.Persons;
    }
    
    public Person GetById(int id)
    {
        return _contextDb.Persons.FirstOrDefaultAsync(p => p.Id == id).Result;
        // return _contextDb.Persons.Find(id)!;
    }
    
    public Person Post(Person person)
    {
        person.UpdatedAt = null;
        _contextDb.Persons.Add(person);
        _contextDb.SaveChangesAsync();
        return person;
    }

    public Person Patch(Person person, int id)
    {
        var pers = GetById(id);
        pers.Name = person.Name;
        pers.SurName = person.SurName;
        pers.CreatedAt = person.CreatedAt;
        _contextDb.SaveChangesAsync();
        return pers;
    }

    public void DeleteById(int id)
    {
        _contextDb.Persons.Remove(GetById(id));
        _contextDb.SaveChangesAsync();
    }
}