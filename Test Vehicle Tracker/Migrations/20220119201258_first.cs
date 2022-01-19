using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Vehicle_Tracker.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleName = table.Column<string>(nullable: true),
                    VehicleRegNo = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTrackingInfos",
                columns: table => new
                {
                    VehicleTrackingInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    Longtitude = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTrackingInfos", x => x.VehicleTrackingInfoId);
                    table.ForeignKey(
                        name: "FK_VehicleTrackingInfos_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTrackingInfos_VehicleId",
                table: "VehicleTrackingInfos",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleTrackingInfos");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
