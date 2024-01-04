using dndTracker.Data;
using dndTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace dndTracker.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CharacterController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Character> characterList = _db.Characters.ToList();
            return View(characterList);
        }
    }
}