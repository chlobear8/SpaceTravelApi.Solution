using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceTravel.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Destination",
                columns: table => new
                {
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination", x => x.DestinationId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "DestinationId", "Name", "Price", "Url" },
                values: new object[,]
                {
                    { 1, "Carina Nebula", "$1,295", "dfhdfj" },
                    { 2, "Helix Nebula", "$1,495", "https://images.nasa.gov/details/PIA09178" },
                    { 3, "Mars", "$1,095", "dhhhf" },
                    { 4, "Neptune ", "$2,295", "https://images.nasa.gov/details/PIA01492" },
                    { 5, "Aurora Australis", "$1,895", "https://images.nasa.gov/details/iss029e008433" },
                    { 6, "Carina Nebula2", "$1,495", "dsgsdg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destination");
        }
    }
}
