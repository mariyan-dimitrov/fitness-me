using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessDiary_17118074.Migrations
{
    public partial class addCreatedAtColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt_17118074",
                table: "Weight",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt_17118074",
                table: "Weight",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt_17118074",
                table: "Nutrition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt_17118074",
                table: "Nutrition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt_17118074",
                table: "Meal",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt_17118074",
                table: "Meal",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt_17118074",
                table: "Food",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt_17118074",
                table: "Food",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt_17118074",
                table: "Weight");

            migrationBuilder.DropColumn(
                name: "UpdatedAt_17118074",
                table: "Weight");

            migrationBuilder.DropColumn(
                name: "CreatedAt_17118074",
                table: "Nutrition");

            migrationBuilder.DropColumn(
                name: "UpdatedAt_17118074",
                table: "Nutrition");

            migrationBuilder.DropColumn(
                name: "CreatedAt_17118074",
                table: "Meal");

            migrationBuilder.DropColumn(
                name: "UpdatedAt_17118074",
                table: "Meal");

            migrationBuilder.DropColumn(
                name: "CreatedAt_17118074",
                table: "Food");

            migrationBuilder.DropColumn(
                name: "UpdatedAt_17118074",
                table: "Food");
        }
    }
}
