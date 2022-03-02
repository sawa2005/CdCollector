using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CdCollector.Migrations
{
    public partial class ChangedRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "Cd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArtistName",
                table: "Cd",
                type: "TEXT",
                nullable: true);
        }
    }
}
