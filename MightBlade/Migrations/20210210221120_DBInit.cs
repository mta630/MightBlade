using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MightBlade.Migrations
{
    public partial class DBInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    DamageMod = table.Column<int>(type: "int", nullable: false),
                    HealthMod = table.Column<int>(type: "int", nullable: false),
                    ManaMod = table.Column<int>(type: "int", nullable: false),
                    SellValue = table.Column<int>(type: "int", nullable: false),
                    BuyValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserClass = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    Stats = table.Column<string>(type: "text", nullable: false),
                    Inventory = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "Idx_Name",
                table: "Items",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "Idx_UserName",
                table: "Users",
                column: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
