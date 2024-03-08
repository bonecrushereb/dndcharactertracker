using dndTracker.DataAccess.Data.Repository.IRepository;
using dndTracker.Models;

namespace dndTracker.DataAccess.Data.Repository
{
    public class CharacterRepository : Repository<Character>, ICharacterRepository
    {
        private ApplicationDbContext _db;

        public CharacterRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Character obj)
        {
            var objFromDb = _db.Characters.FirstOrDefault(u => u.Id ==  obj.Id);
            if(objFromDb != null) {
                objFromDb.Name = obj.Name;
                objFromDb.Sex = obj.Sex;
                objFromDb.Race = obj.Race;
                objFromDb.Class = obj.Class;
                objFromDb.Level = obj.Level;
                objFromDb.Strength = obj.Strength;
                objFromDb.Dexterity = obj.Dexterity;
                objFromDb.Constitution = obj.Constitution;
                objFromDb.Intelligence = obj.Intelligence;
                objFromDb.Wisdom = obj.Wisdom;
                objFromDb.Charisma = obj.Charisma;
                objFromDb.ProfBonus = obj.ProfBonus;
                objFromDb.WalkSpeed = obj.WalkSpeed;
                objFromDb.CurrentHealth = obj.CurrentHealth;
                objFromDb.FullHealth = obj.FullHealth;
                objFromDb.TempHealth = obj.TempHealth;
                objFromDb.Armor = obj.Armor;
                objFromDb.Weapons = obj.Weapons;
                objFromDb.Tools = obj.Tools;
                objFromDb.Languages = obj.Languages;
                objFromDb.Background = obj.Background;
                objFromDb.Alignment = obj.Alignment;
                objFromDb.Faith = obj.Faith;
                objFromDb.LifeStyle = obj.LifeStyle;
                objFromDb.HairStyle = obj.HairStyle;
                objFromDb.SkinColor = obj.SkinColor;
                objFromDb.EyeColor = obj.EyeColor;
                objFromDb.Weight = obj.Weight;
                objFromDb.Height = obj.Height;
                objFromDb.Age = obj.Age;
                objFromDb.PersonalityTrait = obj.PersonalityTrait;
                objFromDb.Ideals = obj.Ideals;
                objFromDb.Bonds = obj.Bonds;
                objFromDb.Flaws = obj.Flaws;
                objFromDb.Organizations = obj.Organizations;
                objFromDb.Allies = obj.Allies;
                objFromDb.Enemies = obj.Enemies;
                objFromDb.BackStory = obj.BackStory;    
            }
        }
    }
}