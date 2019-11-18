export default function MealType(mealtype) {
    return `
    <div class = "row">
      <section class='add-MealType'>
        <input class='add-Meal' type='text' placeholder='Add A Meal type'>
        <button class='add-MealType_submit'>Submit</button>
      </section>
  </div>

<section id="MealType-setup">    
<ul> 
    ${mealtype
      .map(mealtypePage => {
        return `
        <div class = "row">
             <li class="mealtype-list" id="mealtype">
                <h2>${mealtypePage.type}</h2>
                <p><input class="mealtype_id" type="hidden" value="${mealtypePage.id}"></p>
                <button class="edit-MealType_submit">Edit</button>
                <button class="delete-MealType_submit">Delete</button>
             </li>
        </div>
        `;
      })
      .join("")}
 </ul>
 </section>
    `;
}