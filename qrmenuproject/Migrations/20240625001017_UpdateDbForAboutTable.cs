using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace qrmenuproject.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDbForAboutTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AboutDescription = table.Column<string>(type: "TEXT", nullable: true),
                    AboutVision = table.Column<string>(type: "TEXT", nullable: true),
                    AboutMission = table.Column<string>(type: "TEXT", nullable: true),
                    AboutWpAddress = table.Column<string>(type: "TEXT", nullable: true),
                    AboutInstagramAddress = table.Column<string>(type: "TEXT", nullable: true),
                    AboutFacebookAddress = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}
