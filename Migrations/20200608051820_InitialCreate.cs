using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalaryApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    dayIn = table.Column<DateTime>(nullable: false),
                    Regency = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    SalaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dayTake = table.Column<DateTime>(nullable: false),
                    chargeTax = table.Column<int>(nullable: false),
                    chargeInsurrance = table.Column<int>(nullable: false),
                    supportCash = table.Column<int>(nullable: false),
                    basicSalary = table.Column<int>(nullable: false),
                    keepSalary = table.Column<int>(nullable: false),
                    totalSalary = table.Column<int>(nullable: false),
                    StaffId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.SalaryId);
                    table.ForeignKey(
                        name: "FK_Salary_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Overtime",
                columns: table => new
                {
                    OverTimeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dayOff = table.Column<int>(nullable: false),
                    overtimeHours = table.Column<int>(nullable: false),
                    overtimeSalary = table.Column<int>(nullable: false),
                    SalaryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Overtime", x => x.OverTimeId);
                    table.ForeignKey(
                        name: "FK_Overtime_Salary_SalaryId",
                        column: x => x.SalaryId,
                        principalTable: "Salary",
                        principalColumn: "SalaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Allowance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bonusKPI = table.Column<int>(nullable: false),
                    uniformsCharge = table.Column<int>(nullable: false),
                    phoneCharge = table.Column<int>(nullable: false),
                    lunchCharge = table.Column<int>(nullable: false),
                    OvertimeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allowance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Allowance_Overtime_OvertimeId",
                        column: x => x.OvertimeId,
                        principalTable: "Overtime",
                        principalColumn: "OverTimeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Allowance_OvertimeId",
                table: "Allowance",
                column: "OvertimeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Overtime_SalaryId",
                table: "Overtime",
                column: "SalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_StaffId",
                table: "Salary",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allowance");

            migrationBuilder.DropTable(
                name: "Overtime");

            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
