export default function MainIngredient(mainingredient) {
    return `

<section id="mainingredient-setup">    
<ul> 
    ${mainingredient
      .map(mainingredientPage => {
        return `
             <li class="mainingredient-list" id="mainingredient">
                <h2>${mainingredientPage.ingredient}</h2>
                <img src=${mainingredientPage.image} class="albumIMG"></img>
                <p><input class="mainingredient_id" type="hidden" value="${mainingredientPage.Id}"></p>
             </li>
        `;
      })
      .join("")}
 </ul>
    `;
}
    
    