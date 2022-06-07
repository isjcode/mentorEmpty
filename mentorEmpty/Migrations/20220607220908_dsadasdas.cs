using Microsoft.EntityFrameworkCore.Migrations;

namespace mentorEmpty.Migrations
{
    public partial class dsadasdas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinPricingFeatures");

            migrationBuilder.CreateTable(
                name: "Join",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricingId = table.Column<int>(nullable: false),
                    FeaturesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Join_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Pricing_PricingId",
                        column: x => x.PricingId,
                        principalTable: "Pricing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Join_FeaturesId",
                table: "Join",
                column: "FeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_PricingId",
                table: "Join",
                column: "PricingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Join");

            migrationBuilder.CreateTable(
                name: "JoinPricingFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FId = table.Column<int>(type: "int", nullable: true),
                    FeatureId = table.Column<int>(type: "int", nullable: false),
                    PricingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinPricingFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JoinPricingFeatures_Features_FId",
                        column: x => x.FId,
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
                name: "IX_JoinPricingFeatures_FId",
                table: "JoinPricingFeatures",
                column: "FId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinPricingFeatures_PricingId",
                table: "JoinPricingFeatures",
                column: "PricingId");
        }
    }
}
