using Microsoft.EntityFrameworkCore.Migrations;

namespace estore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isSlider = table.Column<bool>(type: "bit", nullable: false),
                    isCategory = table.Column<bool>(type: "bit", nullable: false),
                    isLatestProduct = table.Column<bool>(type: "bit", nullable: false),
                    isBestProduct = table.Column<bool>(type: "bit", nullable: false),
                    isBestCollection = table.Column<bool>(type: "bit", nullable: false),
                    isLatestOffer = table.Column<bool>(type: "bit", nullable: false),
                    gallery = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
