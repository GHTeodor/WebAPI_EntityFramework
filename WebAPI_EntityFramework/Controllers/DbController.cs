using Microsoft.AspNetCore.Mvc;
using WebAPI_EntityFramework.Models;
using WebAPI_EntityFramework.Services;

namespace WebAPI_EntityFramework.Controllers;

[ApiController]
[Route("[controller]")]
public class DbController : ControllerBase
{
    IDbService _dbService;
    
    public DbController(IDbService dbService)
    {
        _dbService = dbService;
    }
    
    [HttpGet]
    public Task<IActionResult> Get()
    {
        Console.WriteLine("_______________-----__________________");
        Console.WriteLine(_dbService);
        return Task.FromResult<IActionResult>(Ok(_dbService.Get()));
    }
    
    [HttpGet("{id:int:min(1)}")]
    public Task<IActionResult> Get(int id)
    {
        
        return Task.FromResult<IActionResult>(Ok(_dbService.GetById(id)));
    }
    
    [HttpPost]
    public Task<IActionResult> Post([FromBody] Person person)
    {
        Person newPerson = _dbService.Post(person);
        return Task.FromResult<IActionResult>(Accepted(newPerson));
    }
    
    [HttpPatch("{id:int:min(1)}")]
    public Task<IActionResult> Patch([FromBody] Person person, int id)
    {
        Person updatedPerson = _dbService.Patch(person, id);
        return Task.FromResult<IActionResult>(Ok(updatedPerson));
    }
    
    [HttpDelete("{id:int:min(1)}")]
    public Task<IActionResult> DeleteById(int id)
    {
        _dbService.DeleteById(id);
        return Task.FromResult<IActionResult>(Ok(id));
    }
    
    // ContextDB _contextDb;
    // public DbController(ContextDB contextDb)
    // {
    //     _contextDb = contextDb;
    // }
    //
    // [HttpGet]
    // public async Task<IActionResult> Get()
    // {
    //     return Ok(_contextDb.Persons);
    // }
    // [HttpGet("{id:int}")]
    // public Task<IActionResult> Get(int id)
    // {
    //     return Task.FromResult<IActionResult>(Ok(_contextDb.Persons.Find(id)));
    // }
    //
    // [HttpPost]
    // public async Task<IActionResult> Post([FromBody] Person el)
    // {
    //     _contextDb.Persons.Add(el);
    //     _contextDb.SaveChanges();
    //     return Ok(el);
    // }
}