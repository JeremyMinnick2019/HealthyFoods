using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyFoods.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ingredient = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainIngredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MealTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    MainIngredientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealTypes_MainIngredients_MainIngredientId",
                        column: x => x.MainIngredientId,
                        principalTable: "MainIngredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Calorie = table.Column<string>(nullable: true),
                    Instructions = table.Column<string>(nullable: true),
                    MainIngredientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_MainIngredients_MainIngredientId",
                        column: x => x.MainIngredientId,
                        principalTable: "MainIngredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MainIngredients",
                columns: new[] { "Id", "Ingredient" },
                values: new object[,]
                {
                    { 1, "Cheese" },
                    { 2, "Chicken" },
                    { 3, "Steak" },
                    { 4, "Tomato" },
                    { 5, "Flour" },
                    { 6, "Chocolate" }
                });

            migrationBuilder.InsertData(
                table: "MealTypes",
                columns: new[] { "Id", "MainIngredientId", "Type" },
                values: new object[,]
                {
                    { 6, 1, "Snack" },
                    { 5, 6, "Dessert" },
                    { 2, 2, "Dinner" },
                    { 1, 5, "Breakfast, Dessert" },
                    { 3, 3, "Dinner" },
                    { 4, 4, "Lunch, Dinner" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Calorie", "Instructions", "MainIngredientId", "Title" },
                values: new object[,]
                {
                    { 10, "310", "Preheat oven to 450 degrees F (230 degrees C). In a large mixing bowl sift together flour, baking powder and salt. Cut in shortening with fork or pastry blender until mixture resembles coarse crumbs. Pour milk into flour mixture while stirring with a fork. Mix in milk until dough is soft, moist and pulls away from the side of the bowl. Turn dough out onto a lightly floured surface and toss with flour until no longer sticky. Roll dough out into a 1/2 inch thick sheet and cut with a floured biscuit or cookie cutter. Press together unused dough and repeat rolling and cutting procedure. Place biscuits on ungreased baking sheets and bake in preheated oven until golden brown, about 10 minutes.", 5, "Biscuits" },
                    { 9, "320", "Cream butter, peanut butter, and sugars together in a bowl; beat in eggs. In a separate bowl, sift flour, baking powder, baking soda, and salt; stir into butter mixture. Put dough in refrigerator for 1 hour. Roll dough into 1 inch balls and put on baking sheets. Flatten each ball with a fork, making a crisscross pattern. Bake in a preheated 375 degrees F oven for about 10 minutes or until cookies begin to brown.", 5, "Special Cookies" },
                    { 8, "220", "Slice tomatoes 1/2 inch thick. Discard the ends. Whisk eggs and milk together in a medium-size bowl. Scoop flour onto a plate. Mix cornmeal, bread crumbs and salt and pepper on another plate. Dip tomatoes into flour to coat. Then dip the tomatoes into milk and egg mixture. Dredge in breadcrumbs to completely coat. In a large skillet, pour vegetable oil (enough so that there is 1/2 inch of oil in the pan) and heat over a medium heat. Place tomatoes into the frying pan in batches of 4 or 5, depending on the size of your skillet. Do not crowd the tomatoes, they should not touch each other. When the tomatoes are browned, flip and fry them on the other side. Drain them on paper towels.", 4, "Fried Tomatos" },
                    { 7, "120", "In a nonreactive 5- to 6-quart Dutch oven, heat the oil and butter over medium-low heat until the butter melts. Add the onion and garlic and cook, stirring occasionally, until soft but not browned, about 8 minutes. Add the flour and stir to coat the onion and garlic.Add the broth, tomatoes, sugar, thyme, and 1/4 tsp. each salt and pepper. Bring to a simmer over medium-high heat while stirring the mixture to make sure that the flour is not sticking to the bottom of the pan. Reduce the heat to low, cover, and simmer for 40 minutes.Discard the thyme sprig. Let cool briefly and then purée in two or three batches in a blender or food processor. Rinse the pot and return the soup to the pot. Season to taste with salt and pepper. Reheat if necessary. Serve warm but not hot, garnished with the herbs or dolloped with one of the garnishes below. ", 4, "Tomato Soup" },
                    { 6, "720", "In a medium bowl, mix together the beef, mustard, hot pepper sauce, Worcestershire sauce, brandy, salt, pepper and egg until well blended. Arrange the meat in a neat pile on a glass dish, and cover with aluminum foil. Refrigerate for 30 minutes to allow the flavors to blend. Serve as a spread on crackers or toast.", 3, "Steak Tartare" },
                    { 5, "720", "About 20 minutes before grilling, remove the steaks from the refrigerator and let sit, covered, at room temperature. Heat your grill to high. Brush the steaks on both sides with oil and season liberally with salt and pepper. Place the steaks on the grill and cook until golden brown and slightly charred, 4 to 5 minutes. Turn the steaks over and continue to grill 3 to 5 minutes for medium-rare (an internal temperature of 135 degrees F), 5 to 7 minutes for medium (140 degrees F) or 8 to 10 minutes for medium-well (150 degrees F). Transfer the steaks to a cutting board or platter, tent loosely with foil and let rest 5 minutes before slicing.", 3, "Grilled Steak" },
                    { 4, "750", "Preheat oven to 375º. In a small bowl, combine brown sugar, garlic powder, paprika, salt, and pepper. Drizzle oil all over chicken and generously coat with seasoning mixture, shaking off excess. Scatter lemon slices in baking dish then place chicken on top.Bake until chicken is cooked through, or reads an internal temperature of 165º, about 25 minutes. Cover chicken loosely with foil and let rest for at least 5 minutes. Garnish with parsley, if using.", 2, "Baked Chicken" },
                    { 3, "650", "Combine the chicken with all the marinade ingredients in a large bowl. Stir to make sure each piece of chicken is coated evenly, then cover with cling film and chill for about an hour.", 2, "Fried Chicken" },
                    { 2, "550", "Cook macaroni according to the package directions. Drain. In a saucepan, melt butter or margarine over medium heat. Stir in enough flour to make a roux. Add milk to roux slowly, stirring constantly. Stir in cheeses, and cook over low heat until cheese is melted and the sauce is a little thick. Put macaroni in large casserole dish, and pour sauce over macaroni. Stir well. Melt butter or margarine in a skillet over medium heat. Add breadcrumbs and brown. Spread over the macaroni and cheese to cover. Sprinkle with a little paprika. Bake at 350 degrees F (175 degrees C) for 30 minutes. Serve. ", 1, "Macaroni and Cheese" },
                    { 1, "250", "Heat the oven to 450°F and arrange a rack in the middle. Meanwhile, shred 1 pound of sharp cheddar cheese. Line a baking sheet with aluminum foil. Spread about half of a 14-ounce bag of tortilla chips on the baking sheet in an even layer. Sprinkle half of the cheese evenly over the chips. Repeat with remaining chips and cheese. Bake until the cheese is melted and bubbly, about 5 minutes. Remove from the oven and garnish with your choice of toppings. Serve immediately. ", 1, "Chips and Cheese" },
                    { 11, "710", "Preheat oven to 350 degrees F (175 degrees C). Grease and flour two nine inch round pans. In a large bowl, stir together the sugar, flour, cocoa, baking powder, baking soda and salt. Add the eggs, milk, oil and vanilla, mix for 2 minutes on medium speed of mixer. Stir in the boiling water last. Batter will be thin. Pour evenly into the prepared pans. Bake 30 to 35 minutes in the preheated oven, until the cake tests done with a toothpick. Cool in the pans for 10 minutes, then remove to a wire rack to cool completely. ", 6, "Chocolate Cake" },
                    { 12, "410", "Homemade Chocolate Bars: Combine coconut oil with the liquid sweetener or stevia drops. (For the stevia version, I recommend NuNaturals because I find other brands to have an aftertaste.) Stir, then add the cacao powder. Stir stir stir! Stir until it gets thick. Pour into any flat container (or candy molds or smush between layers of wax paper or in ziploc bags). Freeze until solid, and store in the freezer. Once hardened, you can also opt to melt the bars again for chocolate sauce. Or chop them up for healthy 100% sugar-free chocolate chips! If you use the stevia option, these bars are sugar-free.", 6, "Chocolate Bar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MealTypes_MainIngredientId",
                table: "MealTypes",
                column: "MainIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_MainIngredientId",
                table: "Recipes",
                column: "MainIngredientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealTypes");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "MainIngredients");
        }
    }
}
