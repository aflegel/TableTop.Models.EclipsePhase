using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EclipsePhase.Migrations
{
    public partial class TestNameFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtomPage");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Background",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Background",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Background",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Background",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Background",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Background",
                newName: "description");

            migrationBuilder.CreateTable(
                name: "AtomPage",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    page = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtomPage", x => x.name);
                });
        }
    }
}
