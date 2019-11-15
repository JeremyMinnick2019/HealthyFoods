export default function MainIngredient(mainingredient) {
    return `
    <section class='add-MainIngredient'>
        <input class='add-Ingredients' type='text' placeholder='Add A Main Ingredient'>
        <button class='add-MainIngredient_submit'>Submit</button>
    </section>

<section id="mainingredient-setup">    
<ul> 
    ${mainingredient
      .map(mainingredientPage => {
        return `
             <li class="mainingredient-list" id="mainingredient">
                <h2>${mainingredientPage.ingredient}</h2>
                <img src=${mainingredientPage.image} class="MainIngredientImage"></img>
                <p><input class="mainingredient_id" type="hidden" value="${mainingredientPage.id}"></p>
                <button class="edit-MainIngredient_submit">Edit</button>
                <button class="delete-MainIngredient_submit">Delete</button>
             </li>
        `;
      })
      .join("")}
 </ul>
 </section>
    `;
}
    
    