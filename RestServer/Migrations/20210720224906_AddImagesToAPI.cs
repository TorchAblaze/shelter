using Microsoft.EntityFrameworkCore.Migrations;

namespace animal_shelter.Migrations
{
    public partial class AddImagesToAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PicHeight",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PicWidth",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PicHeight", "PicWidth" },
                values: new object[] { 100, 100 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PicHeight", "PicWidth" },
                values: new object[] { 200, 200 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PicHeight", "PicWidth" },
                values: new object[] { 210, 210 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PicHeight", "PicWidth" },
                values: new object[] { 300, 300 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PicHeight", "PicWidth" },
                values: new object[] { 500, 500 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PicHeight", "PicWidth" },
                values: new object[] { 600, 600 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PicHeight", "PicWidth" },
                values: new object[] { 700, 700 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PicHeight", "PicWidth" },
                values: new object[] { 800, 800 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PicHeight", "PicWidth" },
                values: new object[] { 900, 900 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PicHeight", "PicWidth" },
                values: new object[] { 1010, 1010 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PicHeight", "PicWidth" },
                values: new object[] { 1200, 1200 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PicHeight", "PicWidth" },
                values: new object[] { 1300, 1300 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicHeight",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "PicWidth",
                table: "Animals");
        }
    }
}
