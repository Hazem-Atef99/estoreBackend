using Microsoft.EntityFrameworkCore.Migrations;

namespace estore.Migrations
{
    public partial class productDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "inConfomation",
                table: "products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isAddedToCart",
                table: "products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isAddedToCheckout",
                table: "products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "productDescription",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "inConfomation",
                table: "products");

            migrationBuilder.DropColumn(
                name: "isAddedToCart",
                table: "products");

            migrationBuilder.DropColumn(
                name: "isAddedToCheckout",
                table: "products");

            migrationBuilder.DropColumn(
                name: "productDescription",
                table: "products");
        }
    }
}
