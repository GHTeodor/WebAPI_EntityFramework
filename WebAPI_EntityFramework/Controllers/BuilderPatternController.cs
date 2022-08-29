using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebAPI_EntityFramework.Models;

namespace WebAPI_EntityFramework.Controllers;

[ApiController]
[Route("[controller]")]
public class BuilderPatternController : ControllerBase
{
    HouseBuilder _houseBuilder = new HouseBuilder();
    private readonly AppSettings _appSettings;

    public BuilderPatternController(IOptions<AppSettings> appSettings)
    {
        _appSettings = appSettings.Value;
    }

    [HttpGet]
    [EnableCors("TestPolicy")]
    public Task<IActionResult> Get()
    {
        Console.WriteLine(_appSettings.UK);

        var newBuilder = _houseBuilder.addFloor().addRoom().build();
        return Task.FromResult<IActionResult>(Ok(newBuilder));
    }
}