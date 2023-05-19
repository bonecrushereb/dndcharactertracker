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

        public CharacterController(MongoDBService mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }
    }

    [HttpGet]
    public async Task<ActionResult<List<Character>>> GetCharacter() {}
 }