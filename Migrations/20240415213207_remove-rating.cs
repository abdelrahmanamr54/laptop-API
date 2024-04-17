using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_Laptop_Task.Migrations
{
    public partial class removerating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_laptops_ratings_RatingId",
                table: "laptops");

            migrationBuilder.DropIndex(
                name: "IX_laptops_RatingId",
                table: "laptops");

            migrationBuilder.DropColumn(
                name: "RatingId",
                table: "laptops");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RatingId",
                table: "laptops",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_laptops_RatingId",
                table: "laptops",
                column: "RatingId");

            migrationBuilder.AddForeignKey(
                name: "FK_laptops_ratings_RatingId",
                table: "laptops",
                column: "RatingId",
                principalTable: "ratings",
                principalColumn: "Id");
        }
    }
}
