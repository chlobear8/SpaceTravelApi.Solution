using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceTravel.Migrations
{
    public partial class UpdatedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 1,
                column: "Url",
                value: "https://images-assets.nasa.gov/image/carina_nebula/carina_nebula~medium.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "Url",
                value: "https://images-assets.nasa.gov/image/PIA09178/PIA09178~medium.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 3,
                column: "Url",
                value: "https://images-assets.nasa.gov/image/PIA21041/PIA21041~small.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 4,
                column: "Url",
                value: "https://images-assets.nasa.gov/image/PIA01492/PIA01492~medium.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 5,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Blazar Black Hole", "https://images-assets.nasa.gov/image/PIA20912/PIA20912~small.jpg" });

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 6,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Crab Nebula", "https://images-assets.nasa.gov/image/PIA21474/PIA21474~small.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 1,
                column: "Url",
                value: "dfhdfj");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "Url",
                value: "https://images.nasa.gov/details/PIA09178");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 3,
                column: "Url",
                value: "dhhhf");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 4,
                column: "Url",
                value: "https://images.nasa.gov/details/PIA01492");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 5,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Aurora Australis", "https://images.nasa.gov/details/iss029e008433" });

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 6,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Carina Nebula2", "dsgsdg" });
        }
    }
}
