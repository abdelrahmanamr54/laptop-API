using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_Laptop_Task.Migrations
{
    public partial class newlaptopapi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    no_of_stars = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ratings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "laptops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    Oldprice = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    BrandId1 = table.Column<int>(type: "int", nullable: true),
                    RatingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_laptops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_laptops_brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_laptops_brands_BrandId1",
                        column: x => x.BrandId1,
                        principalTable: "brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_laptops_ratings_RatingId",
                        column: x => x.RatingId,
                        principalTable: "ratings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_laptops_BrandId",
                table: "laptops",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_laptops_BrandId1",
                table: "laptops",
                column: "BrandId1");

            migrationBuilder.CreateIndex(
                name: "IX_laptops_RatingId",
                table: "laptops",
                column: "RatingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "laptops");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "ratings");
        }
    }
}
