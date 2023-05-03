using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceTravel.Migrations
{
    public partial class Distance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Distance",
                table: "Destination",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 1,
                column: "Distance",
                value: "7,500 light years");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "Distance",
                value: "694.7 light years");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 3,
                column: "Distance",
                value: "158.16 million miles");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 4,
                column: "Distance",
                value: "2.8516 billion miles");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 5,
                columns: new[] { "Distance", "Name" },
                values: new object[] { "414.8 million light years", "Markarian 421 - Blazar Black Hole" });

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 6,
                column: "Distance",
                value: "6,523 light years");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Distance",
                table: "Destination");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 5,
                column: "Name",
                value: "Blazar Black Hole");
        }
    }
}
