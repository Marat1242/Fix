using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fix.Migrations
{
    /// <inheritdoc />
    public partial class название_миграции : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MusicCATEGORY",
                table: "MusicCATEGORY");

            migrationBuilder.RenameTable(
                name: "MusicCATEGORY",
                newName: "Mark");

            migrationBuilder.RenameColumn(
                name: "Deb",
                table: "Mark",
                newName: "Byd");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Mark",
                newName: "Dat");

            migrationBuilder.RenameColumn(
                name: "Artist",
                table: "Mark",
                newName: "Art");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Mark",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mark",
                table: "Mark",
                column: "ItemID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mark",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Mark");

            migrationBuilder.RenameTable(
                name: "Mark",
                newName: "MusicCATEGORY");

            migrationBuilder.RenameColumn(
                name: "Dat",
                table: "MusicCATEGORY",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "Byd",
                table: "MusicCATEGORY",
                newName: "Deb");

            migrationBuilder.RenameColumn(
                name: "Art",
                table: "MusicCATEGORY",
                newName: "Artist");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusicCATEGORY",
                table: "MusicCATEGORY",
                column: "ItemID");
        }
    }
}
