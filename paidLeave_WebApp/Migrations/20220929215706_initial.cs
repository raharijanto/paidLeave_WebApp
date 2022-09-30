using Microsoft.EntityFrameworkCore.Migrations;

namespace paidLeave_WebApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuti",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JumlahCuti = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gaji",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GajiAwal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gaji", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jabatan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Posisi = table.Column<string>(nullable: true),
                    SalaryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jabatan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jabatan_Gaji_SalaryId",
                        column: x => x.SalaryId,
                        principalTable: "Gaji",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Netto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GajiBersih = table.Column<int>(nullable: false),
                    GajiId = table.Column<int>(nullable: false),
                    CutiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Netto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Netto_Cuti_CutiId",
                        column: x => x.CutiId,
                        principalTable: "Cuti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Netto_Gaji_GajiId",
                        column: x => x.GajiId,
                        principalTable: "Gaji",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Karyawan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PosisiId = table.Column<int>(nullable: false),
                    AmbilCuti = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karyawan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Karyawan_Cuti_AmbilCuti",
                        column: x => x.AmbilCuti,
                        principalTable: "Cuti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Karyawan_Jabatan_PosisiId",
                        column: x => x.PosisiId,
                        principalTable: "Jabatan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jabatan_SalaryId",
                table: "Jabatan",
                column: "SalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Karyawan_AmbilCuti",
                table: "Karyawan",
                column: "AmbilCuti");

            migrationBuilder.CreateIndex(
                name: "IX_Karyawan_PosisiId",
                table: "Karyawan",
                column: "PosisiId");

            migrationBuilder.CreateIndex(
                name: "IX_Netto_CutiId",
                table: "Netto",
                column: "CutiId");

            migrationBuilder.CreateIndex(
                name: "IX_Netto_GajiId",
                table: "Netto",
                column: "GajiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Karyawan");

            migrationBuilder.DropTable(
                name: "Netto");

            migrationBuilder.DropTable(
                name: "Jabatan");

            migrationBuilder.DropTable(
                name: "Cuti");

            migrationBuilder.DropTable(
                name: "Gaji");
        }
    }
}
