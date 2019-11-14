export default function MainIngredient(mainingredient) {
    return `

<section id="mainingredient-setup">    
<ul> 
    ${mainingredient
      .map(mainingredientPage => {
        return `
             <li class="select-album" id="album">
                <h2>${mainingredientPage.ingredient}</h2>
                <p><input class="album_id" type="hidden" value="${mainingredientPage.Id}"></p>
             </li>
        `;
      })
      .join("")}
 </ul>
    `;
}
    
    