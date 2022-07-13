using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleAPI.Migrations
{
    public partial class FirstMigrationToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    RegistrationNo = table.Column<string>(nullable: false),
                    ModelName = table.Column<string>(nullable: true),
                    VehicleType = table.Column<string>(nullable: true),
                    NumberOfSeat = table.Column<int>(nullable: false),
                    AcAvailable = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.RegistrationNo);
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "RegistrationNo", "AcAvailable", "ModelName", "NumberOfSeat", "VehicleType" },
                values: new object[,]
                {
                    { "AP02CD0202", "No", "Chevrolet Tavera", 9, "SUV" },
                    { "KL03EF0303", "Yes", "Chevrolet Enjoy", 7, "SUV" },
                    { "KA04GH0404", "Yes", "Mahindra Tourister", 15, "Van" },
                    { "TN01AB0202", "Yes", "Chevrolet Tavera", 9, "SUV" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
