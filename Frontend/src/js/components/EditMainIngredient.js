export default function EditMainIngredient(MainIngredientEDIT) {
    
    return `
        <section class='update-mainingredient'>
        <input class='update-mainingredient_ingredient' type='text' value="${MainIngredientEDIT.ingredient}">
        <input class='update-MainIngredient_id' type='hidden' value="${MainIngredientEDIT.id}">
        <input class='MainIngredientImage' type='hidden' value="${MainIngredientEDIT.image}">
        <button class='update-MainIngredient_submit'>Save Changes</button>
        </section>

        
        `;
}