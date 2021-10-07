using Microsoft.EntityFrameworkCore.Migrations;

namespace AttendanceRegister.Migrations
{
    public partial class Attendances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Staffs_StaffId",
                table: "Attendances");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_StaffId",
                table: "Attendances");

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "Attendances",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_Name",
                table: "Attendances",
                column: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Staffs_Name",
                table: "Attendances",
                column: "Name",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Staffs_Name",
                table: "Attendances");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_Name",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Attendances");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StaffId",
                table: "Attendances",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Staffs_StaffId",
                table: "Attendances",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
