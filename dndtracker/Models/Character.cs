using System.ComponentModel.DataAnnotations;

namespace dndTracker.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Sex { get; set; }
        [Required]
        public string? Race { get; set; }
        [Required]
        public string? Class { get; set; }
        public int Level { get; set; }

        [Required]
        public int Strength { get; set; }
        [Required]
        public int Dexterity { get; set; }
        [Required]
        public int Constitution { get; set; }
        [Required]
        public int Intelligence { get; set; }
        [Required]
        public int Wisdom { get; set; }
        [Required]
        public int Charisma { get; set; }
        [Required]
        public int ProfBonus { get; set; }
        [Required]
        public int WalkSpeed { get; set; }

        [Required]
        public int CurrentHealth { get; set; }
        [Required]
        public int FullHealth { get; set; }
        public int TempHealth { get; set; }

        public string? Armor { get; set; }
        public string[]? Weapons { get; set; }
        public string[]? Tools { get; set; }
        public string[]? Languages { get; set; }

        public string? Background { get; set; }
        public string? Alignment { get; set; }
        public string? Faith { get; set; }
        public string? LifeStyle { get; set; }

        public string? HairStyle { get; set; }
        public string? SkinColor { get; set; }
        public string? EyeColor { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }

        public string? PersonalityTrait { get; set; }
        public string? Ideals { get; set; }
        public string? Bonds { get; set; }
        public string? Flaws { get; set; }

        public string? Organizations { get; set; }
        public string? Allies { get; set; }
        public string? Enemies { get; set; }
        public string? BackStory { get; set; }

    }
}