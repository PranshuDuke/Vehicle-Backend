using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingAPI.Migrations
{
    public partial class FirstMigrationToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vehicle = table.Column<string>(nullable: true),
                    Driver = table.Column<string>(nullable: true),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    FromLocation = table.Column<string>(nullable: true),
                    ToLocation = table.Column<string>(nullable: true),
                    Distance = table.Column<double>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    TripFare = table.Column<double>(nullable: false),
                    FuelExpense = table.Column<double>(nullable: false),
                    DriverShare = table.Column<double>(nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");
        }
    }
}
