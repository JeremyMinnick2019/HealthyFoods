export default function MealType(mealtype) {
    return `

  <section class='add-MealType'>
    <input class='add-Meal' type='text' placeholder='Add A Meal type'>
    <button class='add-MealType_submit'>Submit</button>
  </section>

<section id="MealType-setup">    
<ul> 
    ${mealtype
      .map(mealtypePage => {
        return `
             <li class="mealtype-list" id="mealtype">
                <h2>${mealtypePage.type}</h2>
                <p><input class="mealtype_id" type="hidden" value="${mealtypePage.id}"></p>
                <p><input class="mealtype_id" type="hidden" value="${mealtypePage.mainingredientid}"></p>
                <button class="edit-MealType_submit">Edit</button>
                <button class="delete-MealType_submit">Delete</button>
             </li>
        `;
      })
      .join("")}
 </ul>
    `;
}