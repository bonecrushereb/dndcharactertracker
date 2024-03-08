using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace dndTracker.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCharacterToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Sex = table.Column<string>(type: "text", nullable: true),
                    Race = table.Column<string>(type: "text", nullable: false),
                    Class = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Strength = table.Column<int>(type: "integer", nullable: false),
                    Dexterity = table.Column<int>(type: "integer", nullable: false),
                    Constitution = table.Column<int>(type: "integer", nullable: false),
                    Intelligence = table.Column<int>(type: "integer", nullable: false),
                    Wisdom = table.Column<int>(type: "integer", nullable: false),
                    Charisma = table.Column<int>(type: "integer", nullable: false),
                    ProfBonus = table.Column<int>(type: "integer", nullable: false),
                    WalkSpeed = table.Column<int>(type: "integer", nullable: false),
                    CurrentHealth = table.Column<int>(type: "integer", nullable: false),
                    FullHealth = table.Column<int>(type: "integer", nullable: false),
                    TempHealth = table.Column<int>(type: "integer", nullable: false),
                    Armor = table.Column<string>(type: "text", nullable: true),
                    Weapons = table.Column<string[]>(type: "text[]", nullable: true),
                    Tools = table.Column<string[]>(type: "text[]", nullable: true),
                    Languages = table.Column<string[]>(type: "text[]", nullable: true),
                    Background = table.Column<string>(type: "text", nullable: true),
                    Alignment = table.Column<string>(type: "text", nullable: true),
                    Faith = table.Column<string>(type: "text", nullable: true),
                    LifeStyle = table.Column<string>(type: "text", nullable: true),
                    HairStyle = table.Column<string>(type: "text", nullable: true),
                    SkinColor = table.Column<string>(type: "text", nullable: true),
                    EyeColor = table.Column<string>(type: "text", nullable: true),
                    Height = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    PersonalityTrait = table.Column<string>(type: "text", nullable: true),
                    Ideals = table.Column<string>(type: "text", nullable: true),
                    Bonds = table.Column<string>(type: "text", nullable: true),
                    Flaws = table.Column<string>(type: "text", nullable: true),
                    Organizations = table.Column<string>(type: "text", nullable: true),
                    Allies = table.Column<string>(type: "text", nullable: true),
                    Enemies = table.Column<string>(type: "text", nullable: true),
                    BackStory = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Age", "Alignment", "Allies", "Armor", "BackStory", "Background", "Bonds", "Charisma", "Class", "Constitution", "CurrentHealth", "Dexterity", "Enemies", "EyeColor", "Faith", "Flaws", "FullHealth", "HairStyle", "Height", "Ideals", "Intelligence", "Languages", "Level", "LifeStyle", "Name", "Organizations", "PersonalityTrait", "ProfBonus", "Race", "Sex", "SkinColor", "Strength", "TempHealth", "Tools", "WalkSpeed", "Weapons", "Weight", "Wisdom" },
                values: new object[] { 1, 50, "Neutral Good", "test", "Leather", "test", "test", "test", 16, "Rogue", 16, 70, 20, "test", null, "none", "test", 91, "long and curly", 63, "test", 11, new[] { "Common", "Dwarvish", "Elvish", "Orc", "Thieves’ Cant" }, 11, "Rich", "HÜND", "test", "test", 4, "Half-Elf", "Male", "Pale White", 11, 0, new[] { "Smith's Tools", "Thieves' Tools" }, 40, new[] { "crossbow", "hand", "longsword", "rapier", "shortsword", "simple weapons" }, 120, 13 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
