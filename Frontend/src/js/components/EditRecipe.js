export default function EditRecipe(RecipeEDIT) {
    
    return `
        <section class='update-recipe'>
        <input class='update-Recipe_Title' type='text' value="${RecipeEDIT.title}">
        <input class='update-Recipe_Calorie' type='text' value="${RecipeEDIT.calorie}">
        <input class='update-Recipe_Instructions' type='text' value="${RecipeEDIT.instructions}">
        <input class='update-Recipe_id' type='hidden' value="${RecipeEDIT.id}">
        <input class='RecipeImage' type='hidden' value="${RecipeEDIT.image}">
        <button class='update-Recipe_submit'>Save Changes</button>
        </section>
        `;
}