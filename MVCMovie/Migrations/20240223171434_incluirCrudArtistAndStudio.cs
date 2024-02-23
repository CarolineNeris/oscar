using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCMovie.Migrations
{
    /// <inheritdoc />
    public partial class incluirCrudArtistAndStudio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudiosStudioId",
                table: "Movie",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Bio = table.Column<string>(type: "TEXT", nullable: false),
                    Site = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Studio",
                columns: table => new
                {
                    StudioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Pais = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studio", x => x.StudioId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_StudiosStudioId",
                table: "Movie",
                column: "StudiosStudioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Studio_StudiosStudioId",
                table: "Movie",
                column: "StudiosStudioId",
                principalTable: "Studio",
                principalColumn: "StudioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Studio_StudiosStudioId",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Studio");

            migrationBuilder.DropIndex(
                name: "IX_Movie_StudiosStudioId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "StudiosStudioId",
                table: "Movie");
        }
    }
}
