using System.ComponentModel.DataAnnotations;

namespace WebAPI_EntityFramework.Models;

public class House// : HouseBuilder
{
    public int Id { get; set; }
    
    [Range(0, Int32.MaxValue)]
    public int Rooms { get; set; } = 2;

    [Range(0, Int32.MaxValue)]
    public int Floor { get; set; } = 1;


}