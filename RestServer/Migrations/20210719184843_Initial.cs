﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace animal_shelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Sex = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Available = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Available", "Name", "Sex", "Type" },
                values: new object[,]
                {
                    { 1, 15, true, "John", "Male", "cat" },
                    { 2, 15, false, "Robb", "Male", "cat" },
                    { 3, 11, true, "Sansa", "Female", "cat" },
                    { 4, 7, true, "Bran", "Male", "cat" },
                    { 5, 9, true, "Arya", "Female", "cat" },
                    { 6, 3, false, "Rickon", "Male", "cat" },
                    { 7, 1, true, "Ghost", "Male", "dog" },
                    { 8, 1, false, "Grey Wind", "Male", "dog" },
                    { 9, 1, false, "Lady", "Female", "dog" },
                    { 10, 1, true, "Nymeria", "Female", "dog" },
                    { 11, 1, false, "Summer", "Male", "dog" },
                    { 12, 1, false, "Shaggy Dog", "Male", "dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
