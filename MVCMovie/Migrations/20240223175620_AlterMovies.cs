using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCMovie.Migrations
{
    /// <inheritdoc />
    public partial class AlterMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Studio_StudiosStudioId",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "StudiosStudioId",
                table: "Movie",
                newName: "StudioId");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_StudiosStudioId",
                table: "Movie",
                newName: "IX_Movie_StudioId");

            migrationBuilder.CreateTable(
                name: "ArtistMovie",
                columns: table => new
                {
                    ArtistsArtistId = table.Column<int>(type: "INTEGER", nullable: false),
                    MoviesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistMovie", x => new { x.ArtistsArtistId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_ArtistMovie_Artist_ArtistsArtistId",
                        column: x => x.ArtistsArtistId,
                        principalTable: "Artist",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistMovie_Movie_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistMovie_MoviesId",
                table: "ArtistMovie",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Studio_StudioId",
                table: "Movie",
                column: "StudioId",
                principalTable: "Studio",
                principalColumn: "StudioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Studio_StudioId",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "ArtistMovie");

            migrationBuilder.RenameColumn(
                name: "StudioId",
                table: "Movie",
                newName: "StudiosStudioId");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_StudioId",
                table: "Movie",
                newName: "IX_Movie_StudiosStudioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Studio_StudiosStudioId",
                table: "Movie",
                column: "StudiosStudioId",
                principalTable: "Studio",
                principalColumn: "StudioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
