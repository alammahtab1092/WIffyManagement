using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WiffyManagement.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
