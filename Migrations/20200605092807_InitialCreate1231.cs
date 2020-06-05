using Microsoft.EntityFrameworkCore.Migrations;

namespace SalaryApp.Migrations
{
    public partial class InitialCreate1231 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allowance_Salary_SalaryId",
                table: "Allowance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Overtime",
                table: "Overtime");

            migrationBuilder.DropIndex(
                name: "IX_Allowance_SalaryId",
                table: "Allowance");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Overtime");

            migrationBuilder.DropColumn(
                name: "SalaryId",
                table: "Allowance");

            migrationBuilder.AddColumn<int>(
                name: "OverTimeId",
                table: "Overtime",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "OvertimeId",
                table: "Allowance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Overtime",
                table: "Overtime",
                column: "OverTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Allowance_OvertimeId",
                table: "Allowance",
                column: "OvertimeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Allowance_Overtime_OvertimeId",
                table: "Allowance",
                column: "OvertimeId",
                principalTable: "Overtime",
                principalColumn: "OverTimeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allowance_Overtime_OvertimeId",
                table: "Allowance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Overtime",
                table: "Overtime");

            migrationBuilder.DropIndex(
                name: "IX_Allowance_OvertimeId",
                table: "Allowance");

            migrationBuilder.DropColumn(
                name: "OverTimeId",
                table: "Overtime");

            migrationBuilder.DropColumn(
                name: "OvertimeId",
                table: "Allowance");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Overtime",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SalaryId",
                table: "Allowance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Overtime",
                table: "Overtime",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Allowance_SalaryId",
                table: "Allowance",
                column: "SalaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Allowance_Salary_SalaryId",
                table: "Allowance",
                column: "SalaryId",
                principalTable: "Salary",
                principalColumn: "SalaryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
