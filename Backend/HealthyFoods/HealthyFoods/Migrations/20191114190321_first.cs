using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyFoods.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "MainIngredients",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MainIngredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "/Images/cheese.jpg");

            migrationBuilder.UpdateData(
                table: "MainIngredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "/Images/chicken.jpg");

            migrationBuilder.UpdateData(
                table: "MainIngredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "/Images/steak.jpg");

            migrationBuilder.UpdateData(
                table: "MainIngredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "/Images/Tomatoes.jpg");

            migrationBuilder.UpdateData(
                table: "MainIngredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "/Images/flour.jpg");

            migrationBuilder.UpdateData(
                table: "MainIngredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "/Images/chocolate.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "/Images/chips-and-cheese.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "/Images/mac-and-cheese.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "/Images/fried-chicken.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "/Images/baked-chicken.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "/Images/grilled-steak.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "/Images/steak-tartare.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "/Images/tomato-soup.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "/Images/fried-tomato.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "/Images/peanut-butter-cookies.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "/Images/biscuits.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "/Images/cake.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "/Images/chocolate-bar.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "MainIngredients");
        }
    }
}
