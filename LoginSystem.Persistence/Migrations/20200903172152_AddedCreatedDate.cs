using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginSystem.Persistence.Migrations
{
    public partial class AddedCreatedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Accounts");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Accounts");

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Accounts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
