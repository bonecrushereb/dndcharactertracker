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
    public async Task<ActionResult<List<Character>>> GetCharacters() {
        return await _mongoDBService.GetCharacters();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<List<Character>>> GetCharacter(string id, string characterId) {
        return await _mongoDBService.GetCharacter(id);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCharacter([FromBody] Character character) {
        await _mongoDBService.CreateCharacter(character);
        return CreatedAtAction(nameof(CreateCharacter), new { id = character.Id}, character);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> EditCharacter(string id, [FromBody] Character character) {
        try
        {
            if (id != character.Id) {
                return BadRequest("character id mismatch");
            }

            var characterToUpdate = await _mongoDBService.GetCharacter(id);

            if (characterToUpdate == null) {
                return NotFound($"Character with Id= {id} not found");
            }

            return await _mongoDBService.EditCharacter(character);
        }
        catch (System.Exception ex)
        {
             return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data");
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCharacter(string id) {
        await _mongoDBService.DeleteCharacter(id);
        return NoContent();
    }
 }
}