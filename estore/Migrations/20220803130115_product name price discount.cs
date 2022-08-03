using Microsoft.EntityFrameworkCore.Migrations;

namespace estore.Migrations
{
    public partial class productnamepricediscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "discount",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "price",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "productName",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discount",
                table: "products");

            migrationBuilder.DropColumn(
                name: "price",
                table: "products");

            migrationBuilder.DropColumn(
                name: "productName",
                table: "products");
        }
    }
}
