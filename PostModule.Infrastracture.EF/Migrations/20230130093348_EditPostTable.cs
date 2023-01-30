using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostModule.Infrastracture.EF.Migrations
{
    public partial class EditPostTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "InsideCity",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OutSideCity",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "InsideCity",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "OutSideCity",
                table: "Posts");
        }
    }
}
