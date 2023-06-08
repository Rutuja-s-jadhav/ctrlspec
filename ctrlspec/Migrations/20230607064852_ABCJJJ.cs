using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ctrlspec.Migrations
{
    /// <inheritdoc />
    public partial class ABCJJJ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    LoginId = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_login", x => x.LoginId);
                });

            migrationBuilder.CreateTable(
                name: "projectinfo",
                columns: table => new
                {
                    ProjectNumber = table.Column<double>(type: "float", nullable: false),
                    MeasurementType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreparedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectinfo", x => x.ProjectNumber);
                });

            migrationBuilder.CreateTable(
                name: "spec_Options",
                columns: table => new
                {
                    Id = table.Column<double>(type: "float", nullable: false),
                    Questions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spec_Options", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "equipment",
                columns: table => new
                {
                    EquipmentID = table.Column<double>(type: "float", nullable: false),
                    ProjectNumber = table.Column<double>(type: "float", nullable: false),
                    EquipmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypicalOf = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipment", x => x.EquipmentID);
                    table.ForeignKey(
                        name: "FK_equipment_projectinfo_ProjectNumber",
                        column: x => x.ProjectNumber,
                        principalTable: "projectinfo",
                        principalColumn: "ProjectNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "exhaust_Fans",
                columns: table => new
                {
                    EquipmentID = table.Column<double>(type: "float", nullable: false),
                    DamperControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilterMonitoring = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiscMonitoring = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exhaust_Fans", x => x.EquipmentID);
                    table.ForeignKey(
                        name: "FK_exhaust_Fans_equipment_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "room_Units",
                columns: table => new
                {
                    EquipmentID = table.Column<double>(type: "float", nullable: false),
                    ZoneControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Safeties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaceBypassDamper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cooling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Heating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeatingHighDischargeLimit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MixedAirDamper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimunOutsideAir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvironmentalIndex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilterMonitoring = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiscMonitoring = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_Units", x => x.EquipmentID);
                    table.ForeignKey(
                        name: "FK_room_Units_equipment_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "unitary_Heats",
                columns: table => new
                {
                    EquipmentID = table.Column<double>(type: "float", nullable: false),
                    ZoneControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Heating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvironmentalIndex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilterMonitoring = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiscMonitoring = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unitary_Heats", x => x.EquipmentID);
                    table.ForeignKey(
                        name: "FK_unitary_Heats_equipment_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_equipment_ProjectNumber",
                table: "equipment",
                column: "ProjectNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "exhaust_Fans");

            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "room_Units");

            migrationBuilder.DropTable(
                name: "spec_Options");

            migrationBuilder.DropTable(
                name: "unitary_Heats");

            migrationBuilder.DropTable(
                name: "equipment");

            migrationBuilder.DropTable(
                name: "projectinfo");
        }
    }
}
