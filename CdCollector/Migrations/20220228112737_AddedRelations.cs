using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CdCollector.Migrations
{
    public partial class AddedRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cds",
                table: "Artist");

            migrationBuilder.RenameColumn(
                name: "Artist",
                table: "Cd",
                newName: "ArtistName");

            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Cd",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cd_ArtistId",
                table: "Cd",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cd_Artist_ArtistId",
                table: "Cd",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cd_Artist_ArtistId",
                table: "Cd");

            migrationBuilder.DropIndex(
                name: "IX_Cd_ArtistId",
                table: "Cd");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Cd");

            migrationBuilder.RenameColumn(
                name: "ArtistName",
                table: "Cd",
                newName: "Artist");

            migrationBuilder.AddColumn<string>(
                name: "Cds",
                table: "Artist",
                type: "TEXT",
                nullable: true);
        }
    }
}
