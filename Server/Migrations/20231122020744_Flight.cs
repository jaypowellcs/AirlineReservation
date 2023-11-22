using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class Flight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FlightId",
                table: "Seat",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Airport",
                columns: table => new
                {
                    AirportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airport", x => x.AirportId);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirportIdDeparture = table.Column<int>(type: "int", nullable: true),
                    AirportDepartureAirportId = table.Column<int>(type: "int", nullable: true),
                    AirportIdArrival = table.Column<int>(type: "int", nullable: true),
                    AirportArrivalAirportId = table.Column<int>(type: "int", nullable: true),
                    AirplaneType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepatureDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ArrivalDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DurationInMins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_Flight_Airport_AirportArrivalAirportId",
                        column: x => x.AirportArrivalAirportId,
                        principalTable: "Airport",
                        principalColumn: "AirportId");
                    table.ForeignKey(
                        name: "FK_Flight_Airport_AirportDepartureAirportId",
                        column: x => x.AirportDepartureAirportId,
                        principalTable: "Airport",
                        principalColumn: "AirportId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seat_FlightId",
                table: "Seat",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_AirportArrivalAirportId",
                table: "Flight",
                column: "AirportArrivalAirportId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_AirportDepartureAirportId",
                table: "Flight",
                column: "AirportDepartureAirportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Flight_FlightId",
                table: "Seat",
                column: "FlightId",
                principalTable: "Flight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Flight_FlightId",
                table: "Seat");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Airport");

            migrationBuilder.DropIndex(
                name: "IX_Seat_FlightId",
                table: "Seat");

            migrationBuilder.AlterColumn<string>(
                name: "FlightId",
                table: "Seat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
