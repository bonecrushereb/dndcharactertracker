using System;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using API.Models;

namespace API.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
    private readonly MongoDBService _mongoDBService;

    public CharacterController(MongoDBService mongoDBService) {
        _mongoDBService = mongoDBService;
    }
    [HttpGet]
    public async Task<List<Character>> Get() =>
        await _mongoDBService.GetAsync();

    [HttpGet("{id}")]
    public async Task<ActionResult<Character>> Get(string id)
    {
        var character = await _mongoDBService.GetAsync(id);

        if (character is null)
        {
            return NotFound();
        }

        return character;
    }

    [HttpPost]
    public async Task<IActionResult> Post(Character newCharacter)
    {
        await _mongoDBService.CreateAsync(newCharacter);

        return CreatedAtAction(nameof(Get), new { id = newCharacter.Id }, newCharacter);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] Character updatedCharacter)
    {
        var character = await _mongoDBService.GetAsync(id);
        
        if (character is null)
        {
            return NotFound($"character with id = {id} not found");
        }

        updatedCharacter.Id = character.Id;

        await _mongoDBService.UpdateAsync(id, updatedCharacter);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var character = await _mongoDBService.GetAsync(id);

            if (character is null)
            {
                return NotFound();
            }

            await _mongoDBService.RemoveAsync(id);

            return NoContent();
        }
    }
}