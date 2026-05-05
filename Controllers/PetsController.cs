using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetCareAI.Data;
using PetCareAI.Models;

[ApiController]
[Route("api/[controller]")]
public class PetsController : ControllerBase
{
    private readonly AppDbContext _context;

    public PetsController(AppDbContext context) => _context = context;

    // GET: api/pets (Lista todos)
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pet>>> GetPets() => await _context.Pets.ToListAsync();

    // GET: api/pets/5 (Busca por ID) - Retorno 200 ou 404
    [HttpGet("{id}")]
    public async Task<ActionResult<Pet>> GetPet(int id)
    {
        var pet = await _context.Pets.FindAsync(id);
        return pet == null ? NotFound() : pet;
    }

    // POST: api/pets (Criação) - Retorno 201 Created
    [HttpPost]
    public async Task<ActionResult<Pet>> PostPet(Pet pet)
    {
        _context.Pets.Add(pet);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetPet), new { id = pet.Id }, pet);
    }

    // PUT: api/pets/5 (Atualização) - Retorno 204 ou 400
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPet(int id, Pet pet)
    {
        if (id != pet.Id) return BadRequest();
        _context.Entry(pet).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE: api/pets/5 (Remoção) - Retorno 204
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePet(int id)
    {
        var pet = await _context.Pets.FindAsync(id);
        if (pet == null) return NotFound();
        _context.Pets.Remove(pet);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}