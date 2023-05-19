using Microsoft.AspNetCore.Mvc;
using dndCharacters.Services;

namespace Character.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
        private readonly MongoDBService _mongoDBService;

        public CharacterController(MongoDBService mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }
    }

    [HttpGet]
    public async Task<ActionResult<List<dndCharacters>>> GetCharacter() {}
 }