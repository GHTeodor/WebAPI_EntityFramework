namespace WebAPI_EntityFramework.Models;

public interface IDbService
{
    public IEnumerable<Person> Get();
    public Person GetById(int id);    
    public Person Post(Person person);
    public Person Patch(Person person, int id);
    public void DeleteById(int id);
}