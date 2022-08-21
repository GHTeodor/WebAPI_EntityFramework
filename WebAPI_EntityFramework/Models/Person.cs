namespace WebAPI_EntityFramework.Models;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}