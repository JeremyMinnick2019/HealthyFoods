export default function EditMealType(MealTypeEDIT) {
    
    return `
        <section class='update-mainingredient'>
        <input class='update-MealType_type' type='text' value="${MealTypeEDIT.type}">
        <input class='update-MealType_id' type='hidden' value="${MealTypeEDIT.id}">
        <input class='update-MealType_MainIngredientId' type='hidden' value="${MealTypeEDIT.mainingredientid}">
        <button class='update-MealType_submit'>Save Changes</button>
        </section>
        `;
}