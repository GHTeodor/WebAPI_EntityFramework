using Microsoft.AspNetCore.Mvc;
using WebAPI_EntityFramework.Models;

namespace WebAPI_EntityFramework.Controllers;

[ApiController]
[Route("[controller]")]
public class BuilderPatternController : ControllerBase
{
    HouseBuilder _houseBuilder = new HouseBuilder();

    [HttpGet]
    public Task<IActionResult> Get()
    {
        var newBuilder = _houseBuilder.addFloor().addRoom().build();
        Console.WriteLine(newBuilder);
        return Task.FromResult<IActionResult>(Ok(newBuilder));
    }
}