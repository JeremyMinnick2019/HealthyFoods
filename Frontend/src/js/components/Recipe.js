export default function Recipe(recipe) {
    return `

<section id="Recipe-setup">    
<ul> 
    ${recipe
      .map(recipePage => {
        return `
             <li class="recipe-list" id="recipe">
                <h2>${recipePage.title}</h2>
                <img src=${recipePage.image} class="albumIMG"></img>
                <h4>${recipePage.calorie}</h4>
                <p>${recipePage.instructions}</p>
                <p><input class="mealtype_id" type="hidden" value="${recipePage.Id}"></p>
                <p><input class="mealtype_id" type="hidden" value="${recipePage.MainIngredientId}"></p>
             </li>
        `;
      })
      .join("")}
 </ul>
    `;
}