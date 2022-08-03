using Microsoft.EntityFrameworkCore.Migrations;

namespace estore.Migrations
{
    public partial class imageFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "products",
                newName: "ImageName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "products",
                newName: "Image");
        }
    }
}
