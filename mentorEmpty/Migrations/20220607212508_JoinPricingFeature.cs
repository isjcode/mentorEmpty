using Microsoft.EntityFrameworkCore.Migrations;

namespace mentorEmpty.Migrations
{
    public partial class JoinPricingFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JoinPricingFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureId = table.Column<int>(nullable: false),
                    PricingId = table.Column<int>(nullable: false),
                    FeaturesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinPricingFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JoinPricingFeatures_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JoinPricingFeatures_Pricing_PricingId",
                        column: x => x.PricingId,
                        principalTable: "Pricing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoinPricingFeatures_FeaturesId",
                table: "JoinPricingFeatures",
                column: "FeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinPricingFeatures_PricingId",
                table: "JoinPricingFeatures",
                column: "PricingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinPricingFeatures");
        }
    }
}
