using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestServer.Models;

namespace RestServer.Controllers
{
  [Route("api/")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly RestServerContext _db;

    public AnimalsController(RestServerContext db)
    {
      _db = db;
    }

    private bool AnimalExists(int id) => _db.Animals.Any(a => a.Id == id);

    private async Task<Animal> AnimalWithId(int id) => await _db.Animals.FindAsync(id);

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> GetAllAnimals()
    => await _db.Animals.ToListAsync();

    [HttpGet("animals/{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    => await AnimalWithId(id);


    
    [HttpPost("animals/")]
    public async Task<ActionResult<Animal>> PostAnimal(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(AnimalWithId), new { id = animal.Id }, animal);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal a)
    {
      if (id != a.Id) return BadRequest();
      _db.Entry(a).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id)) return NotFound();
        else throw;
      }
      return NoContent();
    }

    [HttpDelete("animal/{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      if (await AnimalWithId(id) is not Animal a) return NotFound();
      _db.Animals.Remove(a);
      await _db.SaveChangesAsync();
      return NoContent();
    }
  }
}
