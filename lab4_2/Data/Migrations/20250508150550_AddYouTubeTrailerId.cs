using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab4_2.Migrations
{
    /// <inheritdoc />
    public partial class AddYouTubeTrailerId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "YouTubeTrailerId",
                table: "Movie",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YouTubeTrailerId",
                table: "Movie");
        }
    }
}
