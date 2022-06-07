using Microsoft.EntityFrameworkCore.Migrations;

namespace mentorEmpty.Migrations
{
    public partial class JoinPricingFeaturedasdasdadassasxsaddasdas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JoinPricingFeatures_Features_FeaturesId",
                table: "JoinPricingFeatures");

            migrationBuilder.DropIndex(
                name: "IX_JoinPricingFeatures_FeaturesId",
                table: "JoinPricingFeatures");

            migrationBuilder.DropColumn(
                name: "FeaturesId",
                table: "JoinPricingFeatures");

            migrationBuilder.AddColumn<int>(
                name: "FId",
                table: "JoinPricingFeatures",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JoinPricingFeatures_FId",
                table: "JoinPricingFeatures",
                column: "FId");

            migrationBuilder.AddForeignKey(
                name: "FK_JoinPricingFeatures_Features_FId",
                table: "JoinPricingFeatures",
                column: "FId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JoinPricingFeatures_Features_FId",
                table: "JoinPricingFeatures");

            migrationBuilder.DropIndex(
                name: "IX_JoinPricingFeatures_FId",
                table: "JoinPricingFeatures");

            migrationBuilder.DropColumn(
                name: "FId",
                table: "JoinPricingFeatures");

            migrationBuilder.AddColumn<int>(
                name: "FeaturesId",
                table: "JoinPricingFeatures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JoinPricingFeatures_FeaturesId",
                table: "JoinPricingFeatures",
                column: "FeaturesId");

            migrationBuilder.AddForeignKey(
                name: "FK_JoinPricingFeatures_Features_FeaturesId",
                table: "JoinPricingFeatures",
                column: "FeaturesId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
