using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyFoods.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealTypes_MainIngredients_MainIngredientId",
                table: "MealTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_MainIngredients_MainIngredientId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_MainIngredientId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_MealTypes_MainIngredientId",
                table: "MealTypes");

            migrationBuilder.DropColumn(
                name: "MainIngredientId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "MainIngredientId",
                table: "MealTypes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainIngredientId",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MainIngredientId",
                table: "MealTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "MainIngredientId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "MainIngredientId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "MainIngredientId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "MainIngredientId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "MainIngredientId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "MainIngredientId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "MainIngredientId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "MainIngredientId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                column: "MainIngredientId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                column: "MainIngredientId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                column: "MainIngredientId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                column: "MainIngredientId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                column: "MainIngredientId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                column: "MainIngredientId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                column: "MainIngredientId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                column: "MainIngredientId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                column: "MainIngredientId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                column: "MainIngredientId",
                value: 6);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_MainIngredientId",
                table: "Recipes",
                column: "MainIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_MealTypes_MainIngredientId",
                table: "MealTypes",
                column: "MainIngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_MealTypes_MainIngredients_MainIngredientId",
                table: "MealTypes",
                column: "MainIngredientId",
                principalTable: "MainIngredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_MainIngredients_MainIngredientId",
                table: "Recipes",
                column: "MainIngredientId",
                principalTable: "MainIngredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
