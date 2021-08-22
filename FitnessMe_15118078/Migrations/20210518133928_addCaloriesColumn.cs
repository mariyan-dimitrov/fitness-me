using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessMe_15118078.Migrations
{
    public partial class addCaloriesColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Calories",
                table: "Food",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "Food");
        }
    }
}
