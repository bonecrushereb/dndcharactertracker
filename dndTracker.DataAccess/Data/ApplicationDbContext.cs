using dndTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace dndTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    Id=1,
                    Name="HÜND",
                    Sex= "Male",
                    Race="Half-Elf",
                    Class="Rogue",
                    Level=11,
                    Strength=11,
                    Dexterity=20,
                    Constitution=16,
                    Intelligence=11,
                    Wisdom=13,
                    Charisma=16,
                    ProfBonus=4,
                    WalkSpeed=40,
                    CurrentHealth=70,
                    FullHealth=91,
                    TempHealth=0,
                    Armor="Leather",
                    Weapons=["crossbow", "hand", "longsword", "rapier", "shortsword", "simple weapons"],
                    Tools=["Smith's Tools", "Thieves' Tools"],
                    Languages=["Common", "Dwarvish", "Elvish", "Orc", "Thieves’ Cant"],
                    Background="test",
                    Alignment="Neutral Good",
                    Faith="none",
                    LifeStyle="Rich",
                    HairStyle="long and curly",
                    SkinColor="Pale White",
                    Height=63,
                    Weight=120,
                    Age=50,
                    PersonalityTrait="test",
                    Ideals="test",
                    Bonds="test",
                    Flaws="test",
                    Organizations="test",
                    Allies="test",
                    Enemies="test",
                    BackStory="test"
                }
            );
        }
    }
}