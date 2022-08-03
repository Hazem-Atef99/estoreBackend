using Microsoft.EntityFrameworkCore.Migrations;

namespace estore.Migrations
{
    public partial class editproductmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gallery",
                table: "products");

            migrationBuilder.AddColumn<bool>(
                name: "isgallery",
                table: "products",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isgallery",
                table: "products");

            migrationBuilder.AddColumn<bool>(
                name: "gallery",
                table: "products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
