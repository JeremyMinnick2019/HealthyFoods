export default function MealType(mealtype) {
    return `

<section id="MealType-setup">    
<ul> 
    ${mealtype
      .map(mealtypePage => {
        return `
             <li class="mealtype-list" id="mealtype">
                <h2>${mealtypePage.type}</h2>
                <p><input class="mealtype_id" type="hidden" value="${mealtypePage.Id}"></p>
                <p><input class="mealtype_id" type="hidden" value="${mealtypePage.MainIngredientId}"></p>
             </li>
        `;
      })
      .join("")}
 </ul>
    `;
}