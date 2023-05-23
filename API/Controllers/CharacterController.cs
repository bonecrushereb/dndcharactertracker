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
    public async Task<IActionResult> CreateCharacter( Character character) {
        await _mongoDBService.CreateCharacter(character);
        return CreatedAtAction(nameof(CreateCharacter), new { id = character.Id}, character);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> EditCharacter(string id, [FromBody] string characterId) {
        await  _mongoDBService.EditCharacter(id, characterId);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCharacter(string id) {
        await _mongoDBService.DeleteCharacter(id);
        return NoContent();
    }
 }
}