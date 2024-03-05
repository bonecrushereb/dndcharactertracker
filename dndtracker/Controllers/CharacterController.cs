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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Character obj)
        {

            if(ModelState.IsValid) 
            {
                _db.Characters.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id==null || id==0)
            {
                return NotFound();
            }   
            Character characterFromDb = _db.Characters.FirstOrDefault();
            string[]? languages = characterFromDb.Languages;
            string[]? weapons = characterFromDb.Weapons;    
            if(characterFromDb == null)
            {
                return NotFound();
            }
            Console.WriteLine(languages);
            // if(characterFromDb.Languages != null) {
            //     return  languages = string.Join(", ", characterFromDb.Languages);
            // } else if(characterFromDb.Weapons != null) {
            //     return  weapons = string.Join(", ", characterFromDb.Weapons);
            // }
            return View(characterFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Character obj)
        {
            if(ModelState.IsValid) 
            {
                _db.Characters.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if(id==null || id==0)
            {
                return NotFound();
            }
            Character characterFromDb = _db.Characters.Find(id);
            if(characterFromDb == null)
            {
                return NotFound();
            }
            return View(characterFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Character? obj = _db.Characters.Find(id);
            if(obj == null) 
            {
                return NotFound();
            }
            _db.Characters.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}