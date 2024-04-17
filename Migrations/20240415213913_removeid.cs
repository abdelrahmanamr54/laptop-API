using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_Laptop_Task.Migrations
{
    public partial class removeid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_laptops_brands_BrandId1",
                table: "laptops");

            migrationBuilder.DropIndex(
                name: "IX_laptops_BrandId1",
                table: "laptops");

            migrationBuilder.DropColumn(
                name: "BrandId1",
                table: "laptops");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandId1",
                table: "laptops",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_laptops_BrandId1",
                table: "laptops",
                column: "BrandId1");

            migrationBuilder.AddForeignKey(
                name: "FK_laptops_brands_BrandId1",
                table: "laptops",
                column: "BrandId1",
                principalTable: "brands",
                principalColumn: "Id");
        }
    }
}
