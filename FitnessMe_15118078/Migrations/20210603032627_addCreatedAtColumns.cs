using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessMe_15118078.Migrations
{
    public partial class addCreatedAtColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt_15118078",
                table: "Weight",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt_15118078",
                table: "Weight",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt_15118078",
                table: "Nutrition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt_15118078",
                table: "Nutrition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt_15118078",
                table: "Meal",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt_15118078",
                table: "Meal",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt_15118078",
                table: "Food",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt_15118078",
                table: "Food",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt_15118078",
                table: "Weight");

            migrationBuilder.DropColumn(
                name: "UpdatedAt_15118078",
                table: "Weight");

            migrationBuilder.DropColumn(
                name: "CreatedAt_15118078",
                table: "Nutrition");

            migrationBuilder.DropColumn(
                name: "UpdatedAt_15118078",
                table: "Nutrition");

            migrationBuilder.DropColumn(
                name: "CreatedAt_15118078",
                table: "Meal");

            migrationBuilder.DropColumn(
                name: "UpdatedAt_15118078",
                table: "Meal");

            migrationBuilder.DropColumn(
                name: "CreatedAt_15118078",
                table: "Food");

            migrationBuilder.DropColumn(
                name: "UpdatedAt_15118078",
                table: "Food");
        }
    }
}
