using Microsoft.EntityFrameworkCore.Migrations;

namespace mentorEmpty.Migrations
{
    public partial class dasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Trainers");

            migrationBuilder.AddColumn<int>(
                name: "PositionsId",
                table: "Trainers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_PositionsId",
                table: "Trainers",
                column: "PositionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_Positions_PositionsId",
                table: "Trainers",
                column: "PositionsId",
                principalTable: "Positions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_Positions_PositionsId",
                table: "Trainers");

            migrationBuilder.DropIndex(
                name: "IX_Trainers_PositionsId",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "PositionsId",
                table: "Trainers");

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "Trainers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
