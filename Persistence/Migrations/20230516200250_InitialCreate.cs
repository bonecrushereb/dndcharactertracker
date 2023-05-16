using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Race = table.Column<string>(type: "TEXT", nullable: true),
                    Class = table.Column<string>(type: "TEXT", nullable: true),
                    Abilities = table.Column<string>(type: "TEXT", nullable: true),
                    Background = table.Column<string>(type: "TEXT", nullable: true),
                    Skillproficiencies = table.Column<string>(type: "TEXT", nullable: true),
                    Toolproficiencies = table.Column<string>(type: "TEXT", nullable: true),
                    Languages = table.Column<string>(type: "TEXT", nullable: true),
                    PersonalityTrait = table.Column<string>(type: "TEXT", nullable: true),
                    Ideals = table.Column<string>(type: "TEXT", nullable: true),
                    Bonds = table.Column<string>(type: "TEXT", nullable: true),
                    Flaws = table.Column<string>(type: "TEXT", nullable: true),
                    Organizations = table.Column<string>(type: "TEXT", nullable: true),
                    Allies = table.Column<string>(type: "TEXT", nullable: true),
                    Enemies = table.Column<string>(type: "TEXT", nullable: true),
                    Backstory = table.Column<string>(type: "TEXT", nullable: true),
                    Equipment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
